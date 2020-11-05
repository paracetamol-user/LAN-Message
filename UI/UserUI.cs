using Communication;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
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
        private Panel panelUser;
        private UserForm userForm;
        private User user;
        private User tencuatao;
        private string idFocus;
        SocketClient client;
        TcpClient server;

        public UserUI() { }
        public UserUI(User tencuatao ,User user,  Panel listUser,  Panel panelRight, SocketClient client, TcpClient server)
        {
            this.user = user;
            this.client = client;
            this.server = server;
            this.tencuatao = tencuatao;
            //this.idFocus = idFocus;
            InitButtonUser(user,listUser) ;
            InitUserForm(tencuatao ,user , client , server);
            panelRight.Controls.Add(userForm);
        }

        private void InitUserForm(User tencuatao ,User user ,SocketClient client , TcpClient server)
        {
            userForm = new UserForm(tencuatao ,user , client , server);
            userForm.TopLevel = false;
            userForm.Dock = DockStyle.Fill;

        }

        private void InitButtonUser(User user, Panel listUser)
        {
            
            Guna2CirclePictureBox AvatarUser = new Guna2CirclePictureBox();
            AvatarUser.Image = Image.FromFile("./images/avatarDefault.png");
            AvatarUser.Size = new Size(36,36);
            AvatarUser.Dock = DockStyle.Left;
            AvatarUser.SizeMode = PictureBoxSizeMode.Zoom;
         

            Label nameUser = new Label();
            nameUser.Text = user.Name;
            nameUser.ForeColor = Color.Black;
            nameUser.Font = new Font("Consoloas", 12);
            nameUser.Dock = DockStyle.Left;
            nameUser.Visible = true;

            Panel panelNameUser = new Panel();
            panelNameUser.Controls.Add(nameUser);

            panelNameUser.TabIndex = 0;
            panelNameUser.BackColor = Color.WhiteSmoke;
            panelNameUser.Padding = new Padding(10, 9, 0, 9);
            panelNameUser.Dock = DockStyle.Fill;
            

            panelUser = new Panel();
            panelUser.Padding = new Padding(0, 7, 0, 7);
            panelUser.Visible = true;
            panelUser.BackColor = Color.WhiteSmoke;
            panelUser.Dock = DockStyle.Top;
            listUser.Controls.Add(panelUser);
            panelUser.Height = 50;
            panelUser.Controls.Add(panelNameUser);
            panelUser.Controls.Add(AvatarUser);

            panelNameUser.Click += PanelNameUser_Click;
            panelUser.Click += PanelUser_Click;
            AvatarUser.Click += AvatarUser_Click;
            nameUser.Click += NameUser_Click;
        }

        private void NameUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
        }

        private void AvatarUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
        }

        private void PanelUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
            
        }

        private void PanelNameUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
        }
        public string GetId()
        {
            return user.Id.ToString();
        }
        public async void AddMessage(string mess)
        {
            userForm.AddItemInToListChat(user.Name, mess);
        }
    }
}
