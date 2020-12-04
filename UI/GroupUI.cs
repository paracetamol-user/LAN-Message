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

        public Panel panelINTERACTED;
        public Panel panelRIGHT;

        public ucGroupAll ucGroupAll;
        public ucGroupInteract ucGroupInteract;
        public ucGroupPending ucGroupPending;

        public GroupUI(Group group, Panel interact, Panel right)
        {
            this.group = group;
            this.panelINTERACTED = interact;
            this.panelRIGHT = right;
        }

        public ucGroupAll UcGroupAll { get; set; }
        public ucGroupInteract UcGroupInteract { get; set; }
        public ucGroupPending UcGroupPending { get; set; }

        public void InitGroupForm()
        {
            groupForm = new GroupForm(group);
            groupForm.TopLevel = false;
            groupForm.Dock = DockStyle.Fill;
        }
        public async void AddMessage(User user, string message) 
            => groupForm.AddItemToListChat(user, message);
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
        public void AddGroupIntoPanelAll(Panel panelGroupAll)
        {
            panelGroupAll.Controls.Add(ucGroupAll);
        }
        public void AddGroupIntoPanelGroupPending(Panel panelGPending)
        {
            ucGroupPending = new ucGroupPending(this, panelGPending);
            panelGPending.Controls.Add(ucGroupPending);
        }
        public void AddGroupIntoPanelAddedGroup(Panel pnGroup)
        {
            //
        }
        public void ShowChatForm()
        {
            groupForm.Show();
            groupForm.BringToFront();
            // Form1.groupFormFocus = this.groupForm;
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
    }
}
