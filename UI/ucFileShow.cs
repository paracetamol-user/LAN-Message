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
		private ucUserINChatBox ucParent;
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
				return this.label1.Text;
			}
			set
			{
				this.label1.Text = value;
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
			byte[] tempbuff = Encoding.UTF8.GetBytes("SENDFILE%" + this.fileId + "%" + this.label1.Text );
			SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
			Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			PictureBox temp = sender as PictureBox;
			//temp.Image = Image.FromFile(@"..\..\images\check.png");
			//temp.Enabled = false;
		}
		public void _DisableButDownLoad()
		{
			this.pictureBoxDownLoad.Visible = false;
		}

  //      private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
  //      {
		//	if (Form1.chatBoxFocus != ucParent)
		//	{
		//		if (Form1.chatBoxFocus != null)
		//		{
		//			Form1.chatBoxFocus.BackColor = Color.Transparent;
		//			Form1.chatBoxFocus.DisableMenu();
		//		}
		//		Form1.chatBoxFocus = ucParent;
		//		this.ucParent.EnableMenu();
		//		this.ucParent.BackColor = Form1.theme.Menu;
		//	}
		//	else return;
		//}
		public string GetText()
        {
			return this.label1.Text;
        }
		public void DeleteMessage()
        {
			this.label1.Text = "Deleted file";
			this.label1.Font = new Font("Dubai", 10, FontStyle.Underline);
			this.pictureBoxDownLoad.Visible = false;
		}
    }
}
