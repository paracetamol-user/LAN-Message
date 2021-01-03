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
	public partial class ucUserOnline : UserControl
	{
		public UserUI Parent;
		public bool isPlus;
		public ucUserOnline()
		{
			InitializeComponent();
		}
		public ucUserOnline(UserUI Parent)
		{
			isPlus = true;
			InitializeComponent();
			
			using (FileStream fs = new FileStream(Parent.user.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id;
			InitColor();
		}
		public void InitColor()
        {
			this.picChat.Image = Image.FromFile(FrmMain.theme.PictureMessage);
			this.picAdd.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextMenuColor;
		}
		public void EnableAddFriend()
        {
			this.picChat.Visible = false;
        }
		public void SetAvatar(string path)
        {
			using (FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
		public void ChangeColorWhenFocus()
        {
			this.BackColor = FrmMain.theme.FocusColor;
        }
        private void pnContainId_Click_1(object sender, EventArgs e)
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
        private void picChat_Click(object sender, EventArgs e)
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
        private async void picAdd_Click(object sender, EventArgs e)
        {
			Parent.cmns.BackColor = FrmMain.theme.Menu;
			Parent.cmns.Items[0].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Items[1].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Items[2].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Show(MousePosition);
		}

	}
}
