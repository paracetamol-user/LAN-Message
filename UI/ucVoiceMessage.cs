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

		private ucUserINChatBox userINChatBox;

		public string Path { get; set; }
		VoiceControl voice;

		public ucVoiceMessage()
		{
			InitializeComponent();
		}
		public ucVoiceMessage(string path, ucUserINChatBox userINChatBox)
        {
			InitializeComponent();
			this.Path = path;
			this.userINChatBox = userINChatBox;
        }

		public void InitColor()
		{
			this.BackColor = Form1.theme.FocusColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			DisposeAll();
			wave = new NAudio.Wave.WaveFileReader(Path);
			player = new NAudio.Wave.DirectSoundOut();
			player.Init(new NAudio.Wave.WaveChannel32(wave));
			player.Play();
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
				DisposeAll();
            }
        }

		private void DisposeAll()
        {
			if (player != null)
				player.Dispose();
			if (wave != null)
				wave.Dispose();

        }
    }
}
