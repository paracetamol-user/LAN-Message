using Communication;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Guna2Button buttonUser;
        private UserForm userForm;
        private User user;
        private string myid;
        SocketClient client;
        TcpClient server;
        public UserUI()
        {

        }
        public UserUI(string myid ,string name, string id,  Panel listUser,  Panel panelRight , SocketClient client , TcpClient server)
        {
            this.user = new User(name, id);
            this.client = client;
            this.server = server;
            this.myid = myid;
            InitButtonUser(user) ;
            InitUserForm(myid ,user , client , server);

            listUser.Controls.Add(buttonUser);
            
            panelRight.Controls.Add(userForm);
        }

        private void InitUserForm(string myid ,User user ,SocketClient client , TcpClient server)
        {
            userForm = new UserForm(myid ,user , client , server);
            userForm.TopLevel = false;
            userForm.Dock = DockStyle.Fill;
        }

        private void InitButtonUser(User user)
        {
            buttonUser = new Guna2Button();
            buttonUser.Visible = true;
            buttonUser.ImageAlign = HorizontalAlignment.Left;
            buttonUser.Text = user.Name;
            buttonUser.Font = new Font("Consoloas", 12);
            buttonUser.ForeColor = Color.Black;
            buttonUser.Dock = DockStyle.Top;
            buttonUser.BringToFront();
            buttonUser.ImageSize = new Size(30, 30);
            buttonUser.Image = Image.FromFile("./images/avatarDefault.png");
            buttonUser.Click += ButtonUser_Click;
            buttonUser.FillColor = Color.WhiteSmoke;
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
        }
    }
}
