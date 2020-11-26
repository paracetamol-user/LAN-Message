using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        
        public SettingForm(User me)
        {
            lblUsername.Text = me.Name;
            lblPassword.Text = "*****";
            lblPath.Text = @"C:\Users\admin\Downloads\LAN_Message\";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void btnEditDownloadPath_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

    }
}
