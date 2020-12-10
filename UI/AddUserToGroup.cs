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
			this.mainForm = mainForm;
			listAdd = new List<Group>();
	}
		public void InitAddGroupForm(User selectedUser)
        {
			listAdd = new List<Group>();
			this.Show();this.BringToFront();
			this.selectedUser = selectedUser;
			this.pnGroup.Controls.Clear();
			LoadGroupOption();
		}
		private void picBoxAdd_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		private void LoadGroupOption()
		{
			foreach(var item in Form1.GroupUIs)
			{
				if (!item.group.MemberInGroup(selectedUser))
					this.pnGroup.Controls.Add(item.ucGroupToAdd);
			}
		}
		private async void SendAddToGroupToServer()
		{
            foreach (var item in listAdd)
            {
				byte[] tempBuff = Encoding.UTF8.GetBytes("GPENDING%" + item.ID + "%" +
																   item.Name + "%" +
																   selectedUser.Id);
				byte[] buff = new byte[1024];
				tempBuff.CopyTo(buff, 0);
				Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
			}
			
		}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
			SendAddToGroupToServer();
			this.Hide();
		}
    }
}
