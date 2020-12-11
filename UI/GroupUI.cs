using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public class GroupUI
	{
		public Group group;
		public GroupForm groupForm; // Khung chat của Group
		Form1 mainForm;
		public Panel panelINTERACTED;
		public Panel panelRIGHT;

		public ucGroupToAdd ucGroupToAdd;
		public ucGroupAll ucGroupAll;
		public ucInterac ucGroupInteract;
		public ucGroupPending ucGroupPending;
		public GroupUI(Group group, Form1 mainForm)
		{
			this.group = group;
			this.panelINTERACTED = mainForm.PnInteract;
			this.panelRIGHT = mainForm.PnRight;
			this.mainForm = mainForm;
			ucGroupAll = new ucGroupAll(group, this);
			InitGroupForm();
			ucGroupInteract = new ucInterac(this.group.Name);
			ucGroupInteract.SetGroup(this);
			ucGroupToAdd = new ucGroupToAdd(group,mainForm.addMemberForm);
		}
		public void InitGroupForm()
		{
			groupForm = new GroupForm(group,this);
			groupForm.TopLevel = false;
			groupForm.Dock = DockStyle.Fill;
			this.panelRIGHT.Controls.Add(groupForm);
		}
		public async void AddMessage(User user,string IDMess, string message)
		{
			groupForm.AddItemToListChat(user, IDMess,message);
			this.ucGroupInteract.AddMessage(user.Name + ": "+ message);
		}
		public void AddMessageIntoInteract(string name,string mess)
		{
			this.ucGroupInteract.AddMessage(name + ": "+mess);
		}
		public string GetID() => group.ID;
		public void SetAvatar(string path)
		{
			this.group.AvatarPath = path;
			this.groupForm.SetAvatar(path);
			this.ucGroupInteract.SetAvatar(path);
			this.ucGroupAll.SetAvatar(path);
		}
		public void AddPanelFile(string tempId, string tempName)
		{
		   // this.groupForm.AddFileToListChat();
		}
		public void BringToTop()
		{
			if (this.panelINTERACTED.Contains(ucGroupInteract))
			{
				this.panelINTERACTED.Controls.Remove(ucGroupInteract);
			}
			this.AddGroupInteracted();
		}
		public void AddGroupIntoPanelGroup(Panel panelGroupAll)
		{
			panelGroupAll.Controls.Add(ucGroupAll);
		}
		public void AddGroupIntoPanelPending(Panel pnPending)
		{
			ucGroupPending = new ucGroupPending(this, pnPending);
			pnPending.Controls.Add(ucGroupPending);
		}
		public void ShowChatForm()
		{
			groupForm.Show();
			groupForm.BringToFront();
			Form1.groupFormFocus = this.groupForm;
		}
		public void AddGroupInteracted()
		{
			if (this.panelINTERACTED.Contains(ucGroupInteract))
			{
				ucGroupInteract.Visible = true;
				ucGroupInteract.Dock = DockStyle.Top;
			}
			else
			{
				ucGroupInteract.Visible = true;
				ucGroupInteract.Dock = DockStyle.Top;
				this.panelINTERACTED.Controls.Add(ucGroupInteract);
			}
		}
		public void DeleteMessage(string IDMess)
		{
			this.groupForm.DeleteMessage(IDMess);
		}
		public void EditMessage(string idmess, string newMess)
		{
			this.groupForm.EditMessage(idmess, newMess);
		}
		public bool MemberInGroup(User user)
        {
			return group.MemberInGroup(user);
        }
	}
}
