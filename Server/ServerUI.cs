using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communication;
using Network;

namespace Server
{
    public partial class ServerUI : Form
    {
        SocketServer mServer;

        public ServerUI()
        {
            InitializeComponent();
            mServer = new SocketServer();
            mServer.RaiseClientConnectedEvent += HandleClientConnected;
            mServer.RaiseTextReceivedEvent += HandleTextReceived;
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mServer.StartForIncommingConnection();
        }

        private void btnSendToAll_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(txtBoxMessage.Text);
            txtBoxMessage.Text = string.Empty;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mServer.StopServer();
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
    }
}
