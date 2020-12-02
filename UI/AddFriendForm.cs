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
		public Button btnFocus;
		public bool CheckLoadAllUser;

		public int countUserAll = 0;
		public int countUserOnline = 0;
		public int countPending = 0;
		private Form1 mainForm;
		public ServerForm(Form1 mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			panelAllUser = new Panel(); panelAllUser.AutoScroll = true;
			panelOnlineUser = new Panel(); panelOnlineUser.AutoScroll = true;
			panelPending = new Panel(); panelPending.AutoScroll = true;
			this.Controls.Add(panelAllUser);
			this.Controls.Add(panelOnlineUser);
			this.Controls.Add(panelPending);
			this.InitPanelAllUser();
			this.InitPanelOnlineUser();
			this.InitPanelPending();
			CheckLoadAllUser = false;
			labelCOUNT.Text = "";
			btnFocus = null;
			picPoint.Visible = false;
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
			panelAllUser.BackColor = Color.White;
			panelAllUser.Padding = new Padding(30, 20, 0, 0);
			panelAllUser.BringToFront();
		}
		private void InitPanelOnlineUser()
		{
			panelOnlineUser.Dock = DockStyle.Fill;
			panelOnlineUser.BackColor = Color.White;
			panelOnlineUser.Padding = new Padding(30, 20, 0, 0);
			panelOnlineUser.BringToFront();
		}
		private void btnOnline_Click(object sender, EventArgs e)
		{
			if (btnFocus != null) btnFocus.BackColor = Color.White;
			(sender as Button).BackColor = Color.DarkGray;
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
			if (btnFocus != null) btnFocus.BackColor = Color.White;
			(sender as Button).BackColor = Color.DarkGray;
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
			if (btnFocus != null) btnFocus.BackColor = Color.White;
			(sender as Button).BackColor = Color.DarkGray;
			btnFocus = sender as Button;
			panelPending.Show();
			panelPending.BringToFront();
			labelCOUNT.Text = "Pending - " + countPending.ToString();
			picPoint.Visible = false;
			mainForm.DisableNotification();
		}
    }
}
