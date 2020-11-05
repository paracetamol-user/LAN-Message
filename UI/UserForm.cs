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
        SocketClient client;
        TcpClient server;
        private string myid;
        public UserForm(string myid ,UserManager.User user , SocketClient client , TcpClient  server)
        {
            InitializeComponent();
            this.Visible = false;
            this.user = user;
            this.client = client;
            this.server = server;
            this.myid = myid;
            InitUserForm();
            
        }

        private void InitUserForm()
        {
            this.labelID.Text = "#"+user.Id;
            this.labelName.Text = user.Name;
            this.pictureBoxSend.Click += PictureBoxSend_Click;
        }

        private async void PictureBoxSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.Name.ToString());
            await client.SendToServer("SEND " + this.myid +" " +user.Id + this.TextBoxEnterChat.Text);
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
    }
}
