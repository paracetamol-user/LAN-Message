using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            LoadPanelListFriend();
        }
        private void closeActiveForm()
        {
            if (activeForm != null) activeForm.Close();
        }
        private void customizeDesign()
        {
            panelListFriend.Visible = false;
            panelInfo.Visible = false;
            panelChatBox.Visible = false;
        }
        private void hideSubMenu()
        {
            panelListFriend.Visible = false;
        }
        private void showSubMenu()
        {
            panelListFriend.Visible = true;
        }
        private void LoadPanelListFriend()
        {
            // Setting Panel List Friend
            panelListFriend.Visible = false;
            panelListFriend.AutoScroll = true;
            panelListFriend.AutoSize = true;
            panelListFriend.Dock = DockStyle.Top;
            // Created Friend Button
            //
            //..
            //
            Button but = new Button();
            settingBut(ref but);
            panelListFriend.Controls.Add(but);
        }
        private void settingBut(ref Button but)
        {
            but.Text = "Name User";
            but.BackColor = Color.White;
            but.Dock = DockStyle.Top;
            but.TextAlign = ContentAlignment.MiddleRight;
            but.FlatStyle = FlatStyle.Flat;
            but.Size = new Size(204, 50);
            but.FlatAppearance.BorderSize = 0;
            but.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            but.Click += But_Click;
        }

        private void But_Click(object sender, EventArgs e)
        {
            panelChatBox.Visible = true;
            panelInfo.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            closeActiveForm();
            customizeDesign();
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
    }
}

