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

namespace UI
{
    public partial class Form1 : Form
    {
        LoginForm loginForm;
        SocketClient client;
        TcpClient server;
        string username;
        string id;
        List<Button> ListButtonUser= new List<Button>();
        Button userFocus;
        List<Panel> ListViewChatBoxs;
        public Form1()
        {

        }
        public Form1(LoginForm loginform, string username, SocketClient client , TcpClient server)
        {
            this.loginForm = loginform;
            this.client = client;
            this.server = server;
            this.username = username;

            InitializeComponent();
            //InitPanelInfoFriend(); // Khởi tạo giao diện PanelInfoFriend
            InitPanelListFriend();  // Khởi tạo giao diện PanelListFriend
            LoadDataUser(); //Load Người dùng từ server đổ về

            customizeDesign(); // Ẩn các giao diện
        }

        private async void LoadDataUser()
        {
            await client.SendToServer("LOADUSERDATA " + username);
            string data = await client.ReadDataAsync(server);
            string[] datauser = data.Split('-','\0');
            // 3 dòng lấy dữ liệu
            for (int i = 0; i < datauser.Length; i++)
            {
                if (datauser[i] == "") break;
                
                string[] arr = datauser[i].Split(' ');
                if (arr[1] == username)
                {
                    id = arr[0];
                    continue;
                }
                Button but = new Button();
                settingButUser(ref but);
                but.Text = arr[1];
                but.Name = arr[0];
                panelListFriend.Controls.Add(but);
                ListButtonUser.Add(but);
            }
        }
        //private void InitPanelInfoFriend()
        //{
        //    panelInfoFriend = new Panel();
        //    panelInfoFriend.Dock = DockStyle.Right;
        //    panelInfoFriend.Visible = false;
        //    panelInfoFriend.BorderStyle = BorderStyle.FixedSingle;
        //    panelInfoFriend.Size = new Size(panelRight.Size.Width / 3, 100);
        //}
        private void closeActiveForm()
        {
            if (activeForm != null) activeForm.Close();
        }
        private void customizeDesign()
        {
            panelListFriend.Visible = false;
            //panelInfoFriend.Visible = false;   
        }
        private void hideSubMenu()
        {
            panelListFriend.Visible = false;
        }
        private void showSubMenu()
        {
            panelListFriend.Visible = true;
        }
        private void InitPanelListFriend()
        {
            panelListFriend.Visible = false;
            panelListFriend.AutoScroll = true;
            panelListFriend.AutoSize = false;
            panelListFriend.Dock = DockStyle.Top;
        }
        private void settingButUser(ref Button but)
        { 
            but.BackColor = Color.White;
            but.Dock = DockStyle.Top;
            but.TextAlign = ContentAlignment.MiddleRight;
            but.FlatStyle = FlatStyle.Flat;
            but.Size = new Size(204, 50);
            but.FlatAppearance.BorderSize = 0;
            but.FlatAppearance.MouseOverBackColor = Color.LightBlue;
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
        private void iconButtonFriend_Click_1(object sender, EventArgs e)
        {
            closeActiveForm();
            if (panelListFriend.Visible == false)
            {
                showSubMenu();
            }
            else hideSubMenu();
        }
        private void iconButtonAddF_Click(object sender, EventArgs e)
        {
            Form addFriendForm = new AddFriendForm();
            
            customizeDesign();
            openAddForm(addFriendForm);
        }
        private void pictureBoxAvata_Click(object sender, EventArgs e)
        {
            closeActiveForm();
            customizeDesign();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (panelListFriend.AutoSize == true) panelListFriend.AutoSize = false;
            else panelListFriend.AutoSize = true;
        }
    }
}

