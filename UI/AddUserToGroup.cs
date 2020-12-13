﻿using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class AddUserToGroup : Form
	{
		User selectedUser;
		Form1 mainForm;
		public List<Group> listAdd;
		public AddUserToGroup(Form1 mainForm)
		{
			InitializeComponent();
			InitControls();
			
			this.mainForm = mainForm;
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			this.mainForm.Controls.Add(this);
			this.pnContainAll.Location = new Point(mainForm.Width / 2 - this.pnContainAll.Width / 2, mainForm.Height / 2 - this.pnContainAll.Height / 2);
			listAdd = new List<Group>();
		}

		public void InitControls()
        {
			this.BackColor = Form1.theme.BackColor;
		}

        public void InitAddGroupForm(User selectedUser)
        {
			listAdd = new List<Group>();
			this.Show();
			this.BringToFront();
			this.selectedUser = selectedUser;
			this.pnGroup.Controls.Clear();
			this.pnLine.BackColor = Form1.theme.LineColor;
			LoadGroupOption();
		}
		public void ReLocation()
        {
			this.pnContainAll.Location = new Point(mainForm.Width / 2 - this.pnContainAll.Width / 2, mainForm.Height / 2 - this.pnContainAll.Height / 2);
		}
		private void LoadGroupOption()
		{
			foreach(var item in mainForm.GroupUIs)
			{
				if (!item.group.MemberInGroup(selectedUser))
				{
					item.ucGroupToAdd.Reset();
					this.pnGroup.Controls.Add(item.ucGroupToAdd);
				}
			}
		}
		private async void SendAddToGroupToServer()
		{
            foreach (var item in pnGroup.Controls)
			{ 
				if (item.GetType() == typeof(ucGroupToAdd))
				{
					if ((item as ucGroupToAdd).isAdd)
                    {
						listAdd.Add((item as ucGroupToAdd).group);
                    }
                }
            }
            foreach (var item in listAdd)
            {
				byte[] tempbuff = Encoding.UTF8.GetBytes("GPENDING%" + selectedUser.Id + "%" + item.ID + "%" + item.Name);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			}
			
		}
        private void picBoxAdd_Click_1(object sender, EventArgs e)
        {
			this.Hide();
		}

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
			SendAddToGroupToServer();
			this.Hide();
		}
    }
}
