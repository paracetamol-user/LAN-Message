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
			this.lbName.Text = uiParent.user.Name;
			this.lbId.Text = uiParent.user.Id;
		}
		public void ResetTheme()
        {
			this.picCheck.Image = Image.FromFile(FrmMain.theme.PictureCheck);
			this.picClose.Image = Image.FromFile(FrmMain.theme.PictureClose);
		}
		public void InitColor()
		{
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextMenuColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
		}
		private void pnContain_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = FrmMain.theme.FocusColor;
		}

		private void pnContain_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.Transparent;
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
			byte[] tempbuff = Encoding.UTF8.GetBytes("ACCEPTFRIEND%" + FrmMain.me.Id + "%" + uiParent.user.Id);
			SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
			FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
		}
    }
}
