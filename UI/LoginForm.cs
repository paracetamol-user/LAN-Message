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
using User = UserManager.User;

namespace UI
{
    public partial class LoginForm : Form
    {
        //Info Server
        private string ipServer = "192.168.1.3";
        private string portSever = "5000";

        static public SocketClient client;
        static public TcpClient server;

        public LoginForm()
        {
            InitializeComponent();
            InitClient();
            ConnecToServer();
        }
        private async void ConnecToServer()
        {
            server = await client.ConnectToServer();
        }
        public void InitClient()
        {
            client = new SocketClient();
            client.SetServerIPAddress(ipServer);
            client.SetServerPort(portSever);

        }
        public async void SendRequest(string account, string pass, string action)
        {
            UserManager.UserVerification userVerification= new UserManager.UserVerification();
            pass = userVerification.GetSHA256(pass);
            await client.SendToServer(action + "%" + account + "%" + pass);
            string[] data = (await (client.ReadDataAsync(server))).Split(' ');
            if (data[0].Trim('\0', '\r', '\n') == "LOGINOKE")
            {
                User user = new User(data[1].Trim('\0', '\r', '\n'), account, true);      
                Form1 mainform = new Form1(this, user , client , server);
                mainform.Show();
                this.Hide();
                label2.Visible = false;
            }
            else
            {
                label2.Text = "Tai khoan hoac mat khau khong chinh xac";
                label2.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text;
            string password = textBoxPassword.Text;
            string action = "LOGIN";
            SendRequest(account, password, action);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string account = textBoxAccount.Text;
                string password = textBoxPassword.Text;
                string action = "LOGIN";
                SendRequest(account, password, action);
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up tam = new Sign_up(this);
            tam.Show();
            this.Hide();
        }
    }
}
