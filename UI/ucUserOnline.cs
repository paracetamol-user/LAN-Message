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
			this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
			this.picAdd.Image = Image.FromFile(Form1.theme.PictureMenu);
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id;
		}
		public void ResetTheme()
        {
			this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
			this.picAdd.Image = Image.FromFile(Form1.theme.PictureMenu);
		}
		public void InitColor()
		{
			this.lbName.ForeColor = Form1.theme.TextColor;
			this.lbId.ForeColor = Form1.theme.TextMenuColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
		}
		public void EnableAddFriend()
        {
			this.picChat.Visible = false;
        }
		public void SetAvatar(string path)
        {
			this.gunaPic.Image = Image.FromFile(path);
        }
		public void ChangeColorWhenFocus()
        {
			this.BackColor = Form1.theme.FocusColor;
        }

        private void pnContainId_Click_1(object sender, EventArgs e)
        {
			Form1.addMemberForm.Hide();
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (Form1.interactFocus != null)
			{
				Form1.interactFocus.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			Form1.interactFocus = this.Parent.ucInterac;
		}
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
		}

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}

        private void picChat_Click(object sender, EventArgs e)
        {
			Form1.addMemberForm.Hide();
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (Form1.interactFocus != null)
			{
				Form1.interactFocus.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			Form1.interactFocus = this.Parent.ucInterac;
		}

        private async void picAdd_Click(object sender, EventArgs e)
        {
			Parent.cmns.Show(MousePosition);
		}

	}
}
