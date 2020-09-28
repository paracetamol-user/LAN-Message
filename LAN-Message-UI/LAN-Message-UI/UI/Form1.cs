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
        private const double V = 35.0;

        public Form1()
        {
            InitializeComponent();
            Button but = new Button();
            SettingUser(but); // lấy cái này làm setting( FlatStyle , font , Dock, ...) gốc khi tạo 1 User mới.

            //
            //..
            //

            Init();
        }
        //..
        private void SettingUser(Button but)
        {
            but.Text = "User 1";
            but.FlatStyle = FlatStyle.Flat;
            but.FlatAppearance.BorderSize = 0;
            but.ForeColor = Color.LightGray;
            but.Dock = DockStyle.Top;
            
            panelListFriend.Controls.Add(but);
        }
        private void Init()
        {
            panelListFriend.Visible = false;
            panelListGroup.Visible = false;
        }
        private void HideMenu()
        {
            if (panelListFriend.Visible == true) panelListFriend.Visible = false;
            if (panelListGroup.Visible == true) panelListGroup.Visible = false;
        }
        private void ShowMenu(Panel Menu)
        {
            if (Menu.Visible == false)
            {
                HideMenu();
                Menu.Visible = true;

            }
            else Menu.Visible = false;
        }

        private void butfriend_Click(object sender, EventArgs e)
        {
            ShowMenu(panelListFriend);
        }

        private void butgroup_Click(object sender, EventArgs e)
        {
            ShowMenu(panelListGroup);
        }
        private Form TempForm = null;
        private void openAddForm(Form AddForm)
        {
            if (TempForm != null)
            {
                TempForm.Close();
            }
            TempForm = AddForm;
            AddForm.TopLevel = false;
            AddForm.FormBorderStyle = FormBorderStyle.None;
            AddForm.Dock = DockStyle.Fill;
            panelMess.Controls.Add(AddForm);
            AddForm.BringToFront();
            AddForm.Show();
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            openAddForm(new AddForm());
            HideMenu();
        }
    }
}
