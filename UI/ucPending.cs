using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
using Network;

namespace UI
{
	public partial class ucPending : UserControl
	{
		Panel pnParent;
		UserUI uiParent;
		public ucPending()
		{
			InitializeComponent();
		}
		public ucPending(UserUI userUI, Panel pnPending)
		{
			InitializeComponent();
		
			this.Dock = DockStyle.Top;
			this.pnParent = pnPending;
			this.uiParent = userUI;
			this.roundPicAvatar.Image = Image.FromFile(uiParent.user.AvatarPath);
			this.lbName.Text = userUI.user.Name;
			this.lbId.Text = "#" + userUI.user.Id;
			InitColor();
		}
		public void InitColor()
		{
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextMenuColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
			this.picCheck.Image = Image.FromFile(FrmMain.theme.PictureCheck);
			this.picClose.Image = Image.FromFile(FrmMain.theme.PictureClose);
		}
	

		private void picMenu_Click(object sender, EventArgs e)
		{
			pnParent.Controls.Remove(this);
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			FrmMain.frmFriend.AddUserIntoFrmFriend(uiParent);
			uiParent.DisableADD();
			uiParent.EnableRemove();
			uiParent.user.IsFriend = true;
			SendAcceptFriendToServer();
			pnParent.Controls.Remove(this);
		}

        private async void SendAcceptFriendToServer()
        {
			try
			{
				byte[] tempbuff = Encoding.UTF8.GetBytes("ACCEPTFRIEND%" + FrmMain.me.Id + "%" + uiParent.user.Id);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
    }
}
