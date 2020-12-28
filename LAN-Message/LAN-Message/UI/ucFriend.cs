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

namespace UI
{
	public partial class ucFriend : UserControl
	{
		private UserUI Parent;
		private Panel pnParent;
		public ucFriend()
		{
			InitializeComponent();
		}
		public ucFriend(UserUI userUI)
		{
			InitializeComponent();
			this.Dock = DockStyle.Top;
			this.Parent = userUI;
			this.lbName.Text = userUI.user.Name;
			this.lbId.Text = "#" + userUI.user.Id;
			using (FileStream fs = new FileStream(userUI.user.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
			if (Parent.user.Status == true) this.Online();
			else this.Offline();
			InitColor();
		}
		public void InitColor()
        {
			this.picmess.Image = Image.FromFile(FrmMain.theme.PictureMessage);
			this.picRemove.Image = Image.FromFile(FrmMain.theme.PictureCmn);
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextColor;
		}
		public void Online()
		{
			picStatus.Image = Image.FromFile(FrmMain.theme.pictureCircleOnline);
			picStatus.Visible = true;
		}
		public void Offline()
		{
			picStatus.Image = Image.FromFile(FrmMain.theme.pictureCircleOffline);
			picStatus.Visible = true;
		}
		private void picMenu_Click(object sender, EventArgs e)
		{
			Parent.cmns.BackColor = FrmMain.theme.Menu;
			Parent.cmns.Items[0].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Items[1].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Items[2].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Show(MousePosition);

		}
		private  void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (FrmMain.interactFocus != null)
			{
				FrmMain.interactFocus.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			FrmMain.interactFocus = this.Parent.ucInterac;
		}
        private void pnContainPicture_Click(object sender, EventArgs e)
        {
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (FrmMain.interactFocus != null)
			{
				FrmMain.interactFocus.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			FrmMain.interactFocus = this.Parent.ucInterac;
		}
		public void SetAvatar(string path)
        {
			using (FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}

        private void roundPicAvatar_Click(object sender, EventArgs e)
        {
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (FrmMain.interactFocus != null)
			{
				FrmMain.interactFocus.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			FrmMain.interactFocus = this.Parent.ucInterac;
		}
    }
}
