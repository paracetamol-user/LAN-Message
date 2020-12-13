using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucVoiceMessage : UserControl
	{
		private NAudio.Wave.DirectSoundOut player;
		private NAudio.Wave.WaveFileReader wave;
		private ucUserINChatBox ucParent;
		public User user;
		public Group group;

		public string Path { get; set; }
		public int VoiceID { get; set; }

		public ucVoiceMessage()
		{
			InitializeComponent();
		}
		public ucVoiceMessage(User user, ucUserINChatBox ucParent)
		{
			InitializeComponent();
			this.user = user;
			this.ucParent = ucParent;
			Path = string.Format(@"..\..\{0}\", user.Id);

			if (!Directory.Exists(Path))
				Directory.CreateDirectory(Path);

			VoiceID = GetNextID();
		}
		public ucVoiceMessage(Group group, ucUserINChatBox ucParent)
		{
			InitializeComponent();
			this.group = group;
			this.ucParent = ucParent;
			Path = string.Format(@"..\..\G_{0}\", group.ID);

			if (!Directory.Exists(Path))
				Directory.CreateDirectory(Path);

			VoiceID = GetNextID();
		}

		private int GetNextID()
		{
			int id = 0;
			while (true)
			{
				if (!File.Exists(string.Format("{0}{1}.wav", Path, id)))
					return id;
				id++;
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (player == null)
			{
				if (wave == null)
					wave = new NAudio.Wave.WaveFileReader(Path);
				player = new NAudio.Wave.DirectSoundOut();
				player.Init(wave);
				player.Play();
			}
            else
            {
				player.Play();
            }
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if(player != null)
			{
				player.Pause();
			}
		}
        private void pictureBox4_Click(object sender, EventArgs e)
        {
			if(player != null)
            {
				player.Stop();
				player.Dispose();
            }
        }
    }
}
