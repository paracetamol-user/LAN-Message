using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UserManager;
using System.Threading;

namespace UI
{
	public partial class ucFileShow : UserControl
	{
		private ucUserINChatBox ucparent;
		private string fileId;
		private string fileName;
		public User user;
		public ucFileShow()
		{
			InitializeComponent();
		}
		public ucFileShow(User user , string fileId , string fileName, ucUserINChatBox ucUserINChatBox)
		{
			InitializeComponent();
			this.ucparent = ucUserINChatBox;
			this.user = user;
			this.fileId = fileId;
			this.fileName = fileName;
			this._FileName = fileName;
		}
		public void InitColor()
		{
			this.label1.ForeColor = Form1.theme.TextColor;
			this.BackColor = Form1.theme.FocusColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
		}

		public ucUserINChatBox _panelParent
		{
			set
			{
				this.ucparent = value;
			}
		}
		public string _FileId
		{
			get
			{
				return this.fileId;
			}
			set
			{
				this.fileId = value;
			}
		}
		public string _FileName
		{
			get
			{
				return this.label1.Text;
			}
			set
			{
				this.label1.Text = value;
			}
		}
		public User _User
		{
			set
			{
				this.user = value;
			}
		}
		private async void pictureBox2_Click(object sender, EventArgs e)
		{
			byte[] buff = new byte[1024];
			byte[] tempbuff;
			tempbuff = System.Text.Encoding.UTF8.GetBytes("SENDFILE%" + this.fileId + "%" + this.label1.Text + "%" + user.Id);
			tempbuff.CopyTo(buff, 0);
			await Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
			PictureBox temp = sender as PictureBox;
			temp.Image = Image.FromFile(@"..\..\images\check.png");
			temp.Enabled = false;
		}
		public void _DisableButDownLoad()
		{
			this.pictureBoxDownLoad.Visible = false;
		}

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
			this.ucparent.BackColor = Form1.theme.Menu;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
			this.ucparent.BackColor = Color.Transparent;
        }
		public string GetText()
        {
			return this.label1.Text;
        }
		public void DeleteMessage()
        {
			this.label1.Text = "Deleted file";
			this.label1.Font = new Font("Dubai", 10, FontStyle.Underline);
		}
    }
}
