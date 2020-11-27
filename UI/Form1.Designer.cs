namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelINTERACTED = new System.Windows.Forms.Panel();
            this.panelOPTION = new System.Windows.Forms.Panel();
            this.panelOPTIONNULL = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelUSERNAME = new System.Windows.Forms.Label();
            this.panelPICTUREOPTION = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaButtonAvatar1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelSEARCH = new System.Windows.Forms.Panel();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelLANMESS = new System.Windows.Forms.Panel();
            this.ButtonLanMessenger = new Guna.UI2.WinForms.Guna2Button();
            this.panelRIGHT = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelOPTION.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelPICTUREOPTION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaButtonAvatar1)).BeginInit();
            this.panelSEARCH.SuspendLayout();
            this.panelLANMESS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.panelINTERACTED);
            this.panelMenu.Controls.Add(this.panelOPTION);
            this.panelMenu.Controls.Add(this.panelSEARCH);
            this.panelMenu.Controls.Add(this.panelLANMESS);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(363, 665);
            this.panelMenu.TabIndex = 1;
            // 
            // panelINTERACTED
            // 
            this.panelINTERACTED.AutoScroll = true;
            this.panelINTERACTED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panelINTERACTED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelINTERACTED.Location = new System.Drawing.Point(0, 135);
            this.panelINTERACTED.Margin = new System.Windows.Forms.Padding(4);
            this.panelINTERACTED.Name = "panelINTERACTED";
            this.panelINTERACTED.Size = new System.Drawing.Size(363, 436);
            this.panelINTERACTED.TabIndex = 3;
            // 
            // panelOPTION
            // 
            this.panelOPTION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panelOPTION.Controls.Add(this.panelOPTIONNULL);
            this.panelOPTION.Controls.Add(this.panelInfo);
            this.panelOPTION.Controls.Add(this.panelPICTUREOPTION);
            this.panelOPTION.Controls.Add(this.gunaButtonAvatar1);
            this.panelOPTION.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOPTION.Location = new System.Drawing.Point(0, 571);
            this.panelOPTION.Margin = new System.Windows.Forms.Padding(4);
            this.panelOPTION.Name = "panelOPTION";
            this.panelOPTION.Padding = new System.Windows.Forms.Padding(16, 7, 0, 7);
            this.panelOPTION.Size = new System.Drawing.Size(363, 94);
            this.panelOPTION.TabIndex = 2;
            // 
            // panelOPTIONNULL
            // 
            this.panelOPTIONNULL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOPTIONNULL.Location = new System.Drawing.Point(305, 7);
            this.panelOPTIONNULL.Margin = new System.Windows.Forms.Padding(4);
            this.panelOPTIONNULL.Name = "panelOPTIONNULL";
            this.panelOPTIONNULL.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelOPTIONNULL.Size = new System.Drawing.Size(0, 80);
            this.panelOPTIONNULL.TabIndex = 3;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelID);
            this.panelInfo.Controls.Add(this.labelUSERNAME);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(101, 7);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.panelInfo.Size = new System.Drawing.Size(204, 80);
            this.panelInfo.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(4, 39);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(64, 24);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "#0040";
            // 
            // labelUSERNAME
            // 
            this.labelUSERNAME.AutoSize = true;
            this.labelUSERNAME.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUSERNAME.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSERNAME.Location = new System.Drawing.Point(4, 4);
            this.labelUSERNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUSERNAME.Name = "labelUSERNAME";
            this.labelUSERNAME.Size = new System.Drawing.Size(145, 35);
            this.labelUSERNAME.TabIndex = 0;
            this.labelUSERNAME.Text = "User Name";
            // 
            // panelPICTUREOPTION
            // 
            this.panelPICTUREOPTION.Controls.Add(this.pictureBox2);
            this.panelPICTUREOPTION.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPICTUREOPTION.Location = new System.Drawing.Point(298, 7);
            this.panelPICTUREOPTION.Margin = new System.Windows.Forms.Padding(4);
            this.panelPICTUREOPTION.Name = "panelPICTUREOPTION";
            this.panelPICTUREOPTION.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.panelPICTUREOPTION.Size = new System.Drawing.Size(65, 80);
            this.panelPICTUREOPTION.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // gunaButtonAvatar1
            // 
            this.gunaButtonAvatar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.gunaButtonAvatar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaButtonAvatar1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonAvatar1.Image")));
            this.gunaButtonAvatar1.Location = new System.Drawing.Point(16, 7);
            this.gunaButtonAvatar1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButtonAvatar1.Name = "gunaButtonAvatar1";
            this.gunaButtonAvatar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaButtonAvatar1.ShadowDecoration.Parent = this.gunaButtonAvatar1;
            this.gunaButtonAvatar1.Size = new System.Drawing.Size(85, 80);
            this.gunaButtonAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaButtonAvatar1.TabIndex = 0;
            this.gunaButtonAvatar1.TabStop = false;
            this.gunaButtonAvatar1.UseTransparentBackground = true;
            // 
            // panelSEARCH
            // 
            this.panelSEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panelSEARCH.Controls.Add(this.textBoxSearch);
            this.panelSEARCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSEARCH.Location = new System.Drawing.Point(0, 69);
            this.panelSEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.panelSEARCH.Name = "panelSEARCH";
            this.panelSEARCH.Padding = new System.Windows.Forms.Padding(16, 6, 11, 6);
            this.panelSEARCH.Size = new System.Drawing.Size(363, 66);
            this.panelSEARCH.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoRoundedCorners = true;
            this.textBoxSearch.BorderRadius = 26;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.Parent = this.textBoxSearch;
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.FocusedState.Parent = this.textBoxSearch;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.HoverState.Parent = this.textBoxSearch;
            this.textBoxSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("textBoxSearch.IconRight")));
            this.textBoxSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.textBoxSearch.Location = new System.Drawing.Point(16, 6);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.ShadowDecoration.Parent = this.textBoxSearch;
            this.textBoxSearch.Size = new System.Drawing.Size(336, 54);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panelLANMESS
            // 
            this.panelLANMESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panelLANMESS.Controls.Add(this.ButtonLanMessenger);
            this.panelLANMESS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLANMESS.Location = new System.Drawing.Point(0, 0);
            this.panelLANMESS.Margin = new System.Windows.Forms.Padding(0);
            this.panelLANMESS.Name = "panelLANMESS";
            this.panelLANMESS.Padding = new System.Windows.Forms.Padding(10);
            this.panelLANMESS.Size = new System.Drawing.Size(363, 69);
            this.panelLANMESS.TabIndex = 0;
            // 
            // ButtonLanMessenger
            // 
            this.ButtonLanMessenger.BackColor = System.Drawing.Color.Black;
            this.ButtonLanMessenger.CheckedState.Parent = this.ButtonLanMessenger;
            this.ButtonLanMessenger.CustomImages.Parent = this.ButtonLanMessenger;
            this.ButtonLanMessenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLanMessenger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ButtonLanMessenger.Font = new System.Drawing.Font("Corbel", 16.2F);
            this.ButtonLanMessenger.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonLanMessenger.HoverState.Parent = this.ButtonLanMessenger;
            this.ButtonLanMessenger.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLanMessenger.Image")));
            this.ButtonLanMessenger.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonLanMessenger.Location = new System.Drawing.Point(10, 10);
            this.ButtonLanMessenger.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLanMessenger.Name = "ButtonLanMessenger";
            this.ButtonLanMessenger.ShadowDecoration.Parent = this.ButtonLanMessenger;
            this.ButtonLanMessenger.Size = new System.Drawing.Size(343, 49);
            this.ButtonLanMessenger.TabIndex = 0;
            this.ButtonLanMessenger.Text = "Lan Messenger";
            this.ButtonLanMessenger.Click += new System.EventHandler(this.ButtonLanMessenger_Click);
            // 
            // panelRIGHT
            // 
            this.panelRIGHT.BackColor = System.Drawing.Color.White;
            this.panelRIGHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRIGHT.Location = new System.Drawing.Point(363, 0);
            this.panelRIGHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRIGHT.Name = "panelRIGHT";
            this.panelRIGHT.Size = new System.Drawing.Size(656, 665);
            this.panelRIGHT.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 665);
            this.Controls.Add(this.panelRIGHT);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(885, 585);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelOPTION.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPICTUREOPTION.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaButtonAvatar1)).EndInit();
            this.panelSEARCH.ResumeLayout(false);
            this.panelLANMESS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLANMESS;
        private System.Windows.Forms.Panel panelSEARCH;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelINTERACTED;
        private System.Windows.Forms.Panel panelOPTION;
        private System.Windows.Forms.Panel panelPICTUREOPTION;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelUSERNAME;
        private System.Windows.Forms.Panel panelOPTIONNULL;
        private System.Windows.Forms.Panel panelRIGHT;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaButtonAvatar1;
        private Guna.UI2.WinForms.Guna2Button ButtonLanMessenger;
    }
}

