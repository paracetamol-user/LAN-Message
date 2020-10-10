using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public class ClientConnectedEventArgs : EventArgs
    {
        public string NewClient { get; set; }

        public ClientConnectedEventArgs(string newClient)
        {
            this.NewClient = newClient;
        }
    }

    public class TextReceivedEventArgs : EventArgs
    {
        public string ClientWhoSent { get; set; }
        public string TextReceived { get; set; }
        public TextReceivedEventArgs(string clientWhoSent, string textReceived)
        {
            this.ClientWhoSent = clientWhoSent;
            this.TextReceived = textReceived;
        }
    }
}
