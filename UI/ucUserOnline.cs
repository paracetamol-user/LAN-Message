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
		public ucUserOnline()
		{
			InitializeComponent();
		}
		public ucUserOnline(UserUI Parent)
		{
			InitializeComponent();
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id;
		}
		public void ChangeImage(string path)
        {
			this.gunaPic.Image = Image.FromFile(path);
        }
		public void ChangeColorWhenFocus()
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
        }
		private void gunaPic_Click(object sender, EventArgs e)
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
		private void lbName_Click(object sender, EventArgs e)
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
		private void lbId_Click(object sender, EventArgs e)
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
		private void ucUserOnline_Click(object sender, EventArgs e)
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
		private void pnContrainName_Click(object sender, EventArgs e)
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
		private void pnContainId_Click(object sender, EventArgs e)
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
		private void pnContain_Click(object sender, EventArgs e)
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

        private void ucUserOnline_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void pnContain_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void picMenu_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void pnContainId_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void pnContrainName_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void gunaPic_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void lbName_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }
        private void lbId_MouseMove(object sender, MouseEventArgs e)
        {
			this.ChangeColorWhenFocus();
        }

        private void ucUserOnline_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
        }
        private void pnContain_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
		}
        private void pnContainId_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
		}
        private void pnContrainName_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
		}
        private void pnContainPicture_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
		}
        private void lbName_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
		}
        private void lbId_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
		}
    }
}
