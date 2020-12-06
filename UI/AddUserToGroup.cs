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
		Panel panelRight;

		public static Group SelectedGroup { get; set; }

		public AddUserToGroup(Panel panelRight)
		{
			InitializeComponent();
			this.panelRight = panelRight;
			this.Dock = DockStyle.Bottom;
			this.TopLevel = false;
		}
		public AddUserToGroup(User selectedUser, Panel panelRIGHT)
		{
			InitializeComponent();
			this.selectedUser = selectedUser;
			this.TopLevel = false;
			this.panelRight = panelRIGHT;
			this.Dock = DockStyle.Bottom;
			SelectedGroup = null;
		}
		public void InitAddGroupForm(User selectedUser)
        {
			this.selectedUser = selectedUser;
			LoadGroupOption();
        }
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		private void picBoxAdd_Click(object sender, EventArgs e)
		{
			SendAddToGroupToServer();
			this.Close();
		}
		private void LoadGroupOption()
		{
			this.panelRight.Controls.Add(this);
			foreach(var item in Form1.GroupUIs)
			{
				this.pnGroup.Controls.Add(item.ucGroupToAdd);
			}
		}
		private async void SendAddToGroupToServer()
		{
			byte[] tempBuff = Encoding.UTF8.GetBytes("GPENDING%" + SelectedGroup.ID + "%" +
																   SelectedGroup.Name + "%" + 
																   selectedUser.Id);
			byte[] buff = new byte[1024];
			tempBuff.CopyTo(buff, 0);
			Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
		}
	}
}
