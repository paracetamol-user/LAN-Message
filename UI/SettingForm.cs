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
        private string oldUsername;
        private string oldPath;
        Form1 parentForm;

        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(User me, Form1 parent)
        {
            InitializeComponent();
            lblUsername.Text = me.Name;
            lblPassword.Text = "*****";
            lblPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            oldUsername = me.Name;
            this.parentForm = parent;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {

            Form1.me.Name = oldUsername;
            this.Close();
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            // Hide labels
            this.lblUsername.Visible = false;
            // Create the textbox for typing username


            // Enable discard and save button for click
            this.btnDiscard.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnEditDownloadPath_Click(object sender, EventArgs e)
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

        // Edit password
        // Verify user and set new password
        // Dont't change status of DISCARD and SAVE button
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
                this.btnEditPassword.Text = "EDIT";
                this.panelChangePassword.Visible = false;
                this.btnSavePassword.Visible = false;
            }
        }

        // Discard changes and revert old version
        // Change status of DISCARD and SAVE button
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            // Reset information
            lblUsername.Text = oldUsername;
            lblPath.Text = oldPath;
            // Enable discard and save button for click
            this.btnDiscard.Enabled = false;
            this.btnSave.Enabled = false;
        }

        // Save changes and send to server
        // Change status of DISCARD and SAVE button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Upload to server and update to all users

            // Enable discard and save button for click
            this.btnDiscard.Enabled = false;
            this.btnSave.Enabled = false;
        }

        // Edit avatar function
        private void btnChangeAvatar_Click(object sender, EventArgs e)
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

        // Log out function
        // Close with parent form and login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }

    }
}
