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
        Form1 parentForm;

        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(User me, Form1 parent)
        {
            InitializeComponent();
            lblUsername.Text = me.Name;
            lblPassword.Text = "*********";
            lblPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            lblUsername.Text = me.Name;
            this.parentForm = parent;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {

            if (Form1.me.Name != lblName.Text)
                Form1.me.Name = lblName.Text;
            this.Close();
        }

        private bool isChangingUsername = false;
        private TextBox txtUsername = null;


        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            if (!isChangingUsername)
            {
                isChangingUsername = true;
                // Hide label
                this.lblUsername.Visible = false;
                // Create the textbox for typing username
                txtUsername = new TextBox();
                this.panelUsername.Controls.Add(txtUsername);
                txtUsername.Text = lblUsername.Text;
                txtUsername.Dock = DockStyle.Left;
                txtUsername.Width = 180;
                txtUsername.Height = 22;
                txtUsername.TextChanged += (s, ev) =>
                {
                    this.btnDiscard.Enabled = true;
                    this.btnSave.Enabled = true;
                };
            }
            //// Enable discard and save button for click
            //this.btnDiscard.Enabled = true;
            //this.btnSave.Enabled = true;
        }
        // Check new username is valid and not equal to old username
        private bool CheckUsername()
        {
            // Check empty
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username invalid!");
                txtUsername.Text = lblUsername.Text;
                return false;
            }

            txtUsername.Text = txtUsername.Text.Trim();
            return true;
        }
        // Release changes in username
        private void ReleaseUsernameChange()
        {
            // Remove textbox for change username
            this.panelUsername.Controls.Remove(txtUsername);
            txtUsername.Visible = false;
            txtUsername = null;

            // Show label username
            this.lblUsername.Visible = true;
        }

        // Edit password
        // Verify user and set new password
        // Dont't change status of DISCARD and SAVE button

        private void circlePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "Image (*.BMP, *.JPG, *PNG)|*.BMP, *.JPG, *.PNG";

            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image avatar = Image.FromFile(openFileDialog.FileName);
                this.circlePictureBox.Image = avatar;

                // Upload to database and update to all users.
            }

            // Enable discard and save button for click
            this.btnDiscard.Enabled = false;
            this.btnSave.Enabled = false;
        }
        private void btnEditDownloadPath_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            // Description for browser
            browser.Description = "Select downloads save path";
            // Allow create new folders in file explorer
            browser.ShowNewFolderButton = true;
            // Default to the My documents folder
            browser.RootFolder = Environment.SpecialFolder.MyDocuments;
            // Show the browser dialog and return path string
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
                lblPath.Text = browser.SelectedPath;


            // Enable discard and save button for click
            this.btnDiscard.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnSavePassword_Click_1(object sender, EventArgs e)
        {
            // Check from database

            // if true update to database
            // else MessageBox.Show("Wrong password")
        }
        // Log out function
        // Close with parent form and login form

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Check valid username
            if (CheckUsername())
            {
                // Update to server

                // Change label status and release change in username
                this.lblUsername.Text = txtUsername.Text;
                ReleaseUsernameChange();
                this.lblUsername.Visible = true;
                // Enable discard and save button for click
                this.btnDiscard.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else return;

            // Check path is valid
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            // Release changes in username field
            ReleaseUsernameChange();
            isChangingUsername = false;

            // Release changes in path


            // Enable discard and save button for click
            this.btnDiscard.Enabled = false;
            this.btnSave.Enabled = false;
        }
        // Discard changes and revert old version
        // Change status of DISCARD and SAVE button
        // Save changes and send to server
        // Change status of DISCARD and SAVE button
        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (this.panelChangePassword.Visible == false)
            {
                this.btnEditPassword.Text = "CANCEL";
                this.panelChangePassword.Visible = true;
                this.btnSavePassword.Visible = true;

            }
            else
            {
                this.btnEditPassword.Text = "CHANGE";
                this.panelChangePassword.Visible = false;
                this.btnSavePassword.Visible = false;
            }
        }
      
    }
}
