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
        Group selectedGroup;
        User selectedUser;
        public AddUserToGroup()
        {
            InitializeComponent();
        }
        public AddUserToGroup(User selectedUser)
        {
            InitializeComponent();
            this.selectedUser = selectedUser;
            selectedGroup = null;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picBoxAdd_Click(object sender, EventArgs e)
        {
            SendAddToGroupToServer();
            this.Close();
        }
        private void LoadGroupOption()
        {
            
        }
        private async void SendAddToGroupToServer()
        {
            byte[] tempBuff = Encoding.UTF8.GetBytes("GPENDING%" + selectedGroup.ID + "%" +
                                                                   selectedUser.Id);
            byte[] buff = new byte[1024];
            tempBuff.CopyTo(buff, 0);
            Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
        }
    }
}
