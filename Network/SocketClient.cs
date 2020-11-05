using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;

namespace Communication
{
    public class SocketClient
    {
        IPAddress mServerIPAddress;
        int mPort;
        TcpClient mClient;

        public SocketClient()
        {
            mClient = null;
            mPort = -1;
            mClient = null;
        }

        public IPAddress ServerIPAddress
        {
            get
            {
                return mServerIPAddress;
            }
        }
        public int ServerPort
        {
            get
            {
                return mPort;
            }
        }

        public bool SetServerIPAddress(string ServerIPAddress)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(ServerIPAddress, out ip))
            {
                System.Diagnostics.Debug.WriteLine("Invalid address");
                return false;
            }

            this.mServerIPAddress = ip;
            return true;
        }
        public bool SetServerPort(string ServerPort)
        {
            int port;
            if (!int.TryParse(ServerPort.Trim(), out port))
            {
                System.Diagnostics.Debug.WriteLine("Invalid port");
                return false;
            }
            if (port <= 0 || port > 65535)
            {
                System.Diagnostics.Debug.WriteLine("Outranged port");
                return false;
            }
            mPort = port;
            return true;
        }

        public async Task<TcpClient> ConnectToServer()
        {
            if (mClient == null)
                mClient = new TcpClient();

            try
            {
                await mClient.ConnectAsync(mServerIPAddress, mPort);
                System.Diagnostics.Debug.WriteLine(string.Format("Connect to server IP/Port: {0} - {1}",
                            mServerIPAddress, mPort));
                return mClient;
                //await ReadDataAsync(mClient);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return null;
        }
        public void CloseAndDisconnect()
        {
            if (mClient != null)
            {
                if (mClient.Connected)
                    mClient.Close();
            }
        }
        public async Task SendToServer(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;

            if (mClient != null)
            {
                if (mClient.Connected)
                {
                    StreamWriter writer = new StreamWriter(mClient.GetStream());
                    writer.AutoFlush = true;
                    await writer.WriteLineAsync(message);
                    System.Diagnostics.Debug.WriteLine(string.Format(message + "*sent*"));
                }
            }
        }
        public async Task<string> ReadDataAsync(TcpClient mClient)
        {
            try
            {
                StreamReader reader = new StreamReader(mClient.GetStream());
                char[] buff = new char[64];
                int readByCount = 0;
                    readByCount = await reader.ReadAsync(buff, 0, buff.Length);
                    if (readByCount <= 0)
                    {
                        System.Diagnostics.Debug.WriteLine("Disconnected");
                        mClient.Close();
                    }
                    System.Diagnostics.Debug.WriteLine(string.Format("Received byte: {0} - Message: {1}", readByCount, new string(buff)));
                    return new string(buff);
                    Array.Clear(buff, 0, buff.Length);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
            return null;
        }
    }
}
