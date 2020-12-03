using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
	public partial class ServerForm : Form
	{
		public Panel panelAllUser;
		public Panel panelOnlineUser;
		public Panel panelPending;
		public Panel panelListSearch;
		public Button btnFocus;
		public ucSearch ucSearch;
		public bool CheckLoadAllUser;

		public int countUserAll = 0;
		public int countUserOnline = 0;
		public int countPending = 0;
		private Form1 mainForm;
		public ServerForm(Form1 mainForm)
		{
			InitializeComponent();
			InitControls();
			this.mainForm = mainForm;
		}
		public void ChangeColorControl()
        {
			this.ucSearch.ResetTheme();
        }
		public void ResetPicture()
        {
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PictureGroup);
        }
		public void ChangeColorLine()
        {
			this.panelLine.BackColor = Form1.theme.LineColor;
        }
        private void InitControls()
        {
			panelAllUser = new Panel(); panelAllUser.AutoScroll = true;
			panelOnlineUser = new Panel(); panelOnlineUser.AutoScroll = true;
			panelPending = new Panel(); panelPending.AutoScroll = true;
			panelListSearch = new Panel(); panelListSearch.AutoScroll = true;
			ucSearch = new ucSearch(Form1.UserUIs, pnContainListSearch, false, false);
			this.pnContainSearch.Controls.Add(ucSearch);
			this.Controls.Add(panelAllUser);
			this.Controls.Add(panelOnlineUser);
			this.Controls.Add(panelPending);
			this.InitPanelAllUser();
			this.InitPanelOnlineUser();
			this.InitPanelPending();
			this.InitPanelListSearch();
			CheckLoadAllUser = false;
			labelCOUNT.Text = "";
			btnFocus = null;
			picPoint.Visible = false;
		}
        private void InitPanelListSearch()
		{
			panelListSearch.Visible = false;
		}
		private void InitPanelPending()
		{
			panelPending.Dock = DockStyle.Fill;
			panelPending.Padding = new Padding(30, 20, 20, 0);
		}
		public void EnablePointPending()
		{
			picPoint.Visible = true;
		}
		private void LoadListAllUser()
		{
			for (int i = 0; i < Form1.UserUIs.Count; i++)
			{
				Form1.UserUIs[i].AddUserIntoPanelAll(panelAllUser);
			}
			countUserAll = Form1.UserUIs.Count;
		}
		private void InitPanelAllUser()
		{
			panelAllUser.Dock = DockStyle.Fill;
			panelAllUser.Padding = new Padding(30, 20, 0, 0);
			panelAllUser.BringToFront();
		}
		private void InitPanelOnlineUser()
		{
			panelOnlineUser.Dock = DockStyle.Fill;
			panelOnlineUser.Padding = new Padding(30, 20, 0, 0);
			panelOnlineUser.BringToFront();
		}
		private void btnOnline_Click(object sender, EventArgs e)
		{
			this.pnContainSearch.Visible = true;
			this.ucSearch.IsFriend = true;
			this.ucSearch.IsOnline = true;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = Form1.theme.FocusColor;
			countUserOnline = 0;
			panelOnlineUser.Controls.Clear();
			panelOnlineUser.Show();
			panelOnlineUser.BringToFront();
			for (int i = 0; i < Form1.UserUIs.Count; i++)
			{
				if (Form1.UserUIs[i].GetStatus() == true)
				{
					Form1.UserUIs[i].AddUserIntoPanelOnline(panelOnlineUser);
					countUserOnline++;
				}
			}
			labelCOUNT.Text = "Online - " + countUserOnline.ToString(); 
			btnFocus = sender as Button;
		}
		private void btnPeople_Click(object sender, EventArgs e)
		{
			this.pnContainSearch.Visible = true;
			this.ucSearch.IsFriend = false;
			this.ucSearch.IsOnline = false;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = Form1.theme.FocusColor;
			panelAllUser.Show();
			panelAllUser.BringToFront();
			if (!CheckLoadAllUser)
			{
				LoadListAllUser();
				CheckLoadAllUser = true;
			}
			labelCOUNT.Text = "All - " + countUserAll.ToString();
			btnFocus = sender as Button;
		}
		public void AddPending(UserUI userUI)
		{
			userUI.AddUserIntoPanelPending(panelPending);
		}
		public void RemovePending()
		{

		}
		private void btnPending_Click_1(object sender, EventArgs e)
		{
			this.pnContainSearch.Visible = false;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor =  Form1.theme.FocusColor;
			btnFocus = sender as Button;
			panelPending.Show();
			panelPending.BringToFront();
			labelCOUNT.Text = "Pending - " + countPending.ToString();
			picPoint.Visible = false;
			mainForm.DisableNotification();
		}

        private void btnPending_MouseMove(object sender, MouseEventArgs e)
        {
			(sender as Button).BackColor = Form1.theme.FocusColor;
		}

        private void btnPending_MouseLeave(object sender, EventArgs e)
        {
			(sender as Button).BackColor = Color.Transparent;
		}
    }
}
