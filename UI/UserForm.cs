using Communication;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
using User = UserManager.User;

namespace UI
{
    public partial class UserForm : Form
    {
        private User user;
        public UserForm(UserManager.User user)
        {
            InitializeComponent();
            this.Visible = false;
            this.user = user;
            InitUserForm();
            
        }
        public void SendMessage()
        {
            string data = "SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text;
            Form1.client.SendToServer(data);
            listViewCHAT.Items.Add(Form1.me.Name + ": " + TextBoxEnterChat.Text);
            TextBoxEnterChat.Text = "";
        }
        private void InitUserForm()
        {
            this.labelID.Text = "#"+user.Id;
            this.labelName.Text = user.Name;
            this.pictureBoxSend.Click += PictureBoxSend_Click;
        }

        private void PictureBoxSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        public UserForm()
        {
            InitializeComponent();
            this.Visible = false;
        }
        public void HideForm()
        {
            this.Visible = false;
        }
        public void ShowForm()
        {
            this.Visible = true;
        }
        public void AddItemInToListChat(string username , string str)
        {
            listViewCHAT.Items.Add(username + ": " + str);
        }
        public void AddFrom(Panel panelRight)
        {
            panelRight.Controls.Add(this);
        }

        private void TextBoxEnterChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessage();
            }
        }
    }
}
