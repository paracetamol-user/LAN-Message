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
using Network;

namespace UI
{
	public partial class ucFileShow : UserControl
	{
		public ucUserINChatBox ucParent;
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
			this.ucParent = ucUserINChatBox;
			this.user = user;
			this.fileId = fileId;
			this.fileName = fileName;

			this.label1.Text = fileName;
		}
		public ucFileShow(string fileId, string fileName)
		{
			InitializeComponent();
			this.fileId = fileId;
			this.fileName = fileName;
			this._FileName = fileName;
			this.label1.Text = fileName;
		}
		public void InitColor()
		{
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.label1.Text = fileName;
		}

		public ucUserINChatBox _panelParent
		{
			set
			{
				this.ucParent = value;
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
				return fileName;
			}
			set
			{
				fileName = value;
			}
		}
		public User _User
		{
            get
            {
				return this.user;
            }
			set
			{
				this.user = value;
			}
		}
		private async void pictureBox2_Click(object sender, EventArgs e)
		{
			try
			{
				if (ucParent != null) fileId = ucParent.ID;
				byte[] tempbuff = Encoding.UTF8.GetBytes("SENDFILE%" + fileId + "%" + fileName);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
				PictureBox temp = sender as PictureBox;
				//temp.Image = Image.FromFile(@"..\..\images\check.png");
				//temp.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public void _DisableButDownLoad()
		{
			this.pictureBoxDownLoad.Visible = false;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (FrmMain.chatBoxFocus != ucParent)
			{
				if (FrmMain.chatBoxFocus != null)
				{
				
					FrmMain.chatBoxFocus.DisableMenu();
				}
				FrmMain.chatBoxFocus = ucParent;
				this.ucParent.EnableMenu();
			}
			else return;
		}
		public string GetText()
        {
			return this.label1.Text;
        }
		public void DeleteMessage()
        {
			this._FileName = "Deleted file";
			this.label1.Text = "Deleted file";
			this.label1.Font = new Font("Tahoma", 10, FontStyle.Italic);
			this.pictureBoxDownLoad.Visible = false;
		}
    }
}
