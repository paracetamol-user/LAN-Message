using Network;
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
			this.Show();
			this.BringToFront();
			this.selectedUser = selectedUser;
			this.pnGroup.Controls.Clear();
			this.pnLine.BackColor = Form1.theme.LineColor;
			LoadGroupOption();
		}
	
		private void LoadGroupOption()
		{
			foreach(var item in Form1.GroupUIs)
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
            foreach (var item in listAdd)
            {
				byte[] tempbuff = Encoding.UTF8.GetBytes("GPENDING%" + item.ID + "%" +
																   item.Name + "%" +
																   selectedUser.Id);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			}
			
		}
 
        private void picBoxAdd_Click(object sender, EventArgs e)
        {
			this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			SendAddToGroupToServer();
			this.Hide();
		}
    }
}
