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
		Panel pnAllFriend;
		Panel pnGroup;
		Panel pnOnlineFriend;
		Panel pnDanhba;
		Button btnFocus;

		ucGroup UcGroup;

		bool isLoad;
		public FrmFriend()
		{
			InitializeComponent();
			UcGroup = new ucGroup();
			InitPnAllFriend();
			InitPnOnlineFriend();
			InitPnGroup();
			isLoad = false;
			btnFocus = null;
		}
		public void Reset()
        {
			//if (btnFocus!=null) btnFocus.BackColor = Color.White;
			//btnFocus = null;
			//pnAllFriend.Visible = false;
			//pnOnlineFriend.Visible = true;
			//pnOnlineFriend.Show();
			//pnOnlineFriend.BringToFront();
			isLoad = false;
        }
		public void LoadPnAllFriend()
		{
			foreach (var item in Form1.UserUIs)
			{
				if (item.user.IsFriend)
				{
					pnAllFriend.Controls.Add(item.ucFriend);
				}
			}
		}
		private void InitPnOnlineFriend()
		{
			this.pnOnlineFriend = new Panel();
			this.pnOnlineFriend.Dock = DockStyle.Fill;
			this.pnOnlineFriend.Padding = new Padding(30, 20, 20, 0);
			this.pnOnlineFriend.BringToFront();
			this.pnOnlineFriend.Visible = false;
			this.Controls.Add(pnOnlineFriend);
		}
		private void InitPnAllFriend()
		{
			this.pnAllFriend = new Panel();
			this.pnAllFriend.Dock = DockStyle.Fill;
			this.pnAllFriend.Padding = new Padding(30, 20, 20, 0);
			this.pnAllFriend.BringToFront();
			this.pnAllFriend.Visible = false;
			this.Controls.Add(pnAllFriend);
		}
		private void InitPnGroup()
        {
			this.pnGroup = new Panel();
			this.pnGroup.Dock = DockStyle.Fill;
			this.pnGroup.Padding = new Padding(30, 20, 20, 0);
			this.pnGroup.BringToFront();
			this.pnGroup.Visible = false;
			this.Controls.Add(pnGroup);
        }
		private void LoadPnGroup()
        {
			pnGroup.Controls.Add(UcGroup);
			foreach(var item in Form1.GroupUIs)
            {
				UcGroup.Controls.Add(item.ucGroupAll);
            }
        }
		public void AddUserIntoFrmFriend(UserUI userUI)
		{
			if (!pnAllFriend.Contains(userUI.ucFriend))
				pnAllFriend.Controls.Add(userUI.ucFriend);
		}
		public void AddGroupIntoGroupForm(GroupUI groupUI)
        {
			if (!pnGroup.Contains(groupUI.ucGroupAll))
				pnGroup.Controls.Add(groupUI.ucGroupAll);
        }
		public void RemoveFriend(UserUI userUI)
		{
			if (pnAllFriend.Contains(userUI.ucFriend))
				pnAllFriend.Controls.Remove(userUI.ucFriend);
		}
		private void btnAll_Click(object sender, EventArgs e)
		{
			if (btnFocus != null) btnFocus.BackColor = Color.White;
			(sender as Button).BackColor = Color.DarkGray;
			btnFocus = sender as Button;
			if (!isLoad) LoadPnAllFriend();
			isLoad = true;
			this.pnAllFriend.Visible = true;
			pnAllFriend.Show();
			pnAllFriend.BringToFront();
		}
		private void btnOnline_Click(object sender, EventArgs e)
		{
			if (btnFocus != null) btnFocus.BackColor = Color.White;
			(sender as Button).BackColor = Color.DarkGray;
			btnFocus = sender as Button;
			pnOnlineFriend.Controls.Clear();
			pnOnlineFriend.Show();
			pnOnlineFriend.BringToFront();
			pnOnlineFriend.Visible = true;
			foreach (var item in Form1.UserUIs)
			{
				if (item.user.Status == true && item.user.IsFriend == true)
				{
					pnOnlineFriend.Controls.Add(item.ucFriendOnline);
				}
			}
		}
        private void btnGroup_Click(object sender, EventArgs e)
        {
			if (btnFocus != null) btnFocus.BackColor = Color.White;
			(sender as Button).BackColor = Color.DarkGray;
			btnFocus = sender as Button;
			pnGroup.Controls.Clear();
			pnGroup.Show();
			pnGroup.BringToFront();
			pnGroup.Visible = true;
			LoadPnGroup();
        }
    }
}
