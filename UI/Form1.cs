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
                            /// <summary>
                            ///QUY ĐỊNH NGƯỜI SỬ DỤNG CHƯƠNG TRÌNH CÓ BIẾN LÀ <ME>
                            ///NGƯỜI SỬ DỤNG SERVER LÀ USER
                            /// </summary>
                           
        private LoginForm loginForm;
        private List<UserUI> UserUIs; // List form giao diện chat cho từng user


        public static User me; // Nguoi su dung chuong trinh
        public static string idFocus = "";
        public static UserUI userUIForcus = null;
        public static SocketClient client;
        public static TcpClient server;
        // Tất cả các khai báo trên đều là biến tĩnh, được quyền sử dụng trọng mõi class.
        // ex: Form1.client


        public Form1()
        {
            InitializeComponent();           
        }
        public Form1(LoginForm loginform, User user, SocketClient client , TcpClient server)
        {
            UserUIs = new List<UserUI>();
            this.loginForm = loginform;
            Form1.client = client;
            Form1.server = server;
            Form1.me = user;
            InitializeComponent();
            LoadMyData();
            LoadDataUser();
            
            AwaitReadData();
            
            
        }

        private void LoadMyData()
        {
           
            labelID.Text = me.Id;
            labelUSERNAME.Text = me.Name;
        }

        // AwaitReadData chờ và nhận tin nhắn từ server
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

        //LoadDataUser gọi server trả về tất cả người dùng có trong server
        // Hiện tại chưa có code gọi người dùng online trong server mà chỉ gọi tất cả về
        private async void LoadDataUser()
        {
            client.SendToServer("LOADUSERDATA%" + me.Name);
            string data = await client.ReadDataAsync(server);
            string[] datauser = data.Split('%', '\0');
            // 3 dòng lấy dữ liệu
            for (int i = 0; i < datauser.Length; i++)
            {
                if (datauser[i] == "") break;
                string[] arr = datauser[i].Split(' ');
                if (arr[1] == me.Name) { continue; }
                UserUIs.Add(new UserUI(new User(arr[0], arr[1]), panelLISTUSER, panelRight));
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }

       
    }
}

