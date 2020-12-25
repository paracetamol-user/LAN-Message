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
using UserManager;

namespace UI
{
	public partial class ServerForm : Form
	{
		public Panel panelAllUser;
		public Panel panelOnlineUser;
		public Panel panelPending;
		public Panel panelListSearch;
		public ucGroup ucGroup;

		public Button btnFocus;
		public ucSearch ucSearch;
		public bool CheckLoadAllUser;

		public int countUserAll = 0;
		public int countUserOnline = 0;
		public int countPending = 0;
		public FrmMain mainForm;
		public ServerForm(FrmMain mainForm)
		{
			InitializeComponent();
			InitControls();
			this.mainForm = mainForm;
		}
		public void _AddNewUser(UserUI newUser)
        {
			newUser.AddUserIntoPanelAll(panelAllUser);
			countUserAll = FrmMain.UserUIs.Count;
        }
		public void ChangeColorControl()
        {
			this.ucSearch.ResetTheme();
            foreach (var item in panelAllUser.Controls)
            {
				if (item.GetType() == typeof(ucUserAll))
                {
					(item as ucUserAll).InitColor();
                }
            }
			foreach (var item in panelOnlineUser.Controls)
			{
				if (item.GetType() == typeof(ucUserOnline))
				{
					(item as ucUserOnline).InitColor();
				}
			}
		}

		public void ChangeColorLine()
        {
			this.panelLine.BackColor = FrmMain.theme.LineColor;
        }
        public void InitControls()
        {
			ucGroup = new ucGroup();  
			panelAllUser = new Panel(); panelAllUser.AutoScroll = true;
			panelOnlineUser = new Panel(); panelOnlineUser.AutoScroll = true;
			panelPending = new Panel(); panelPending.AutoScroll = true;
			panelListSearch = new Panel(); panelListSearch.AutoScroll = true;
			ucSearch = new ucSearch(FrmMain.UserUIs, pnContainListSearch, false, false);
			this.pnContainSearch.Controls.Add(ucSearch);
			this.Controls.Add(panelAllUser);
			this.Controls.Add(panelOnlineUser);
			this.Controls.Add(panelPending);
			this.Controls.Add(ucGroup);
			this.InitPanelAllUser();
			this.InitPanelOnlineUser();
			this.InitPanelPending();
			this.InitPanelListSearch();
			CheckLoadAllUser = false;
			labelCOUNT.Text = "";
			btnFocus = null;
			picPoint.Visible = false;
		}
        public void InitPanelListSearch()
		{
			panelListSearch.Visible = false;
			pnContainListSearch.Padding = new Padding(30, 20, 20, 0);
		}
		public void InitPanelPending()
		{
			panelPending.Dock = DockStyle.Fill;
			panelPending.Padding = new Padding(30, 20, 20, 0);
		}
		public void EnablePointPending()
		{
			picPoint.Visible = true;
		}
		public void LoadListAllUser()
		{
			for (int i = 0; i < FrmMain.UserUIs.Count; i++)
			{
				FrmMain.UserUIs[i].AddUserIntoPanelAll(panelAllUser);
			}
			countUserAll = FrmMain.UserUIs.Count;
		}
		public void InitPanelAllUser()
		{
			panelAllUser.Dock = DockStyle.Fill;
			panelAllUser.Padding = new Padding(30, 20, 0, 0);
			panelAllUser.BringToFront();
		}
		public void InitPanelOnlineUser()
		{
			panelOnlineUser.Dock = DockStyle.Fill;
			panelOnlineUser.Padding = new Padding(30, 20, 0, 0);
			panelOnlineUser.BringToFront();
		}
		public void btnOnline_Click(object sender, EventArgs e)
		{
			this.pnContainSearch.Visible = true;
			this.ucSearch.IsFriend = true;
			this.ucSearch.IsOnline = true;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
			countUserOnline = 0;
			panelOnlineUser.Controls.Clear();
			
			for (int i = 0; i < FrmMain.UserUIs.Count; i++)
			{
				if (FrmMain.UserUIs[i].GetStatus() == true)
				{
					FrmMain.UserUIs[i].AddUserIntoPanelOnline(panelOnlineUser);
					countUserOnline++;
				}
			}
			labelCOUNT.Text = "People Online In Server - " + countUserOnline.ToString(); 
			btnFocus = sender as Button;
			panelOnlineUser.Show();
			panelOnlineUser.BringToFront();
		}
		public void btnPeople_Click(object sender, EventArgs e)
		{
			this.pnContainSearch.Visible = true;
			this.ucSearch.IsFriend = false;
			this.ucSearch.IsOnline = false;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
			countUserAll = 0;
			panelAllUser.Controls.Clear();

			LoadListAllUser();
			labelCOUNT.Text = "All People In Server - " + countUserAll.ToString();
			btnFocus = sender as Button;
			panelAllUser.Show();
			panelAllUser.BringToFront();
		}
		public void AddPending(UserUI userUI)
		{
			userUI.AddUserIntoPanelPending(panelPending);
		}
		public void AddGroupPending(GroupUI groupUI)
        {
			groupUI.AddGroupIntoPanelPending(panelPending);
        }
		public void RemovePending()
		{

		}
		public void btnPending_Click_1(object sender, EventArgs e)
		{
			this.pnContainSearch.Visible = false;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor =  FrmMain.theme.FocusColor;
			btnFocus = sender as Button;
			panelPending.Show();
			panelPending.BringToFront();
			labelCOUNT.Text = "Pending - " + countPending.ToString();
			picPoint.Visible = false;
			mainForm.DisableNotification();
		}

        public void btnPending_MouseMove(object sender, MouseEventArgs e)
        {
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
		}

        public void btnPending_MouseLeave(object sender, EventArgs e)
        {
			(sender as Button).BackColor = Color.Transparent;
		}
		public void InitStart()
        {
			this.pnContainSearch.Visible = true;
			this.ucSearch.IsFriend = false;
			this.ucSearch.IsOnline = false;
			btnPeople.BackColor = FrmMain.theme.FocusColor;
			countUserAll = 0;
			panelAllUser.Controls.Clear();
			LoadListAllUser();
			labelCOUNT.Text = "All People In Server - " + countUserAll.ToString();
			btnFocus = btnPeople;
			panelAllUser.Show();
			panelAllUser.BringToFront();
		}
    }
}
