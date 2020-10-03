using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class Server
    {
        IPAddress mIP;
        int mPort;
        TcpListener mListener;
        List<TcpClient> clients;

        private bool KeepRunning { get; set; }

        public Server()
        {
            clients = new List<TcpClient>();
        }

        public async void StartForIncommingConnection(IPAddress addr = null, int port = 5000)
        {
            if (addr == null)
                addr = IPAddress.Any;

            if (port < 0 || port > 65535)
                port = 5000;

            mIP = addr;
            mPort = port;

            System.Diagnostics.Debug.WriteLine(string.Format("IP Address: {0} - Port: {1}", mIP, mPort));
            mListener = new TcpListener(mIP, mPort);

            try
            {
                mListener.Start();
                KeepRunning = true;

                while (KeepRunning)
                {
                    TcpClient returnedByAccept = await mListener.AcceptTcpClientAsync();
                    clients.Add(returnedByAccept);
                    System.Diagnostics.Debug.WriteLine("Client connected, count: {0}", clients.Count);
                    WorkWithClient(returnedByAccept);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private async void WorkWithClient(TcpClient client)
        {
            NetworkStream stream = null;
            StreamReader reader = null;

            try
            {
                stream = client.GetStream();
                reader = new StreamReader(stream);

                char[] buff = new char[64];

                while (KeepRunning)
                {
                    System.Diagnostics.Debug.WriteLine("ready");
                    int nReturn = await reader.ReadAsync(buff, 0, buff.Length);

                    System.Diagnostics.Debug.WriteLine("Returned: ", nReturn);

                    if(nReturn == 0)
                    {
                        RemoveClient(client);
                        System.Diagnostics.Debug.WriteLine("Socket disconnected");
                        break;
                    }

                    string received = new string(buff);
                    System.Diagnostics.Debug.WriteLine("Received message: ", received);

                    Array.Clear(buff, 0, buff.Length);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void RemoveClient(TcpClient client)
        {
            if (clients.Contains(client))
            {
                clients.Remove(client);
                System.Diagnostics.Debug.WriteLine("Client removed, count: {0}", clients.Count);
            }
        }

        public void StopServer()
        {
            try
            {
                if (mListener != null)
                    mListener.Stop();

                foreach (TcpClient client in clients)
                    client.Close();
                clients.Clear();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
