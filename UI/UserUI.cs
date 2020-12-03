using Communication;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class UserUI
	{

		public UserForm userForm; // Khung Chat của user
		public User user;

		public Panel panelINTERACTED; 
		public Panel panelRIGHT;

		public ucUserAll ucUserAll;
		public ucUserOnline ucUserOnline;
		public ucInterac ucInterac;
		public ucPending ucPending;
		public ucFriend ucFriend;
		public ucFriend ucFriendOnline;
		public ucUserAll ucSearch;

		public ContextMenuStrip cmns;
		public UserUI() { }
		public UserUI(User user, Panel PANELINTERACTED, Panel PANELRIGHT)
		{
			this.user = user;
			this.panelINTERACTED = PANELINTERACTED;
			this.panelRIGHT = PANELRIGHT;
			InitUserForm();
			ucUserAll = new ucUserAll(this);
			ucUserOnline = new ucUserOnline(this);
			ucInterac = new ucInterac(this);
			this.panelRIGHT.Controls.Add(userForm);
			ucFriend = new ucFriend(this);
			ucFriendOnline = new ucFriend(this);
			ucSearch = new ucUserAll(this);
		}
		/// <summary>
		/// Get các thuộc tính
		/// </summary>
		public ucFriend UcFriend { get; set; }
		public ucInterac UcInterac { get; set; }
		public ucPending UcPending { get; set; }
		public ucUserAll UcUserAll { get; set; }
		public ucUserOnline UcUserOnline { get; set; }
		public User User { get; set; }
		/// <summary>
		/// Các hàm chức năng
		/// </summary>
		private void InitUserForm()
		{
			userForm = new UserForm(user);
			userForm.TopLevel = false;
			userForm.Dock = DockStyle.Fill;
			cmns = new ContextMenuStrip();
			cmns.Width = 100;
			cmns.RenderMode = ToolStripRenderMode.System;
			cmns.BackColor = Color.White;
			cmns.ShowImageMargin = false;

			ToolStripButton tsAddFriend = new ToolStripButton("ADD Friend");
			tsAddFriend.Click += TsAddFriend_Click;
			ToolStripButton tsAddGroup = new ToolStripButton("ADD Group");
			tsAddGroup.Click += TsAddGroup_Click;
			ToolStripButton tsRemoveFriend = new ToolStripButton("Remove Friend");
			tsRemoveFriend.Click += TsRemoveFriend_Click;
			tsRemoveFriend.ForeColor = Color.Red;
			ToolStripSeparator tsLine = new ToolStripSeparator();

			cmns.Items.Add(tsAddFriend);
			cmns.Items.Add(tsAddGroup);
			cmns.Items.Add(tsLine);
			cmns.Items.Add(tsRemoveFriend);
			DisableRemove();
		}
		private void TsRemoveFriend_Click(object sender, EventArgs e)
		{
			this.SendRemoveFriendToServer();
			Form1.frmFriend.RemoveFriend(this);
			DisableRemove();
			EnableADD();
			this.user.IsFriend = false;
		}
		private void TsAddGroup_Click(object sender, EventArgs e)
		{
			
		}
		private void TsAddFriend_Click(object sender, EventArgs e)
		{
			this.SendAddFriendToServer();
		}
		public void EnableRemove()
		{
			cmns.Items[3].Visible = true;
		}
		public void DisableRemove()
		{
			cmns.Items[3].Visible = false;
		}
		public void EnableADD()
		{
			cmns.Items[0].Visible = true;
		}
		public void DisableADD()
		{
			cmns.Items[0].Visible = false;
		}
		public async void SendAddFriendToServer()
		{
			byte[] tempbuff = Encoding.UTF8.GetBytes("PENDING%" + Form1.me.Id + "%" + user.Id);
			byte[] buff = new byte[1024];
			tempbuff.CopyTo(buff, 0);
			await Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
		}
		public async void SendRemoveFriendToServer()
		{
			var temp = MessageBox.Show("Remove Friend", "Remove Friend", MessageBoxButtons.YesNo);
			if (temp == DialogResult.Yes)
			{
				byte[] tempbuff = Encoding.UTF8.GetBytes("REMOVEFRIEND%" + Form1.me.Id + "%" + user.Id);
				byte[] buff = new byte[1024];
				tempbuff.CopyTo(buff, 0);
				await Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
			}
		}
		public void SetAvatar(string path)
		{
			this.user.AvatarPath = path;
			this.userForm.SetAvatar(path);
			this.ucInterac.SetAvatar(path);
			this.ucUserAll.SetAvatar(path);
			this.ucUserOnline.SetAvatar(path);
			this.ucSearch.SetAvatar(path);
		}
		public void ChangeStatusOnline()
		{
			ucInterac.Online();
		}
		public void ChangeStatusOffline()
		{
			ucInterac.Offline();
		}
		public void AddPanelFile(string tempId, string tempName)
		{
			this.userForm.AddFileToListChat(this.user, tempId, tempName);
		}
		public void BringToTop()
		{
			if (this.panelINTERACTED.Contains(ucInterac))
			{
				this.panelINTERACTED.Controls.Remove(ucInterac);
			}
			this.AddUserInteracted();
		}
		/// <summary>
		///  Các Hàm ADD vào các Panel
		/// </summary>
		/// <param name="panelAll"></param>
		public void AddUserIntoPanelAll(Panel panelAll)
		{
			panelAll.Controls.Add(ucUserAll);
		}
		public void AddUserIntoPanelPending(Panel panelPending)
		{
			ucPending = new ucPending(this, panelPending);
			panelPending.Controls.Add(ucPending);
		}
		public void AddUserIntoPanelFriend(Panel pnFriend)
		{
			pnFriend.Controls.Add(ucFriend);
		}
		public void AddUserIntoPanelOnline(Panel panelOnline)
		{
			panelOnline.Controls.Add(ucUserOnline);
		}
		public void AddUserIntoPanelListSearch(Panel panelListSearch)
        {
			panelListSearch.Controls.Add(ucSearch);
		}
		public void ShowChatForm()
		{
			// if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
			userForm.Show();
			userForm.BringToFront();
			Form1.userFormFocus = this.userForm;
		}
		public void AddUserInteracted()
		{
			if (this.panelINTERACTED.Contains(ucInterac))
			{
				ucInterac.Visible = true;
				ucInterac.Dock = DockStyle.Top;
			}
			else
			{
				ucInterac.Visible = true;
				ucInterac.Dock = DockStyle.Top;
				this.panelINTERACTED.Controls.Add(ucInterac);
			}
		}
		public string GetId()
		{
			return user.Id.ToString();
		}
		public async void AddMessage(string mess)
		{
			userForm.AddItemInToListChat(user, mess);
		}
		public bool GetStatus()
		{
			return user.Status;
		}
		public void SetStatus(bool status)
		{
			this.user.Status = status;
		}
	}
}
