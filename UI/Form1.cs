using Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
namespace UI
{
    public partial class Form1 : Form
    {
        LoginForm loginForm;
        SocketClient client;
        TcpClient server;
        User user;
        List<UserUI> UserUIs;
        public Form1()
        {
            InitializeComponent();
            
            
            UserUIs = new List<UserUI>();
            UserUIs.Add(new UserUI("1","dat", "12", panelLISTUSER, panelRight , client, server));
            UserUIs.Add(new UserUI("1","nam", "3",  panelLISTUSER,  panelRight , client , server));
            UserUIs.Add(new UserUI("1","kiet", "10",  panelLISTUSER,  panelRight , client , server));

        }
        public Form1(LoginForm loginform, string username, SocketClient client , TcpClient server)
        {
            this.loginForm = loginform;
            this.client = client;
            this.server = server;
            this.user = new User(username);

            InitializeComponent();
            //LoadDataUser(); //Load Người dùng từ server đổ về
            //customizeDesign(); // Ẩn các giao diện
        }

        //private async void LoadDataUser()
        //{
        //    await client.SendToServer("LOADUSERDATA " + username);
        //    string data = await client.ReadDataAsync(server);
        //    string[] datauser = data.Split('-','\0');
        //    // 3 dòng lấy dữ liệu
        //    for (int i = 0; i < datauser.Length; i++)
        //    {
        //        if (datauser[i] == "") break;
                
        //        string[] arr = datauser[i].Split(' ');
        //        if (arr[1] == username)
        //        {
        //            id = arr[0];
        //            continue;
        //        }
        //        Button but = new Button();
        //        settingButUser(ref but);
        //        but.Text = arr[1];
        //        but.Name = arr[0];
                
        //        ListButtonUser.Add(but);
        //    }
        //}
        private void closeActiveForm()
        {
            if (activeForm != null) activeForm.Close();
        }
        private void customizeDesign()
        {
            
            //panelInfoFriend.Visible = false;   
        }
        private void hideSubMenu()
        {
            //panelListUser.Visible = false;
        }
        private void showSubMenu()
        {
            //panelListUser.Visible = true;
        }
       
        
        private Form activeForm = null;
        private void openAddForm(Form AddForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = AddForm;
            AddForm.TopLevel = false;
            AddForm.FormBorderStyle = FormBorderStyle.None;
            AddForm.Dock = DockStyle.Fill;
            AddForm.BackColor = Color.White;
            panelRight.Controls.Add(AddForm);
            panelRight.Tag = AddForm;
            AddForm.BringToFront();
            AddForm.Show();
        }
        //private void iconButtonFriend_Click_1(object sender, EventArgs e)
        //{
        //    closeActiveForm();
        //    if (panelListFriend.Visible == false)
        //    {
        //        showSubMenu();
        //    }
        //    else hideSubMenu();
        //}
        //private void iconButtonAddF_Click(object sender, EventArgs e)
        //{
        //    Form addFriendForm = new AddFriendForm();

        //    customizeDesign();
        //    openAddForm(addFriendForm);
        //}
        //private void pictureBoxAvata_Click(object sender, EventArgs e)
        //{
        //    closeActiveForm();
        //    customizeDesign();
        //}
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}

