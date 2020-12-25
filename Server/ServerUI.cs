using System;
using System.IO;
using System.Windows.Forms;
using Communication;
using Network;
using System.Configuration;
using System.Drawing;
using System.Data.SqlClient;

namespace Server
{
	public partial class ServerUI : Form
	{
	    private SocketServer mServer;
		public Panel pnMenuFocus;
		public ucData ucData { get; set; }
		public ServerUI()
		{
			InitializeComponent();
			mServer = new SocketServer(ConfigurationManager.AppSettings["Data Source"].ToString());
			mServer.RaiseClientConnectedEvent += HandleClientConnected;
			mServer.RaiseTextReceivedEvent += HandleTextReceived;
            ClearData();
			SetOff();
            ucData = new ucData(pnM__Contain , this);
            this.txtBoxConsole.BringToFront();
            this.txtBoxConsole.Show();
            this.txtBoxConsole.Dock = DockStyle.Fill;
            this.pictureBox2.BringToFront();
            this.pictureBox2.Show();

			this.txtBoxConsole.TextChanged += new EventHandler(textChange);
        }

        private void textChange(object sender, EventArgs e)
        {
			if (txtBoxConsole.TextLength > 10000) txtBoxConsole.Clear();
        }

        private void SetOff()
        {
			string query = "update users set status = 0";
			SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
			connection.Open();
			SqlCommand command = new SqlCommand(query, connection);
			command.ExecuteNonQuery();
			connection.Close();
		}

        private void ClearData()
		{
			string path = @"./filedata";
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			DirectoryInfo dir = new DirectoryInfo(path);
			foreach (var item in dir.GetFiles())
			{
				item.Delete();
			}
		}
		private void ServerUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			mServer.StopServer();
		}
		private void HandleClientConnected(object sender,  ClientConnectedEventArgs ccea)
		{
			txtBoxConsole.AppendText(string.Format("New client connected: {0}{1}", ccea.NewClient,
				Environment.NewLine));
		}
		private void HandleTextReceived(object sender, TextReceivedEventArgs trea)
		{
			txtBoxConsole.AppendText(string.Format("{0} - Received from {3}: {1}{2}",
					DateTime.Now, trea.TextReceived, Environment.NewLine, trea.ClientWhoSent));
		}
		private void btnInfomation_Click(object sender, EventArgs e)
		{
			this.ucData.AddData();
			this.ucData.Show();
			this.ucData.BringToFront();
		}
        private void btnConsole_Click(object sender, EventArgs e)
        {
			this.txtBoxConsole.BringToFront();
			this.txtBoxConsole.Show();
			this.pictureBox2.BringToFront();
			this.pictureBox2.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
			this.txtBoxConsole.Clear();
		}
        private void pnStartServer_Click(object sender, EventArgs e)
        {
			this.txtBoxConsole.AppendText(string.Format("Server started! {0}", Environment.NewLine));
			this.mServer.StartForIncommingConnection();
			this.pnStartServer.Enabled = false;
			this.lbStart.Enabled = false;
			this.pictureBoxStart.Enabled = false;
		}
        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
			DialogResult ds = MessageBox.Show("Are you sure clean data?", "Clean Data", MessageBoxButtons.YesNo);
			if (ds == DialogResult.Yes)
            {
				string path = @"./filedata";
				if (!Directory.Exists(path)) Directory.CreateDirectory(path);
				DirectoryInfo dir = new DirectoryInfo(path);
				foreach (var item in dir.GetFiles())
				{
					item.Delete();
				}
				string query = "delete from message";
				SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				command.ExecuteNonQuery();
				connection.Close();
			}
			
		}
        private void pnReset_Click(object sender, EventArgs e)
        {
			string[] arr = { "tinnhan", "contactmember", "contactbook" ,"member" , "groups" , "friend" , "users"};
			DialogResult ds = MessageBox.Show("Are you sure reset server? Delete all data in server !", "Reset Server", MessageBoxButtons.YesNo);
			if (ds == DialogResult.Yes)
			{
				string path = @"./filedata";
				if (!Directory.Exists(path)) Directory.CreateDirectory(path);
				DirectoryInfo dir = new DirectoryInfo(path);
				foreach (var item in dir.GetFiles())
				{
					item.Delete();
				}
				path = @"./avatar";
				if (!Directory.Exists(path)) Directory.CreateDirectory(path);
				dir = new DirectoryInfo(path);
				foreach (var item in dir.GetFiles())
				{
					item.Delete();
				}
				for (int i = 0; i < 7; i++)
                {
					string query = "delete from " + arr[i];
					SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					SqlCommand command = new SqlCommand(query, connection);
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
		}
        private void pnStop_Click(object sender, EventArgs e)
        {
			DialogResult ds = MessageBox.Show("Are you sure stop server!", "Reset Server", MessageBoxButtons.YesNo);
			if (ds == DialogResult.Yes)
			{
				txtBoxConsole.AppendText(string.Format("Server stopped! {0}", Environment.NewLine));
				mServer.StopServer();
				this.pnStartServer.Enabled = true;
				this.lbStart.Enabled = true;
				this.pictureBoxStart.Enabled = true;

			}
		}
		public async void RemoveUser(string ID)
        {
			mServer.NotificationRemoveUser(ID);
        }

    }
}
