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
      
        private UserForm userForm; // Khung Chat của user
        private User user;
        private Panel panelUser; // 
        private Panel panelNameUser;
        private Label labelname;
        private Label labelMessage;
        private Guna2CirclePictureBox avatarUser;

        public UserUI() { }
        public UserUI(User user,  Panel listUser,  Panel panelRight)
        {
            this.user = user;

            InitButtonUser(user,listUser) ;
            InitUserForm(user);
            panelRight.Controls.Add(userForm);
        }

        private void InitUserForm(User user)
        {
            userForm = new UserForm(user);
            userForm.TopLevel = false;
            userForm.Dock = DockStyle.Fill;

        }

        private void InitButtonUser(User user, Panel listUser)
        {
            
            avatarUser = new Guna2CirclePictureBox();
            avatarUser.Image = Image.FromFile(@"..\..\images\123.jfif");
            avatarUser.Size = new Size(36,36);
            avatarUser.Dock = DockStyle.Left;
            avatarUser.SizeMode = PictureBoxSizeMode.Zoom;


            labelname = new Label();
            labelname.Text = user.Name;
            labelname.ForeColor = Color.Black;
            labelname.Font = new Font("Consoloas", 12);
            labelname.Dock = DockStyle.Top;
            labelname.Visible = true;

            labelMessage = new Label();
            labelMessage.Text = "tin nhan";
            labelMessage.Font = new Font("Consoloas", 7);
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Visible = true;

            panelNameUser = new Panel();
            panelNameUser.Controls.Add(labelMessage);
            panelNameUser.Controls.Add(labelname);
           
            panelNameUser.TabIndex = 0;
            panelNameUser.BackColor = Color.WhiteSmoke;
            panelNameUser.Padding = new Padding(10, 2, 0, 0);
            panelNameUser.Dock = DockStyle.Fill;


            panelUser = new Panel();
            panelUser.Padding = new Padding(12,7,7,7);
            panelUser.Visible = true;
            panelUser.BackColor = Color.WhiteSmoke;
            panelUser.Dock = DockStyle.Top;
            panelUser.Height = 50;

            
            panelUser.Controls.Add(panelNameUser);
            panelUser.Controls.Add(avatarUser);
            listUser.Controls.Add(panelUser);
            panelNameUser.Click += PanelNameUser_Click;
            panelUser.Click += PanelUser_Click;
            avatarUser.Click += AvatarUser_Click1;
            labelname.Click += Labelname_Click;
            labelMessage.Click += LabelMessage_Click;
        }

        private void LabelMessage_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
            if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
            else if (Form1.userUIForcus == null)
            {
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
        }

        private void ChangeColorWhenClick()
        {
            panelUser.BackColor = Color.Gainsboro;
            panelNameUser.BackColor = Color.Gainsboro;
        }
        private void ChangeColorWhenNonClick()
        {
            panelUser.BackColor = Color.WhiteSmoke;
            panelNameUser.BackColor = Color.WhiteSmoke;
        }
        private void Labelname_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
            if ( Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id )
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }else if (Form1.userUIForcus == null)
            {
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
        }
        private void PanelUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
            if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
            else if (Form1.userUIForcus == null)
            {
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
        }
        private void PanelNameUser_Click(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
            if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
            else if (Form1.userUIForcus == null)
            {
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
        }
        private void AvatarUser_Click1(object sender, EventArgs e)
        {
            userForm.Show();
            userForm.BringToFront();
            if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
            else if (Form1.userUIForcus == null)
            {
                this.ChangeColorWhenClick();
                Form1.userUIForcus = this;
            }
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
