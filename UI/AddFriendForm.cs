using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ServerForm : Form
    {
        public static Panel panelAllUser;
        public static Panel panelOnlineUser;
        private bool CheckLoadAllUser;
        private bool CheckLoadOnlineUser;
        public ServerForm()
        {
            InitializeComponent();
            panelAllUser = new Panel();
            panelOnlineUser = new Panel();
            this.Controls.Add(panelAllUser);
            this.Controls.Add(panelOnlineUser);
            this.InitPanelAllUser();
            this.InitPanelOnlineUser();
            CheckLoadAllUser = false;
            CheckLoadOnlineUser = false;
        }


        private void gunaButtonOnline_Click(object sender, EventArgs e)
        {
            ServerForm.panelOnlineUser.Controls.Clear();
            panelOnlineUser.Show();
            panelOnlineUser.BringToFront();
            for (int i = 0; i < Form1.UserUIs.Count; i++)
            {
                if (Form1.UserUIs[i].GetStatus() == true)
                {
                    Form1.UserUIs[i].AddInfoUserIntoPanelOnlineUser();
                }
            }
        }
        private void LoadListAllUser()
        {
            for (int i = 0; i < Form1.UserUIs.Count; i++)
            {
                Form1.UserUIs[i].AddInfoUserIntoPanelAllUser();
            }
        }
        private void InitPanelAllUser()
        {
            ServerForm.panelAllUser.Dock = DockStyle.Fill;
            ServerForm.panelAllUser.BackColor = Color.White;
            ServerForm.panelAllUser.Padding = new Padding(30, 20, 0, 0);
            ServerForm.panelAllUser.BringToFront();
        }
        private void InitPanelOnlineUser()
        {
            ServerForm.panelOnlineUser.Dock = DockStyle.Fill;
            ServerForm.panelOnlineUser.BackColor = Color.White;
            ServerForm.panelOnlineUser.Padding = new Padding(30, 20, 0, 0);
            ServerForm.panelOnlineUser.BringToFront();
        }

        private void gunaButtonAll_Click(object sender, EventArgs e)
        {
            //ServerForm.panelAllUser.Controls.Clear();
            panelAllUser.Show();
            panelAllUser.BringToFront();
            if (!CheckLoadAllUser)
            {
                LoadListAllUser();
                CheckLoadAllUser = true;
            }
        }
    }
}
