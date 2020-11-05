using Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
namespace UI
{
    public partial class Form1 : Form
    {
        private LoginForm loginForm;
        private SocketClient client;
        private TcpClient server;
        
        private User user; // Đối tượng người dùng
        private List<UserUI> UserUIs; // List giao diện của User
        private string idFocus; //User đang được nhấn vào
        public Form1()
        {
            InitializeComponent();           
            
            //UserUIs.Add(new UserUI("1","dat", "12", panelLISTUSER, panelRight , client, server , idFocus));
            //UserUIs.Add(new UserUI("1","nam", "3",  panelLISTUSER,  panelRight , client , server, idFocus));
            //UserUIs.Add(new UserUI("1","kiet", "10",  panelLISTUSER,  panelRight , client , server, idFocus));

        }
        public Form1(LoginForm loginform, User user, SocketClient client , TcpClient server)
        {
            UserUIs = new List<UserUI>();
            this.loginForm = loginform;
            this.client = client;
            this.server = server;
            this.user = user;
            InitializeComponent();
            LoadDataUser();
            AwaitReadData();
        }
        
        private async Task AwaitReadData()
        {   
            while (true)
            {
                string[] data = (await client.ReadDataAsync(server)).Split('%');
                string mess = data[0];
                string id = data[1].Trim('\0');
                for (int i = 0; i < UserUIs.Count; i++)
                {
                    if (UserUIs[i].GetId() == id)
                    {
                        UserUIs[i].AddMessage(mess);
                        break;
                    }
                }
            }
                
        }
        private async void LoadDataUser()
        {
            client.SendToServer("LOADUSERDATA%" + user.Name);
            string data = await client.ReadDataAsync(server);
            string[] datauser = data.Split('%', '\0');
            // 3 dòng lấy dữ liệu
            for (int i = 0; i < datauser.Length; i++)
            {
                if (datauser[i] == "") break;
                string[] arr = datauser[i].Split(' ');
                if (arr[1] == user.Name) { continue; }
                UserUIs.Add(new UserUI(user, new User(arr[0], arr[1]), panelLISTUSER, panelRight , client , server));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
        }

       
    }
}

