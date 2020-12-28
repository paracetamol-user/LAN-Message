using Communication;

using Network;
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

		public FrmUser userForm; // Khung Chat của user
		public User user;
		public FrmMain mainForm;
		public Panel panelINTERACTED;
		public Panel panelRIGHT;

		public ucUserAll ucUserAll;
		public ucUserOnline ucUserOnline;
		public ucInterac ucInterac;
		public ucPending ucPending;
		public ucFriend ucFriend;
		public ucFriend ucFriendOnline;
		public ucUserAll ucSearch;
		public ucADD ucADD { get; set; }

		public ContextMenuStrip cmns;
		public UserUI() { }
		public UserUI(User user, FrmMain mainForm)
		{
			this.user = user;
			this.mainForm = mainForm;
			this.panelINTERACTED = mainForm.PnInteract;
			this.panelRIGHT = mainForm.PnRight;
			InitUserForm();
			InitCmns();
			this.panelRIGHT.Controls.Add(userForm);
			userForm.InitColor();
			ucUserAll = new ucUserAll(this);
			ucUserOnline = new ucUserOnline(this);
			ucInterac = new ucInterac(user.Name, user.Status);
			ucInterac.SetUser(this);
			ucInterac.InitColor();
			ucInterac.SetAvatar(user.AvatarPath);
			ucFriend = new ucFriend(this);
			ucFriendOnline = new ucFriend(this);
			ucSearch = new ucUserAll(this);
			ucADD = new ucADD(user);
		}

		public void InitCmns()
		{
			cmns = new ContextMenuStrip();
			cmns.Width = 100;
			cmns.RenderMode = ToolStripRenderMode.System;
			cmns.BackColor = FrmMain.theme.Menu;
			cmns.ShowImageMargin = false;
			ToolStripButton tsAddFriend = new ToolStripButton("ADD Friend");
			tsAddFriend.Click += TsAddFriend_Click;
			ToolStripButton tsAddGroup = new ToolStripButton("ADD Group");
			tsAddGroup.Click += TsAddGroup_Click;
			ToolStripButton tsRemoveFriend = new ToolStripButton("Remove Friend");
			tsRemoveFriend.Click += TsRemoveFriend_Click;
			cmns.Items.Add(tsAddFriend);
			cmns.Items.Add(tsAddGroup);
			cmns.Items.Add(tsRemoveFriend);
			DisableRemove();
		}

		public void ResetTheme()
		{
			this.userForm.BackColor = FrmMain.theme.BackColor;
			this.userForm.InitColor();
			InitCmns();
			ucUserAll.InitColor();
			ucUserOnline.InitColor();
			ucFriend.InitColor();
			ucADD.InitControls();
			ucInterac.InitColor();
			if (ucPending != null) ucPending.InitColor();
		}
		public void ResetPicture()
		{
			this.userForm.ResetPicture();
			this.ucInterac.ResetPicture();
		}
		private void InitUserForm()
		{
			userForm = new FrmUser(user, this);
			userForm.TopLevel = false;
			userForm.Dock = DockStyle.Fill;
		}
		private void TsRemoveFriend_Click(object sender, EventArgs e)
		{
			this.SendRemoveFriendToServer();
			FrmMain.frmFriend.RemoveFriend(this);
			DisableRemove();
			EnableADD();
			this.user.IsFriend = false;
		}
		private void TsAddGroup_Click(object sender, EventArgs e)
		{
			mainForm.AddToGroup.InitControls();
			mainForm.AddToGroup.InitAddGroupForm(this.user);
			mainForm.AddToGroup.Show();
			mainForm.BringToFront();
		}
		private void TsAddFriend_Click(object sender, EventArgs e)
		{
			this.SendAddFriendToServer();
		}
		public void EnableRemove()
		{
			cmns.Items[2].Visible = true;
		}
		public void DisableRemove()
		{
			cmns.Items[2].Visible = false;
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
			try
			{
				byte[] tempbuff = Encoding.UTF8.GetBytes("PENDING%" + FrmMain.me.Id + "%" + user.Id);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public async void SendRemoveFriendToServer()
		{
			try
			{
				var temp = MessageBox.Show("Remove Friend", "Remove Friend", MessageBoxButtons.YesNo);
				if (temp == DialogResult.Yes)
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("REMOVEFRIEND%" + FrmMain.me.Id + "%" + user.Id);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public void SetAvatar(string path)
		{
			this.user.AvatarPath = path;
			//this.userForm.SetAvatar(path);
			this.ucInterac.SetAvatar(path);
			this.ucUserAll.SetAvatar(path);
			this.ucUserOnline.SetAvatar(path);
			this.ucFriend.SetAvatar(path);
			this.ucFriendOnline.SetAvatar(path);
			this.ucSearch.SetAvatar(path);
			this.ucADD.SetAvatar(path);
		}
		public void ChangeStatusOnline()
		{
			ucInterac.Online();
			ucFriend.Online();
			ucFriendOnline.Online();
		}
		public void ChangeStatusOffline()
		{
			ucInterac.Offline();
			ucFriend.Offline();
			ucFriendOnline.Offline();
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
			ucUserAll.InitColor();
		}
		public void AddUserIntoPanelPending(Panel panelPending)
		{
			ucPending = new ucPending(this, panelPending);
			panelPending.Controls.Add(ucPending);
			ucPending.InitColor();
		}
		public void AddUserIntoPanelFriend(Panel pnFriend)
		{
			pnFriend.Controls.Add(ucFriend);
			ucFriend.InitColor();
		}
		public void AddUserIntoPanelOnline(Panel panelOnline)
		{
			panelOnline.Controls.Add(ucUserOnline);
			ucUserOnline.InitColor();
		}
		public void AddUserIntoPanelListSearch(Panel panelListSearch)
		{
			panelListSearch.Controls.Add(ucSearch);
			ucSearch.InitColor();
		}
		public void ShowChatForm()
		{
			// if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
			userForm.Show();
			userForm.BringToFront();
			FrmMain.userFormFocus = this.userForm;
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
			ucInterac.InitColor();
		}
		public string GetId()
		{
			return user.Id.ToString();
		}
		public async void AddMessage(string IDMess, string mess)
		{
			userForm.AddItemInToListChat(user, IDMess, mess);
			this.ucInterac.AddMessage(user.Name + ": " + mess);
		}
		public void AddMessageIntoInteract(string name, string mess)
		{
			this.ucInterac.AddMessage(name + ": " + mess);
		}
		public bool GetStatus()
		{
			return user.Status;
		}
		public void SetStatus(bool status)
		{
			this.user.Status = status;
		}
		public void EditMessage(string idmess, string newMess)
		{
			this.userForm.EditMessage(idmess, newMess);
		}
		public void DeleteMessage(string IDMess)
		{
			this.userForm.DeleteMessage(IDMess);
		}
		public void Dispose()
		{
			try
            {
				this.ucFriend.Dispose();
				this.ucInterac.Dispose();
				//this.ucPending.Dispose();
				this.ucUserAll.Dispose();
				this.ucADD.Dispose();
				this.ucFriendOnline.Dispose();
				this.ucSearch.Dispose();
				this.userForm.Dispose();
			}catch (Exception ex)
            {

            }
			
		}
	}
}
