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

namespace UI
{
	public partial class ucUserAll : UserControl
	{
		private UserUI Parent;
		public bool isPlus;
		public ucUserAll()
		{
			InitializeComponent();
		}
		public ucUserAll(UserUI Parent)
		{
			InitializeComponent();
			this.roundPicAvatar.Image = Image.FromFile(Parent.user.AvatarPath);
			isPlus = true;
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id ;
			InitColor();
		}
		public void InitColor()
        {
			this.picChat.Image = Image.FromFile(FrmMain.theme.PictureMessage);
			this.picMenu.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextMenuColor;
			this.BackColor = Color.Transparent;
		}
		public void SetAvatar(string path)
		{
			this.roundPicAvatar.Image = Image.FromFile(path);
		}

        private void ucUserAll_Click(object sender, EventArgs e)
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

        private void picMenu_Click(object sender, EventArgs e)
        {
			Parent.cmns.BackColor = FrmMain.theme.Menu;
			Parent.cmns.Items[0].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Items[1].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Items[2].ForeColor = FrmMain.theme.TxtForeColor;
			Parent.cmns.Show(MousePosition);
		}

    }
}
