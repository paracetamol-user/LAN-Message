using Communication;
using Microsoft.VisualBasic.ApplicationServices;
using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = UserManager.User;
namespace UI
{
	public partial class FrmLogin : Form
	{
		//Info Server
		private string ipServer = ConfigurationManager.AppSettings["IP server"].ToString();
		private string portSever = "5000";
		static public SocketClient client;
		static public TcpClient server;
		public FrmLogin()
		{
			InitializeComponent();
			InitClient();
			ConnecToServer();
			//string path = @"./cache/avatar";
			//if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			//path = @"./voice";
			//if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			ClearData();
		}
		private void ClearData()
		{
			string path = @"./cache/avatar";
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			DirectoryInfo dir = new DirectoryInfo(path);
			foreach (var item in dir.GetFiles())
			{
				item.Delete();
			}
			path = @"./voice";
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			dir = new DirectoryInfo(path);
			foreach (var item in dir.GetDirectories())
			{
				item.Delete(true);
			}
		}
		private async void ConnecToServer()
		{
			server = await client.ConnectToServer();
			if (server != null) this.lnConnect.Text = "Connected";
			else this.lnConnect.Text = "No connection";
		}
		public void InitClient()
		{
			client = new SocketClient();
			client.SetServerIPAddress(ipServer);
			client.SetServerPort(portSever);
		}
		public async void SendRequest(string account, string pass, string action)
		{
			try
            {
				UserManager.UserVerification userVerification = new UserManager.UserVerification();
				pass = userVerification.GetSHA256(pass);
				byte[] tempBuff = Encoding.UTF8.GetBytes(action + "%" + account + "%" + pass);
				SmallPackage package = new SmallPackage(1024, 1024, "M", tempBuff, "0");
				byte[] buffMessage = package.Packing();
				await server.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

				byte[] buffReceive = new byte[1024];
				await server.GetStream().ReadAsync(buffReceive, 0, buffReceive.Length);
				SmallPackage packageReceive = new SmallPackage();
				packageReceive.DividePackage(buffReceive);

				string[] data = (Encoding.UTF8.GetString(packageReceive.Data).Trim('\0', '\t', '\n')).Split('%');
				if (data[0] == "LOGINOKE")
				{
					User user = new User(data[1], account, true, @"./images/avatarDefault/avatarDefault.png");
					FrmMain mainform = new FrmMain(this, user, client, server, data[2]);
					mainform.Show();
					this.Hide();
					label2.Visible = false;
				}
				else if (data[0] == "ERRORLOGINED")
				{
					MessageBox.Show("Account was logined in other computer", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					label2.Text = "Tai khoan hoac mat khau khong chinh xac";
					label2.Visible = true;
				}
			}
			catch ( Exception ex)
            {
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK , MessageBoxIcon.Warning);
				this.lnConnect.Text = "No connection";
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string account = textBoxAccount.Text;
			string password = textBoxPassword.Text;
			string action = "LOGIN";
			SendRequest(account, password, action);
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
			try
			{
				Sign_up tam = new Sign_up(this);
				tam.Show();
				this.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public void AcceptClose(bool accept)
		{
			if (accept == true) this.Close();
		}
		public void DisconectServer()
		{
			client.CloseAndDisconnect();
		}
		public void ReConnect()
		{
			server.Dispose();
			InitClient();
			ConnecToServer();
		}

        private void lnConnect_TextChanged(object sender, EventArgs e)
        {
			(sender as Label).Visible = true;
			if ((sender as Label).Text == "Connected")
            {
				(sender as Label).ForeColor = Color.Green;
				this.pictureBoxReload.Visible = false;
			}
			else
            {
				(sender as Label).ForeColor = Color.Black;
				this.pictureBoxReload.Visible = true;
			}
        }

        private void button3_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void pictureBoxReload_Click(object sender, EventArgs e)
        {
			try
			{
				server.Dispose();
			}
			catch (Exception ex)
            {

            }
			InitClient();
			ConnecToServer();
		}
    }
}
