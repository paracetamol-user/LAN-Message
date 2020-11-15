using Network;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Communication
{
    public class SocketServer
    {
        IPAddress mIP;
        int mPort;
        TcpListener mListener;
        List<UserClient> clients;
        List<UserClient> clientInvalid;
        //List<string> idInvalid;
        
        //Data Source = DESKTOP - TSN7OH7; Initial Catalog = LANCHAT; Integrated Security = True
        //Data Source=DESKTOP-TSN7OH7;Initial Catalog=LANCHAT;User ID=sa;Password=1;
        // Data Source=DESKTOP-BM0V9BJ;Initial Catalog=LANCHAT;Integrated Security=True
        string connString = @"Server=DESKTOP-TSN7OH7;Database=LANCHAT;Integrated Security=True;User ID=sa;Password=1";
        string queryLogin = "select * from USERS";
        string queryStatusOnline = "UPDATE USERS SET TINHTRANG = 1 WHERE ID = @id";
        string queryStatusOffline = "UPDATE USERS SET TINHTRANG = 0 WHERE ID = @id";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public EventHandler<ClientConnectedEventArgs> RaiseClientConnectedEvent;
        public EventHandler<TextReceivedEventArgs> RaiseTextReceivedEvent;
        protected virtual void OnRaiseClientConnectedEvent(ClientConnectedEventArgs ccea)
        {
            EventHandler<ClientConnectedEventArgs> handler = RaiseClientConnectedEvent;
            if (handler != null)
                handler(this, ccea);
        }
        protected virtual void OnRaiseTextREceivedEvent(TextReceivedEventArgs trea)
        {
            EventHandler<TextReceivedEventArgs> handler = RaiseTextReceivedEvent;
            if (handler != null)
                handler(this, trea);
        }

        private bool KeepRunning { get; set; }

        public SocketServer()
        {
            clients = new List<UserClient>();
            clientInvalid = new List<UserClient>();
            //idInvalid = new List<string>();
        }

        public async Task StartForIncommingConnection(IPAddress addr = null, int port = 5000)
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
                    UserClient returnedByAccept = new UserClient();
                    returnedByAccept.client_ = await mListener.AcceptTcpClientAsync();
                    clients.Add(returnedByAccept);
                    System.Diagnostics.Debug.WriteLine("Client connected, count: {0}", clients.Count);
                    WorkWithClient(returnedByAccept);
                    ClientConnectedEventArgs eaClientConnected;
                    eaClientConnected = new ClientConnectedEventArgs(returnedByAccept.client_.Client.ToString());
                    OnRaiseClientConnectedEvent(eaClientConnected);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private async Task RespondToClient(UserClient client, string received)
        {
            string[] data = received.Split('%');
            byte[] buffMessage;
            bool check = true;

            
            if (data[0] == "LOGIN")
            {
                try
                {
                    connection = new SqlConnection(connString);
                    connection.Open();
                    command = new SqlCommand(queryLogin, connection);
                   
                    reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        if (reader.Read() == false) break;
                        if (data[1] == reader.GetString(1) && data[2] == reader.GetString(2))
                        {
                            buffMessage = Encoding.ASCII.GetBytes("LOGINOKE "+reader.GetString(0));
                            await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                            client.id_ = reader.GetString(0);
                            clientInvalid.Add(client);
                            SendToAll(client, "ONLINE%" + client.id_.ToString());
                            //string temp = queryStatusOnline + client.id_.ToString();
                            connection.Close();
                            connection = new SqlConnection(connString);
                            connection.Open();
                            SqlCommand commandstatus = new SqlCommand(queryStatusOnline, connection);
                            commandstatus.Parameters.AddWithValue("@id", client.id_);
                            commandstatus.ExecuteNonQuery();
                            connection.Close();
                            
                            check = false;
                            break;
                        }
                    }
                    if (check != false)
                    {
                        buffMessage = Encoding.ASCII.GetBytes("LOGIN ERR");
                        await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                    }
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            else
            if (data[0] == "LOADUSERDATA")
            {
                try
                {
                    string arr = "";
                    connection = new SqlConnection(connString);
                    connection.Open();
                    command = new SqlCommand(queryLogin, connection);
                    reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        if (reader.Read() == false) break;
                        arr = arr + reader.GetString(0) + " " + reader.GetString(1) + " " +reader.GetBoolean(7).ToString()+ "%";
                    }
                    buffMessage = Encoding.ASCII.GetBytes(arr);
                    await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            } 
            else 
            if (data[0] == "SEND") //"SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text;
                // SEND  + Id của thằng gửi + ID thằng nhận + tin nhắn
            {
                int i = 0;
                foreach (var item in clientInvalid)
                {
                    if (item.id_.ToString() == data[2])
                    {
                        try
                        {
                            buffMessage = Encoding.ASCII.GetBytes("MESSAGE"+"%"+data[3] +"%" + data[1]);
                            await item.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                            return;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.ToString());
                        }
                    }
                    i++;
                }
            }
        }
        public async Task WorkWithClient(UserClient client)
        {
            NetworkStream stream = null;
            StreamReader reader = null;

            try
            {
                stream = client.client_.GetStream();
                reader = new StreamReader(stream);

                char[] buff = new char[200];

                while (true)
                {
                    System.Diagnostics.Debug.WriteLine("ready");
                    int nReturn = await reader.ReadAsync(buff, 0, buff.Length);
                    System.Diagnostics.Debug.WriteLine("Returned: ", nReturn);
                    if (nReturn == 0)
                    {
                        RemoveClient(client);
                        System.Diagnostics.Debug.WriteLine("Socket disconnected");
                        break;
                    }
                    string received = new string(buff).Trim('\0', '\r', '\n');
                    await RespondToClient(client, received);

                    System.Diagnostics.Debug.WriteLine("Received message: " + received);
                    OnRaiseTextREceivedEvent(new TextReceivedEventArgs(
                        client.client_.Client.RemoteEndPoint.ToString(),
                        received
                    ));
                    Array.Clear(buff, 0, buff.Length);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                string getId = client.id_;
                SendToAll(client, "OFFLINE%" + getId);
                clientInvalid.Remove(client);
                connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand commandstatus = new SqlCommand(queryStatusOffline, connection);
                commandstatus.Parameters.AddWithValue("@id", getId);
                commandstatus.ExecuteNonQuery();
            }
        }

        private void RemoveClient(UserClient client)
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

                foreach (UserClient client in clients)
                    client.client_.Close();
                clients.Clear();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public async void SendToAll(UserClient clientFocus,string message)
        {
            if (string.IsNullOrEmpty(message))
                return;
            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(message);
                foreach (UserClient client in clientInvalid)
                {
                    if (client != clientFocus)
                    await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        // FTP 
        int bufferSize = 1024;
        private async void ReceiveData(TcpClient paramClient)
        {
            NetworkStream stream = paramClient.GetStream();

            try
            {

                int byteRead;
                int allByteRead = 0;
                // Read length
                byte[] length = new byte[16];
                byteRead = stream.Read(length, 0, 16);
                int dataLength = BitConverter.ToInt32(length, 0);

                // Read data
                int byteLeft = dataLength;
                byte[] data = new byte[dataLength];

                while (byteLeft > 0)
                {
                    int nextPackageSize = byteLeft > bufferSize ? bufferSize : byteLeft;
                    byteRead = stream.Read(data, allByteRead, nextPackageSize);
                    allByteRead += byteRead;
                    byteLeft -= byteRead;
                }

                // Save image
                File.WriteAllBytes(@"C:\Users\admin\Desktop\Server_Folder\movie.mkv", data);

                // Report
                System.Diagnostics.Debug.WriteLine("File received");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
