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
		public ucUserAll()
		{
			InitializeComponent();
		}
		public ucUserAll(UserUI Parent)
		{
			InitializeComponent();
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id ;
		}
		public void SetAvatar(string path)
        {
			gunaPic.Image = Image.FromFile(path);
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
        private void gunaPic_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void pnContrainName_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void pnContainId_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void pnContain_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void picMenu_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void lbName_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void lbId_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
        private void gunaPic_MouseLeave(object sender, EventArgs e)
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
        private void picMenu_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.White;
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
    }
}
