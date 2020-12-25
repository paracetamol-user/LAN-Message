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
			this.picChat.Image = Image.FromFile(FrmMain.theme.PictureMessage);
			this.picMenu.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.roundPicAvatar.Image = Image.FromFile(Parent.user.AvatarPath);
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			isPlus = true;
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id ;
		}
		public void ResetTheme()
        {
			this.picChat.Image = Image.FromFile(FrmMain.theme.PictureMessage);
			this.picMenu.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextMenuColor;
		}
		public void InitColor()
		{
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbId.ForeColor = FrmMain.theme.TextMenuColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
			this.pnLine.BackColor = FrmMain.theme.LineColor;
		}
		public void SetAvatar(string path)
		{
			//gunaPic.Image = Image.FromFile(path);
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
			Parent.cmns.Show(MousePosition);
		}
        //private void gunaPic_Click(object sender, EventArgs e)
        //{

        //}
        //private void picMenu_MouseMove(object sender, MouseEventArgs e)
        //{
        //	this.BackColor =  Form1.theme.FocusColor;
        //}

        //private void gunaPic_MouseLeave(object sender, EventArgs e)
        //{
        //	this.BackColor =  Color.Transparent;
        //}
        //private async void picMenu_Click(object sender, EventArgs e)
        //{
        //	
        //}
    }
}
