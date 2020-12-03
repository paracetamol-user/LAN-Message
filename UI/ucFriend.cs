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
			this.picmess.Image = Image.FromFile(Form1.theme.PictureMessage);
			this.picRemove.Image = Image.FromFile(Form1.theme.PictureCmn);
			this.Dock = DockStyle.Top;
			this.Parent = userUI;
			this.lbName.Text = userUI.user.Name;
			this.lbId.Text = userUI.user.Id;
		}
		public void InitColor()
		{
			this.lbName.ForeColor = Form1.theme.TextColor;
			this.lbId.ForeColor = Form1.theme.TextColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
		}
		private void pnContain_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Form1.theme.FocusColor ;
		}

		private void pnContain_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.Transparent;
		}
		private void picMenu_Click(object sender, EventArgs e)
		{
			Parent.cmns.Show(MousePosition);
		}
		private  void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			Form1.userUIForcus = this.Parent;
		}

        private void pnContainPicture_Click(object sender, EventArgs e)
        {
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			Form1.userUIForcus = this.Parent;
		}
    }
}
