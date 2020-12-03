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
			this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
			this.picMenu.Image = Image.FromFile(Form1.theme.PictureCmn);
			isPlus = true;
			this.Dock = DockStyle.Top;
			this.Parent = Parent;
			this.lbName.Text = Parent.user.Name;
			this.lbId.Text = "#"+Parent.user.Id ;
		}
		public void ResetTheme()
        {
			this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
			this.picMenu.Image = Image.FromFile(Form1.theme.PictureCmn);
		}
		public void InitColor()
		{
			this.lbName.ForeColor = Form1.theme.TextColor;
			this.lbId.ForeColor = Form1.theme.TextMenuColor;
			//this.BackColor = Form1.theme.BackColor;
			this.BackColor = Color.Transparent;
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
		private void gunaPic_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Form1.theme.FocusColor;
		}
		private void pnContain_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor =  Form1.theme.FocusColor;
		}
		private void picMenu_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor =  Form1.theme.FocusColor;
		}

		private void gunaPic_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor =  Color.Transparent;
		}
		private void pnContain_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.Transparent;
		}
		private void picMenu_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.Transparent;
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
		private void pnContainId_Click_1(object sender, EventArgs e)
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
		private void pnContrainName_Click_1(object sender, EventArgs e)
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
		private void lbName_Click_1(object sender, EventArgs e)
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
        private void pnContainId_MouseMove_1(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void pnContainId_MouseLeave_1(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void pnContrainName_MouseMove_1(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void pnContrainName_MouseLeave_1(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void lbName_MouseMove_1(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void lbName_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void lbId_MouseMove_1(object sender, MouseEventArgs e)
        {
			this.BackColor = Form1.theme.FocusColor;
		}
        private void lbId_MouseLeave(object sender, EventArgs e)
        {
			this.BackColor = Color.Transparent;
		}
        private void pictureBox1_Click(object sender, EventArgs e)
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
		private async void picMenu_Click(object sender, EventArgs e)
		{
			Parent.cmns.Show(MousePosition);
		}
    }
}
