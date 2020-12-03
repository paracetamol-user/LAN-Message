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
		Panel pnOnlineFriend;
		Panel pnDanhba;
		Button btnFocus;
		bool isload;
		public FrmFriend()
		{
			InitializeComponent();
			this.BackColor = Form1.theme.BackColor;
			InitPnAllFriend();
			InitPnOnlineFriend();
			isload = false;
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
			isload = false;
        }
		public void ResetPicture()
        {
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PictureMessage);
        }
		public void ChangeColorLine()
        {
			this.panelLine.BackColor = Form1.theme.LineColor;
        }
		public void LoadPnAllFriend()
		{
			foreach (var item in Form1.UserUIs)
			{
				if (item.user.IsFriend)
				{
					pnAllFriend.Controls.Add(item.ucFriend);
					item.ucFriend.InitColor();
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
		public void AddUserIntoFrmFriend(UserUI userUI)
		{
			if (!pnAllFriend.Contains(userUI.ucFriend))
				pnAllFriend.Controls.Add(userUI.ucFriend);
			userUI.ucFriend.InitColor();
		}
		public void RemoveFriend(UserUI userUI)
		{
			if (pnAllFriend.Contains(userUI.ucFriend))
				pnAllFriend.Controls.Remove(userUI.ucFriend);
			userUI.ucFriend.InitColor();
		}
		private void btnAll_Click(object sender, EventArgs e)
		{
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = Form1.theme.FocusColor;
			btnFocus = sender as Button;
			if (!isload) LoadPnAllFriend();
			isload = true;
			this.pnAllFriend.Visible = true;
			pnAllFriend.Show();
			pnAllFriend.BringToFront();
		}
		private void btnOnline_Click(object sender, EventArgs e)
		{
			if (btnFocus != null) btnFocus.BackColor = Color.Transparent;
			(sender as Button).BackColor = Form1.theme.FocusColor;
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
					item.ucFriend.InitColor();
				}
			}
		}
        private void btnAll_MouseMove(object sender, MouseEventArgs e)
        {
			(sender as Button).BackColor = Form1.theme.FocusColor;
		}
        private void btnAll_MouseLeave(object sender, EventArgs e)
        {
			(sender as Button).BackColor = Color.Transparent;
		}
    }
}
