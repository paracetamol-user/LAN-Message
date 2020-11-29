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
		}
        public void SetAvatar(string path)
        {
			this.user.AvatarPath = path;
			this.userForm.SetAvatar(path);
			this.ucInterac.SetAvatar(path);
			this.ucUserAll.SetAvatar(path);
			this.ucUserOnline.SetAvatar(path);
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
			this.userForm.AddFileToListChat(this.user, tempId, tempName, 2);
		}
		private void InitUserForm()
		{
			userForm = new UserForm(user);
			userForm.TopLevel = false;
			userForm.Dock = DockStyle.Fill;

		}
		public void BringToTop()
		{
			if (this.panelINTERACTED.Contains(ucInterac))
			{
				this.panelINTERACTED.Controls.Remove(ucInterac);
			}
			this.AddUserInteracted();
		}
		public void AddUserIntoPanelAll(Panel panelAll)
		{
			panelAll.Controls.Add(ucUserAll);
		}
		public void AddUserIntoPanelOnline(Panel panelOnline)
		{
			panelOnline.Controls.Add(ucUserOnline);
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
			userForm.AddItemInToListChat(user, mess, 2);
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
