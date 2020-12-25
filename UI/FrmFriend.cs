using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
	public partial class FrmFriend : Form
	{
		Button btnFocus;
		bool isLoad;
		int friendOnlineCount;
		int friendCount;
		public FrmFriend()
		{
			InitializeComponent();
			this.BackColor = FrmMain.theme.BackColor;
			isLoad = false;
			btnFocus = null;
			this.pnAll.Dock = DockStyle.Fill;
			this.pnAll.BringToFront();
			this.pnOnline.Dock = DockStyle.Fill;
			friendOnlineCount = 0;
			friendCount = 0;
		}
        public void InitStart()
        {
			btnFocus = btnAll;
			btnAll.BackColor = FrmMain.theme.FocusColor;
			if (!isLoad) LoadpnAll();
			isLoad = true;
			this.pnAll.Visible = true;
			pnAll.Show();
			pnAll.BringToFront();
			labelCOUNT.Text = "All Friend - " + friendCount.ToString();
		}

		//public void ChangeColorControl()
  		//      {
		//	foreach (var item in pnAll.Controls)
		//	{
		//		if (item.GetType() == typeof(ucUserAll))
		//		{
		//			(item as ucUserAll).ResetTheme();
		//		}
		//	}
		//	foreach (var item in pnOnline.Controls)
		//	{
		//		if (item.GetType() == typeof(ucUserOnline))
		//		{
		//			(item as ucUserOnline).ResetTheme();
		//		}
		//	}
		//}
		public void ChangeColorLine()
        {
			this.panelLine.BackColor = FrmMain.theme.LineColor;
        }
		public void LoadpnAll()
		{
			foreach (var item in FrmMain.UserUIs)
			{
				if (item.user.IsFriend)
				{
					pnAll.Controls.Add(item.ucFriend);
					item.ucFriend.InitColor();
					friendCount++;
				}
			}
		}
		public void AddUserIntoFrmFriend(UserUI userUI)
		{
			if (!pnAll.Contains(userUI.ucFriend))
				pnAll.Controls.Add(userUI.ucFriend);
			userUI.ucFriend.InitColor();
			friendCount++;
		}
		public void RemoveFriend(UserUI userUI)
		{
			friendCount--;
			if (pnAll.Contains(userUI.ucFriend))
				pnAll.Controls.Remove(userUI.ucFriend);
			userUI.ucFriend.InitColor();
		}
		private void btnAll_Click(object sender, EventArgs e)
		{
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
			btnFocus = sender as Button;
			if (!isLoad) LoadpnAll();
			isLoad = true;
			this.pnAll.Visible = true;
			pnAll.Show();
			pnAll.BringToFront();
			labelCOUNT.Text = "All Friend - " + friendCount.ToString();
		}
		private void btnOnline_Click(object sender, EventArgs e)
		{
			friendOnlineCount = 0;
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
			btnFocus = sender as Button;
			pnOnline.Controls.Clear();
			pnOnline.Show();
			pnOnline.BringToFront();
			pnOnline.Visible = true;
			foreach (var item in FrmMain.UserUIs)
			{
				if (item.user.Status == true && item.user.IsFriend == true)
				{
					pnOnline.Controls.Add(item.ucFriendOnline);
					item.ucFriendOnline.InitColor();
					friendOnlineCount++;
				}
			}
			labelCOUNT.Text = "Friend Online - " + friendOnlineCount.ToString();
		}
        private void btnAll_MouseMove(object sender, MouseEventArgs e)
        {
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
		}
        private void btnAll_MouseLeave(object sender, EventArgs e)
        {
			(sender as Button).BackColor = Color.Transparent;
		}
	}
}
