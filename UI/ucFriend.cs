using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			this.lbId.Text = userUI.user.Id;
			this.roundPicAvatar.Image = Image.FromFile(userUI.user.AvatarPath);
			InitColor();
		}
		public void InitColor()
        {
			this.picmess.Image = Image.FromFile(FrmMain.theme.PictureMessage);
			this.picRemove.Image = Image.FromFile(FrmMain.theme.PictureCmn);
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextColor;
		}

		private void picMenu_Click(object sender, EventArgs e)
		{
			Parent.cmns.BackColor = FrmMain.theme.Menu;
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
    }
}
