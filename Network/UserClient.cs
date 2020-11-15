using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
        public partial class UserClient
    {
        private TcpClient client;
        private string id;
        public UserClient() { }
        public UserClient(TcpClient CLIENT)
        {
            this.client = CLIENT;
            this.id = "";
        }
        public TcpClient client_
        {
            get
            {
                return this.client;
            }
            set
            {
                this.client = value;
            }
        }
        public string id_
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
    }
}
