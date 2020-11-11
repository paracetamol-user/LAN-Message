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

        private Panel panelUserLeft;
        private Panel panelNameUser;
        private Label labelname;
        private Label labelMessage;
        private Guna2CirclePictureBox avatarUserLeft;

        private Panel panelUserRight;
        private Label labelNameRight;
        private Label labelIdRight;
        private Label labelStatusRight;
        private Panel panelInfoRight;
        private Panel panelOptionRight;
        private PictureBox menu;
        private Guna2CirclePictureBox avatarUserRight;
     
        public UserUI() { }
        public UserUI(User user,  Panel listUser,  Panel panelRight)
        {
            this.user = user;
            InitButtonUser(user,listUser) ;
            InitUserForm(user);
            InitPanelUserRight();
            panelRight.Controls.Add(userForm);
        }
        public Panel getPanelUserRight()
        {
            return this.panelUserLeft;
        }
        public void AddInfoUserIntoPanel()
        {
            AddFriendForm.panelListUserRight.Controls.Add(panelUserRight);
            //Button but = new Button();
            //but.Dock = DockStyle.Bottom;
            //AddFriendForm.panelListUserRight.Controls.Add(but);
        }
        private void InitPanelUserRight()
        {
            panelUserRight = new Panel();
            panelUserRight.Dock = DockStyle.Top;
            panelUserRight.Visible = true;
            panelUserRight.BackColor = Color.White;
            panelUserRight.Height = 60;
            panelUserRight.Padding = new Padding(0, 0, 0, 0);
            //panelUserRight.BorderStyle = BorderStyle.FixedSingle;

            Panel panelAllRight = new Panel();
            panelAllRight.Dock = DockStyle.Left;
            panelAllRight.Padding = new Padding(20, 5, 0, 5);
            panelInfoRight = new Panel();
            panelInfoRight.Dock = DockStyle.Fill;
            panelInfoRight.Padding = new Padding(10, 10, 10, 0);
            labelNameRight = new Label();
            labelIdRight = new Label();
            labelStatusRight = new Label();
            labelNameRight.Text = user.Name;
            labelIdRight.Text = user.Id;
            if (user.Status == false) labelStatusRight.Text = "Offline";
            else labelStatusRight.Text = "Online";
            labelNameRight.ForeColor = Color.Black;
            labelStatusRight.ForeColor = Color.DimGray;
            labelNameRight.Dock = DockStyle.Top;
            labelStatusRight.Dock = DockStyle.Fill;
            labelNameRight.Font = new Font("Century", 11);
            labelStatusRight.Font = new Font("Century", 9);
            panelInfoRight.Controls.Add(labelStatusRight);
            panelInfoRight.Controls.Add(labelNameRight);

            avatarUserRight = new Guna2CirclePictureBox();
            avatarUserRight.Image = Image.FromFile(@"..\..\images\123.jfif");
            avatarUserRight.Size = new Size(50, 50);
            avatarUserRight.Dock = DockStyle.Left;
            avatarUserRight.SizeMode = PictureBoxSizeMode.Zoom;
            
           
            panelAllRight.Controls.Add(panelInfoRight);
            panelAllRight.Controls.Add(avatarUserRight);
           

            panelAllRight.Width = 200;
           
            panelOptionRight = new Panel();
            panelOptionRight.Dock = DockStyle.Fill;
            panelOptionRight.Padding = new Padding(0, 3, 30, 3);
            menu = new PictureBox();
            menu.Dock = DockStyle.Right;
            menu.Width = 20;
            menu.Image = Image.FromFile(@"..\..\images\menu.png");
            menu.SizeMode = PictureBoxSizeMode.Zoom;

            panelOptionRight.Controls.Add(menu);
            
            Panel x = new Panel();
            x.Dock = DockStyle.Top;
            x.BorderStyle = BorderStyle.FixedSingle;
            x.Height = 1;

            Panel temp = new Panel();
            temp.Dock = DockStyle.Fill;
            temp.Controls.Add(panelOptionRight);
            temp.Controls.Add(panelAllRight);
       
            panelUserRight.Controls.Add(temp);
            panelUserRight.Controls.Add(x);

            panelInfoRight.Click += PanelInfoRight_Click;
            labelNameRight.Click += LabelNameRight_Click;
            labelStatusRight.Click += LabelStatusRight_Click;
            avatarUserRight.Click += AvatarUserRight_Click;
            panelOptionRight.Click += PanelOptionRight_Click;
            panelAllRight.Click += PanelAllRight_Click;

            panelInfoRight.MouseMove += PanelInfoRight_MouseMove;
            panelOptionRight.MouseMove += PanelOptionRight_MouseMove;
            labelNameRight.MouseMove += LabelNameRight_MouseMove;
            labelStatusRight.MouseMove += LabelStatusRight_MouseMove;
            avatarUserRight.MouseMove += AvatarUserRight_MouseMove;
            menu.MouseMove += Menu_MouseMove;
            panelAllRight.MouseMove += PanelAllRight_MouseMove;

            panelOptionRight.MouseLeave += PanelOptionRight_MouseLeave;
            panelInfoRight.MouseLeave += PanelInfoRight_MouseLeave;
            labelNameRight.MouseLeave += LabelNameRight_MouseLeave;
            labelStatusRight.MouseLeave += LabelStatusRight_MouseLeave;
            avatarUserRight.MouseLeave += AvatarUserRight_MouseLeave;
            menu.MouseLeave += Menu_MouseLeave;
            panelAllRight.MouseLeave += PanelAllRight_MouseLeave;
        }

        private void AvatarUserRight_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        } 

        private void PanelAllRight_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }

        private void PanelAllRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void PanelAllRight_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }

       

        private void LabelStatusRight_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }

        private void LabelNameRight_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }

        private void PanelInfoRight_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }

        private void PanelOptionRight_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void AvatarUserRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void LabelStatusRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void LabelNameRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void PanelOptionRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void PanelInfoRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }

        private void PanelOptionRight_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
        }

        public void ChangeColorWhenClickRight()
        {
            panelInfoRight.BackColor = Color.FromArgb(242, 243, 245);
            panelOptionRight.BackColor = Color.FromArgb(242, 243, 245);
            avatarUserRight.BackColor = Color.FromArgb(242, 243, 245);
            panelUserRight.BackColor = Color.FromArgb(242, 243, 245);
            
        }
        public void ChangeColorWhenNonClickRight()
        {
            panelInfoRight.BackColor = Color.White;
            panelOptionRight.BackColor = Color.White;
            avatarUserRight.BackColor = Color.White;
            panelUserRight.BackColor = Color.White;
        }
        private void AvatarUserRight_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
            
        }

        private void LabelStatusRight_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
            
        }

        private void LabelNameRight_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
            
        }

        private void PanelInfoRight_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
            
        }

        private void InitUserForm(User user)
        {
            userForm = new UserForm(user);
            userForm.TopLevel = false;
            userForm.Dock = DockStyle.Fill;

        }
        private void InitButtonUser(User user, Panel listUser)
        {
            avatarUserLeft = new Guna2CirclePictureBox();
            avatarUserLeft.Image = Image.FromFile(@"..\..\images\123.jfif");
            avatarUserLeft.Size = new Size(56,56);
            avatarUserLeft.Dock = DockStyle.Left;
            avatarUserLeft.SizeMode = PictureBoxSizeMode.Zoom;


            labelname = new Label();
            labelname.Text = user.Name;
            labelname.ForeColor = Color.Black;
            labelname.Font = new Font("Century", 14);
            labelname.Dock = DockStyle.Top;
            labelname.Visible = true;

            labelMessage = new Label();
            labelMessage.Text = "Offline";
            labelMessage.ForeColor = Color.Black;
            labelMessage.Font = new Font("Century", 8);
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Visible = true;

            panelNameUser = new Panel();
            panelNameUser.Controls.Add(labelMessage);
            panelNameUser.Controls.Add(labelname);
           
            panelNameUser.TabIndex = 0;
            panelNameUser.BackColor = Color.FromArgb(242, 243, 245);
            panelNameUser.Padding = new Padding(10, 2, 0, 0);
            panelNameUser.Dock = DockStyle.Fill;

            panelUserLeft = new Panel();
            panelUserLeft.Padding = new Padding(12,7,7,7);
            panelUserLeft.Visible = true;
            panelUserLeft.BackColor = Color.FromArgb(242, 243, 245);
            panelUserLeft.Dock = DockStyle.Top;
            panelUserLeft.Height = 70;

            panelUserLeft.Controls.Add(panelNameUser);
            panelUserLeft.Controls.Add(avatarUserLeft);
            listUser.Controls.Add(panelUserLeft);
            panelNameUser.Click += PanelNameUser_Click;
            panelUserLeft.Click += PanelUser_Click;
            avatarUserLeft.Click += AvatarUserLeft_Click;
            labelname.Click += Labelname_Click;
            labelMessage.Click += LabelMessage_Click;

            panelNameUser.MouseMove += PanelNameUser_MouseMove;
            panelUserLeft.MouseMove += PanelUserLeft_MouseMove;
            avatarUserLeft.MouseMove += AvatarUserLeft_MouseMove;
            labelname.MouseMove += Labelname_MouseMove;
            labelMessage.MouseMove += LabelMessage_MouseMove;

            panelNameUser.MouseLeave += PanelNameUser_MouseLeave;
            panelUserLeft.MouseLeave += PanelUserLeft_MouseLeave;
            avatarUserLeft.MouseLeave += AvatarUserLeft_MouseLeave;
            labelname.MouseLeave += Labelname_MouseLeave;
            labelMessage.MouseLeave += LabelMessage_MouseLeave;
        }
        private void LabelMessage_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorWhenNonClick();
        }
        private void Labelname_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorWhenNonClick();
        }
        private void AvatarUserLeft_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorWhenNonClick();
        }
        private void PanelUserLeft_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorWhenNonClick();
        }

        private void PanelNameUser_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorWhenNonClick();
        }

        private void LabelMessage_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColorWhenClick();
        }

        private void Labelname_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColorWhenClick();
        }

        private void AvatarUserLeft_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColorWhenClick();
        }

        private void PanelUserLeft_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColorWhenClick();
        }

        private void PanelNameUser_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColorWhenClick();
        }

        private void AvatarUserLeft_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
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

        private void LabelMessage_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus!=null ) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
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

        public void ChangeColorWhenClick()
        {
            panelUserLeft.BackColor = Color.White;
            panelNameUser.BackColor = Color.White;
            //235, 237, 239
        }
        public void ChangeColorWhenNonClick()
        {
            panelUserLeft.BackColor = Color.FromArgb(242, 243, 245);
            panelNameUser.BackColor = Color.FromArgb(242, 243, 245);

        }
        private void Labelname_Click(object sender, EventArgs e)
        {
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
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
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
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
            if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
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
        public bool GetStatus()
        {
            return user.Status;
        }
        public void SetStatus(bool status)
        {
            this.user.Status = status;
        }
    }
}
