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
        List<TcpClient> clients;
        List<TcpClient> clientInvalid;
        List<string> idInvalid;
        
        //Data Source = DESKTOP - TSN7OH7; Initial Catalog = LANCHAT; Integrated Security = True
        //Data Source=DESKTOP-TSN7OH7;Initial Catalog=LANCHAT;User ID=sa;Password=1;
        // Data Source=DESKTOP-BM0V9BJ;Initial Catalog=LANCHAT;Integrated Security=True
        string connString = @"Server=DESKTOP-BM0V9BJ;Database=LANCHAT;Integrated Security=True;";
        string queryLogin = "select * from USERS";
        string queryStatus = "UPDATE USERS SET TRANGTHAI = '1' WHERE ID = ";
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
            clients = new List<TcpClient>();
            clientInvalid = new List<TcpClient>();
            idInvalid = new List<string>();
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
                    TcpClient returnedByAccept = await mListener.AcceptTcpClientAsync();
                    clients.Add(returnedByAccept);
                    System.Diagnostics.Debug.WriteLine("Client connected, count: {0}", clients.Count);
                    WorkWithClient(returnedByAccept);
                    ClientConnectedEventArgs eaClientConnected;
                    eaClientConnected = new ClientConnectedEventArgs(returnedByAccept.Client.ToString());
                    OnRaiseClientConnectedEvent(eaClientConnected);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private async Task RespondToClient(TcpClient client, string received)
        {
            string[] data = received.Split('%');
            byte[] buffMessage;
            bool check = true;
            string idfocus;
            
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
                            await client.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                            clientInvalid.Add(client);
                            idInvalid.Add(reader.GetString(0));
                            idfocus = reader.GetString(0);

                            string temp = queryStatus + reader.GetString(0);
                            SqlCommand commandstatus = new SqlCommand(temp, connection);

                            //SendToAll("ONLINE " + reader.GetString(0));
                            connection.Close();
                            check = false;
                            break;
                        }
                    }
                    if (check != false)
                    {
                        buffMessage = Encoding.ASCII.GetBytes("LOGIN ERR");
                        await client.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
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
                    await client.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            } 
            else 
            if (data[0] == "SEND")
            {
                int i = 0;
                foreach (var item in idInvalid)
                {
                    if (item.ToString() == data[2])
                    {
                        try
                        {
                            buffMessage = Encoding.ASCII.GetBytes(data[3] +"%" + data[1]);
                            await clientInvalid[i].GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
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
        public async Task WorkWithClient(TcpClient client)
        {
            NetworkStream stream = null;
            StreamReader reader = null;

            try
            {
                stream = client.GetStream();
                reader = new StreamReader(stream);

                char[] buff = new char[1000];

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
                        client.Client.RemoteEndPoint.ToString(),
                        received
                    ));
                    Array.Clear(buff, 0, buff.Length);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                clientInvalid.Remove(client);


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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public async void SendToAll(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;

            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(message);
                foreach (TcpClient client in clientInvalid)
                {
                    await client.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
