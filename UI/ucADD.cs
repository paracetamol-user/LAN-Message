using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucADD : UserControl
	{
		public User user { get; set; }
		public bool isAdd { get; set; }
		public ucADD() { }
		public ucADD(User user)
		{
			InitializeComponent();
			this.user = user;
			this.label1.Text = user.Name;
			this.label2.Text = "#" + user.Id;
			
			this.Dock = DockStyle.Top;
			InitControls();
		}
		public void InitControls()
		{
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.label2.ForeColor = FrmMain.theme.TextColor;
			using (FileStream fs = new FileStream(user.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
		public void Reset()
        {
			button1.Text = "ADD";
			isAdd = false;
		}
		public void SetAvatar(string path)
        {
			using (FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
        private void button1_Click(object sender, EventArgs e)
        {
			if (button1.Text == "ADD")
			{
				isAdd = true;
				button1.Text = "CANCEL";
			}
			else
			{
				isAdd = false;
				button1.Text = "ADD";
			}
		}
    }
}
