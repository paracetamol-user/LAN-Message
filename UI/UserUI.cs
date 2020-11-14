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
        private bool clickcheck;
        private Panel panelUserLeft;
        private Panel labelNameUserLeft;
        private Label labelNameLeft;
        private Label labelStatusLeft;
        private Guna2CirclePictureBox avatarUserLeft;

        private Panel panelUserAll;
        private Label labelNameLeftAll;
        private Label labelIdAll;
        private Label labelStatusAll;
        private Panel panelInfoAll;
        private Panel panelOptionAll;
        private PictureBox menuAll;
        private Guna2CirclePictureBox avatarUserAll;

        private Panel panelUserOnline;
        private Label labelNameLeftOnline;
        private Label labelIdOnline;
        private Label labelStatusOnline;
        private Panel panelInfoOnline;
        private Panel panelOptionOnline;
        private PictureBox menuOnline;
        private Guna2CirclePictureBox avatarUserOnline;

        public Panel panelINTERACTED;
        public Panel panelRIGHT;
        public UserUI() { }
        public UserUI(User user,  Panel PANELINTERACTED,  Panel PANELRIGHT)
        {
            this.user = user;
            this.panelINTERACTED = PANELINTERACTED;
            this.panelRIGHT = PANELRIGHT;
            InitPanelUserLeft();
            InitUserForm();
            
            InitPanelUserOnline();
            InitpanelUserAll();
            this.panelRIGHT.Controls.Add(userForm);
            //this.panelINTERACTED.Controls.Add(panelUserLeft);
        }
        public void ChangeStatusOnline()
        {
            labelStatusAll.Text = "Online";
            labelStatusLeft.Text = "Online";
            labelStatusOnline.Text = "Online";
        }
        public void ChangeStatusOffline()
        {
            labelStatusAll.Text = "Offline";
            labelStatusLeft.Text = "Offline";
            labelStatusOnline.Text = "Offline";
        }
        private void InitpanelUserAll()
        {
            panelUserAll = new Panel();
            panelUserAll.Dock = DockStyle.Top;
            panelUserAll.Visible = true;
            panelUserAll.BackColor = Color.White;
            panelUserAll.Height = 60;
            panelUserAll.Padding = new Padding(0, 0, 0, 0);
            //panelUserAll.BorderStyle = BorderStyle.FixedSingle;

            Panel panelAllRight = new Panel();
            panelAllRight.Dock = DockStyle.Left;
            panelAllRight.Padding = new Padding(20, 5, 0, 5);
            panelInfoAll = new Panel();
            panelInfoAll.Dock = DockStyle.Fill;
            panelInfoAll.Padding = new Padding(10, 2, 10, 0);
            labelNameLeftAll = new Label();
            labelIdAll = new Label();
            labelStatusAll = new Label();
            labelNameLeftAll.Text = user.Name;
            labelIdAll.Text = user.Id;
            if (user.Status == false) labelStatusAll.Text = "Offline";
            else labelStatusAll.Text = "Online";
            labelNameLeftAll.ForeColor = Color.Black;
            labelStatusAll.ForeColor = Color.DimGray;
            labelNameLeftAll.Dock = DockStyle.Top;
            labelStatusAll.Dock = DockStyle.Fill;
            labelNameLeftAll.Font = new Font("Century", 11);
            labelStatusAll.Font = new Font("Century", 9);
            panelInfoAll.Controls.Add(labelStatusAll);
            panelInfoAll.Controls.Add(labelNameLeftAll);

            avatarUserAll = new Guna2CirclePictureBox();
            avatarUserAll.Image = Image.FromFile(@"..\..\images\123.jfif");
            avatarUserAll.Size = new Size(50, 50);
            avatarUserAll.Dock = DockStyle.Left;
            avatarUserAll.SizeMode = PictureBoxSizeMode.Zoom;


            panelAllRight.Controls.Add(panelInfoAll);
            panelAllRight.Controls.Add(avatarUserAll);


            panelAllRight.Width = 200;

            panelOptionAll = new Panel();
            panelOptionAll.Dock = DockStyle.Fill;
            panelOptionAll.Padding = new Padding(0, 3, 30, 3);
            menuAll = new PictureBox();
            menuAll.Dock = DockStyle.Right;
            menuAll.Width = 20;
            menuAll.Image = Image.FromFile(@"..\..\images\menu.png");
            menuAll.SizeMode = PictureBoxSizeMode.Zoom;

            panelOptionAll.Controls.Add(menuAll);

            Panel x = new Panel();
            x.Dock = DockStyle.Top;
            x.BorderStyle = BorderStyle.FixedSingle;
            x.Height = 1;

            Panel temp = new Panel();
            temp.Dock = DockStyle.Fill;
            temp.Controls.Add(panelOptionAll);
            temp.Controls.Add(panelAllRight);

            panelUserAll.Controls.Add(temp);
            panelUserAll.Controls.Add(x);

            panelInfoAll.Click += panelInfoAll_Click;
            labelNameLeftAll.Click += labelNameLeftAll_Click;
            labelStatusAll.Click += labelStatusAll_Click;
            avatarUserAll.Click += avatarUserAll_Click;
            panelOptionAll.Click += panelOptionAll_Click;
            panelAllRight.Click += PanelAllRight_Click;

            panelInfoAll.MouseMove += panelInfoAll_MouseMove;
            panelOptionAll.MouseMove += panelOptionAll_MouseMove;
            labelNameLeftAll.MouseMove += labelNameLeftAll_MouseMove;
            labelStatusAll.MouseMove += labelStatusAll_MouseMove;
            avatarUserAll.MouseMove += avatarUserAll_MouseMove;
            menuAll.MouseMove += menuAll_MouseMove;
            panelAllRight.MouseMove += PanelAllRight_MouseMove;

            panelOptionAll.MouseLeave += panelOptionAll_MouseLeave;
            panelInfoAll.MouseLeave += panelInfoAll_MouseLeave;
            labelNameLeftAll.MouseLeave += labelNameLeftAll_MouseLeave;
            labelStatusAll.MouseLeave += labelStatusAll_MouseLeave;
            avatarUserAll.MouseLeave += avatarUserAll_MouseLeave;
            menuAll.MouseLeave += menuAll_MouseLeave;
            panelAllRight.MouseLeave += PanelAllRight_MouseLeave;
        }
        private void InitUserForm()
        {
            userForm = new UserForm(user);
            userForm.TopLevel = false;
            userForm.Dock = DockStyle.Fill;

        }
        private void InitPanelUserLeft()
        {
            avatarUserLeft = new Guna2CirclePictureBox();
            avatarUserLeft.Image = Image.FromFile(@"..\..\images\123.jfif");
            avatarUserLeft.Size = new Size(56, 56);
            avatarUserLeft.Dock = DockStyle.Left;
            avatarUserLeft.SizeMode = PictureBoxSizeMode.Zoom;

            labelNameLeft = new Label();
            labelNameLeft.Text = user.Name;
            labelNameLeft.ForeColor = Color.Black;
            labelNameLeft.Font = new Font("Century", 14);
            labelNameLeft.Dock = DockStyle.Top;
            labelNameLeft.Visible = true;

            labelStatusLeft = new Label();
            if (user.Status == false) labelStatusLeft.Text = "Offline";
            else labelStatusLeft.Text = "Online";
            labelStatusLeft.ForeColor = Color.Black;
            labelStatusLeft.Font = new Font("Century", 8);
            labelStatusLeft.Dock = DockStyle.Fill;
            labelStatusLeft.Visible = true;

            labelNameUserLeft = new Panel();
            labelNameUserLeft.Controls.Add(labelStatusLeft);
            labelNameUserLeft.Controls.Add(labelNameLeft);

            labelNameUserLeft.TabIndex = 0;
            labelNameUserLeft.BackColor = Color.FromArgb(242, 243, 245);
            labelNameUserLeft.Padding = new Padding(10, 2, 0, 0);
            labelNameUserLeft.Dock = DockStyle.Fill;

            panelUserLeft = new Panel();
            panelUserLeft.Padding = new Padding(12, 7, 7, 7);
            panelUserLeft.Visible = true;
            panelUserLeft.BackColor = Color.FromArgb(242, 243, 245);
            panelUserLeft.Dock = DockStyle.Top;
            panelUserLeft.Height = 70;

            panelUserLeft.Controls.Add(labelNameUserLeft);
            panelUserLeft.Controls.Add(avatarUserLeft);

            labelNameUserLeft.Click += labelNameUserLeft_Click;
            panelUserLeft.Click += PanelUser_Click;
            avatarUserLeft.Click += AvatarUserLeft_Click;
            labelNameLeft.Click += labelNameLeft_Click;
            labelStatusLeft.Click += labelStatusLeft_Click;

            labelNameUserLeft.MouseMove += labelNameUserLeft_MouseMove;
            panelUserLeft.MouseMove += PanelUserLeft_MouseMove;
            avatarUserLeft.MouseMove += AvatarUserLeft_MouseMove;
            labelNameLeft.MouseMove += labelNameLeft_MouseMove;
            labelStatusLeft.MouseMove += labelStatusLeft_MouseMove;

            labelNameUserLeft.MouseLeave += labelNameUserLeft_MouseLeave;
            panelUserLeft.MouseLeave += PanelUserLeft_MouseLeave;
            avatarUserLeft.MouseLeave += AvatarUserLeft_MouseLeave;
            labelNameLeft.MouseLeave += labelNameLeft_MouseLeave;
            labelStatusLeft.MouseLeave += labelStatusLeft_MouseLeave;

            panelUserLeft.Visible = false;
        }
        private void InitPanelUserOnline()
        {
            panelUserOnline = new Panel();
            panelUserOnline.Dock = DockStyle.Top;
            panelUserOnline.Visible = true;
            panelUserOnline.BackColor = Color.White;
            panelUserOnline.Height = 60;
            panelUserOnline.Padding = new Padding(0, 0, 0, 0);
            //panelUserAll.BorderStyle = BorderStyle.FixedSingle;

            Panel panelAllRight = new Panel();
            panelAllRight.Dock = DockStyle.Left;
            panelAllRight.Padding = new Padding(20, 5, 0, 5);
            panelInfoOnline = new Panel();
            panelInfoOnline.Dock = DockStyle.Fill;
            panelInfoOnline.Padding = new Padding(10, 2, 10, 0);
            labelNameLeftOnline = new Label();
            labelIdOnline = new Label();
            labelStatusOnline = new Label();
            labelNameLeftOnline.Text = user.Name;
            labelIdOnline.Text = user.Id;
            if (user.Status == false) labelStatusOnline.Text = "Offline";
            else labelStatusOnline.Text = "Online";
            labelNameLeftOnline.ForeColor = Color.Black;
            labelStatusOnline.ForeColor = Color.DimGray;
            labelNameLeftOnline.Dock = DockStyle.Top;
            labelStatusOnline.Dock = DockStyle.Fill;
            labelNameLeftOnline.Font = new Font("Century", 11);
            labelStatusOnline.Font = new Font("Century", 9);
            panelInfoOnline.Controls.Add(labelStatusOnline);
            panelInfoOnline.Controls.Add(labelNameLeftOnline);

            avatarUserOnline = new Guna2CirclePictureBox();
            avatarUserOnline.Image = Image.FromFile(@"..\..\images\123.jfif");
            avatarUserOnline.Size = new Size(50, 50);
            avatarUserOnline.Dock = DockStyle.Left;
            avatarUserOnline.SizeMode = PictureBoxSizeMode.Zoom;

            panelAllRight.Controls.Add(panelInfoOnline);
            panelAllRight.Controls.Add(avatarUserOnline);
            panelAllRight.Width = 200;

            panelOptionOnline = new Panel();
            panelOptionOnline.Dock = DockStyle.Fill;
            panelOptionOnline.Padding = new Padding(0, 3, 30, 3);
            menuOnline = new PictureBox();
            menuOnline.Dock = DockStyle.Right;
            menuOnline.Width = 20;
            menuOnline.Image = Image.FromFile(@"..\..\images\menu.png");
            menuOnline.SizeMode = PictureBoxSizeMode.Zoom;

            panelOptionOnline.Controls.Add(menuOnline);

            Panel x = new Panel();
            x.Dock = DockStyle.Top;
            x.BorderStyle = BorderStyle.FixedSingle;
            x.Height = 1;

            Panel temp = new Panel();
            temp.Dock = DockStyle.Fill;
            temp.Controls.Add(panelOptionOnline);
            temp.Controls.Add(panelAllRight);

            panelUserOnline.Controls.Add(temp);
            panelUserOnline.Controls.Add(x);

            panelInfoOnline.Click += PanelInfoOnline_Click;
            labelNameLeftOnline.Click += LabelNameLeftOnline_Click;
            labelStatusOnline.Click += LabelStatusOnline_Click;
            avatarUserOnline.Click += AvatarUserOnline_Click;
            panelOptionOnline.Click += PanelOptionOnline_Click;
            panelAllRight.Click += PanelAllRight_Click1;

            panelInfoOnline.MouseMove += PanelInfoOnline_MouseMove;
            panelOptionOnline.MouseMove += PanelOptionOnline_MouseMove;
            labelNameLeftOnline.MouseMove += LabelNameLeftOnline_MouseMove;
            labelStatusOnline.MouseMove += LabelStatusOnline_MouseMove;
            avatarUserOnline.MouseMove += AvatarUserOnline_MouseMove;
            menuOnline.MouseMove += MenuOnline_MouseMove;
            panelAllRight.MouseMove += PanelAllRight_MouseMove2;

            panelOptionOnline.MouseLeave += PanelOptionOnline_MouseLeave;
            panelInfoOnline.MouseLeave += PanelInfoOnline_MouseLeave;
            labelNameLeftOnline.MouseLeave += LabelNameLeftOnline_MouseLeave;
            labelStatusOnline.MouseLeave += LabelStatusOnline_MouseLeave;
            avatarUserOnline.MouseLeave += AvatarUserOnline_MouseLeave;
            menuOnline.MouseLeave += MenuOnline_MouseLeave;
            panelAllRight.MouseLeave += PanelAllRight_MouseLeave1;
        }

        
        /// <summary>
        /// Khỏi tạo giao diện các Panel Control.
        /// </summary>
        public Panel getpanelUserAll()
        {
            return this.panelUserLeft;
        }
        public void AddInfoUserIntoPanelAllUser()
        {
            ServerForm.panelAllUser.Controls.Add(panelUserAll);
        }
        public void AddInfoUserIntoPanelOnlineUser()
        {
            ServerForm.panelOnlineUser.Controls.Add(panelUserOnline);
        }
        public void ShowChatForm()
        {
            // if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
            userForm.Show();
            userForm.BringToFront();
            Form1.userFormFocus = this.userForm;
        }
        public void ChangeColorWhenClick()
        {
            panelUserLeft.BackColor = Color.White;
            labelNameUserLeft.BackColor = Color.White;
            
            //235, 237, 239
        }
        public void ChangeColorWhenNonClick()
        {
            panelUserLeft.BackColor = Color.FromArgb(242, 243, 245);
            labelNameUserLeft.BackColor = Color.FromArgb(242, 243, 245);
        }
        public void ChangeColorWhenClickRight()
        {
            panelInfoAll.BackColor = Color.FromArgb(242, 243, 245);
            panelOptionAll.BackColor = Color.FromArgb(242, 243, 245);
            avatarUserAll.BackColor = Color.FromArgb(242, 243, 245);
            panelUserAll.BackColor = Color.FromArgb(242, 243, 245);

        }
        public void ChangeColorWhenNonClickRight()
        {
            panelInfoAll.BackColor = Color.White;
            panelOptionAll.BackColor = Color.White;
            avatarUserAll.BackColor = Color.White;
            panelUserAll.BackColor = Color.White;
        }
        public void ChangeColorWhenNonClickOnline()
        {
            panelInfoOnline.BackColor = Color.White;
            panelOptionOnline.BackColor = Color.White;
            avatarUserOnline.BackColor = Color.White;
            panelUserOnline.BackColor = Color.White;
        }
        public void ChangeColorWhenClickOnline()
        {
            panelInfoOnline.BackColor = Color.FromArgb(242, 243, 245);
            panelOptionOnline.BackColor = Color.FromArgb(242, 243, 245);
            avatarUserOnline.BackColor = Color.FromArgb(242, 243, 245);
            panelUserOnline.BackColor = Color.FromArgb(242, 243, 245);
        }
        public void AddUserInteracted()
        {
            if (panelUserLeft.Visible == false)
            {
                panelUserLeft.Visible = true;
                panelUserLeft.Dock = DockStyle.Top;
                this.panelINTERACTED.Controls.Add(panelUserLeft);
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
        /// <summary>
        /// Các hàm tính năng
        /// </summary>
        private void PanelAllRight_MouseLeave1(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void MenuOnline_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void AvatarUserOnline_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void LabelStatusOnline_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void LabelNameLeftOnline_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void PanelInfoOnline_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void PanelOptionOnline_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickOnline();
        }

        private void PanelAllRight_MouseMove2(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void MenuOnline_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void AvatarUserOnline_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void LabelStatusOnline_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void LabelNameLeftOnline_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void PanelOptionOnline_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void PanelInfoOnline_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickOnline();
        }

        private void PanelAllRight_Click1(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClickOnline();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }

        private void PanelOptionOnline_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClickOnline();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }

        private void AvatarUserOnline_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClickOnline();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }

        private void LabelStatusOnline_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClickOnline();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }

        private void LabelNameLeftOnline_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClickOnline();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }

        private void PanelInfoOnline_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClickOnline();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }

        private void avatarUserAll_MouseLeave(object sender, EventArgs e)
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
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }
        private void menuAll_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }
        private void labelStatusAll_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }
        private void labelNameLeftAll_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }
        private void panelInfoAll_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }
        private void panelOptionAll_MouseLeave(object sender, EventArgs e)
        {
            this.ChangeColorWhenNonClickRight();
        }
        private void menuAll_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }
        private void avatarUserAll_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }
        private void labelStatusAll_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }
        private void labelNameLeftAll_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }
        private void panelOptionAll_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }
        private void panelInfoAll_MouseMove(object sender, MouseEventArgs e)
        {
            this.ChangeColorWhenClickRight();
        }
        private void panelOptionAll_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }
        private void avatarUserAll_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }
        private void labelStatusAll_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }
        private void labelNameLeftAll_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }
        private void panelInfoAll_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            AddUserInteracted();
            if (Form1.userUIForcus != null)
            {
                Form1.userUIForcus.ChangeColorWhenNonClick();
            }
            ChangeColorWhenClick();
            Form1.userUIForcus = this;
        }
        private void labelStatusLeft_MouseLeave(object sender, EventArgs e)
        {
            if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id) || Form1.userUIForcus == null)
                ChangeColorWhenNonClick();
        }
        private void labelNameLeft_MouseLeave(object sender, EventArgs e)
        {
            if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id) || Form1.userUIForcus == null)
                ChangeColorWhenNonClick();
        }
        private void AvatarUserLeft_MouseLeave(object sender, EventArgs e)
        {
            if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id) || Form1.userUIForcus == null)
                ChangeColorWhenNonClick();
        }
        private void PanelUserLeft_MouseLeave(object sender, EventArgs e)
        {
            if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id) || Form1.userUIForcus == null)
                ChangeColorWhenNonClick();
        }
        private void labelNameUserLeft_MouseLeave(object sender, EventArgs e)
        {
            if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id) || Form1.userUIForcus == null)
                ChangeColorWhenNonClick();
        }
        private void labelStatusLeft_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeColorWhenClick();
        }
        private void labelNameLeft_MouseMove(object sender, MouseEventArgs e)
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
        private void labelNameUserLeft_MouseMove(object sender, MouseEventArgs e)
        {
            
            ChangeColorWhenClick();

        }
        private void AvatarUserLeft_Click(object sender, EventArgs e)
        {
            ShowChatForm();
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
        private void labelStatusLeft_Click(object sender, EventArgs e)
        {
            ShowChatForm();
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
        private void labelNameLeft_Click(object sender, EventArgs e)
        {
            ShowChatForm();
            if ( Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.user.Id )
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
        private void PanelUser_Click(object sender, EventArgs e)
        {
            ShowChatForm();
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
        private void labelNameUserLeft_Click(object sender, EventArgs e)
        {
            ShowChatForm();
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
    }
}
