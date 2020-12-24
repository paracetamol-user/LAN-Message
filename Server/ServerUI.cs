using System;
using System.IO;
using System.Windows.Forms;
using Communication;
using Network;
using System.Configuration;
namespace Server
{
	public partial class ServerUI : Form
	{
		private SocketServer mServer { get; set; }
		public ucData ucData { get; set; }
		public ServerUI()
		{
			InitializeComponent();
			mServer = new SocketServer(ConfigurationManager.AppSettings["Database Source"].ToString());
			mServer.RaiseClientConnectedEvent += HandleClientConnected;
			mServer.RaiseTextReceivedEvent += HandleTextReceived;
			ClearData();
			ucData = new ucData(pnM__Contain);
			this.txtBoxConsole.BringToFront();
			this.txtBoxConsole.Show();
			this.txtBoxConsole.Dock = DockStyle.Fill;
			this.pictureBox2.BringToFront();
			this.pictureBox2.Show();
		}
		private void ClearData()
		{
			string path = @"..\..\filedata";
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

        private void btnStart_Click(object sender, EventArgs e)
        {
			txtBoxConsole.AppendText(string.Format("Server started! {0}", Environment.NewLine));
			mServer.StartForIncommingConnection();
			this.btnStart.Enabled = false;
		}

        private void btnStop_Click(object sender, EventArgs e)
        {
			txtBoxConsole.AppendText(string.Format("Servre stopped! {0}", Environment.NewLine));
			mServer.StopServer();
			this.btnStart.Enabled = true;
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
    }
}
