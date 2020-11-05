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
            this.panelLISTUSER = new System.Windows.Forms.Panel();
            this.panelOPTION = new System.Windows.Forms.Panel();
            this.panelOPTIONNULL = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelUSERNAME = new System.Windows.Forms.Label();
            this.panelPICTUREOPTION = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelSEARCH = new System.Windows.Forms.Panel();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelLANMESS = new System.Windows.Forms.Panel();
            this.panelTEXTLANMESS = new System.Windows.Forms.Panel();
            this.labelLANMESS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.ButtonUser = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu.SuspendLayout();
            this.panelOPTION.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelPICTUREOPTION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panelSEARCH.SuspendLayout();
            this.panelLANMESS.SuspendLayout();
            this.panelTEXTLANMESS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.panelLISTUSER);
            this.panelMenu.Controls.Add(this.panelOPTION);
            this.panelMenu.Controls.Add(this.panelSEARCH);
            this.panelMenu.Controls.Add(this.panelLANMESS);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(233, 448);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLISTUSER
            // 
            this.panelLISTUSER.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLISTUSER.Location = new System.Drawing.Point(0, 106);
            this.panelLISTUSER.Name = "panelLISTUSER";
            this.panelLISTUSER.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLISTUSER.Size = new System.Drawing.Size(233, 279);
            this.panelLISTUSER.TabIndex = 3;
            // 
            // panelOPTION
            // 
            this.panelOPTION.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOPTION.Controls.Add(this.panelOPTIONNULL);
            this.panelOPTION.Controls.Add(this.panelInfo);
            this.panelOPTION.Controls.Add(this.panelPICTUREOPTION);
            this.panelOPTION.Controls.Add(this.Avatar);
            this.panelOPTION.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOPTION.Location = new System.Drawing.Point(0, 385);
            this.panelOPTION.Name = "panelOPTION";
            this.panelOPTION.Padding = new System.Windows.Forms.Padding(12, 7, 0, 7);
            this.panelOPTION.Size = new System.Drawing.Size(233, 63);
            this.panelOPTION.TabIndex = 2;
            // 
            // panelOPTIONNULL
            // 
            this.panelOPTIONNULL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOPTIONNULL.Location = new System.Drawing.Point(131, 7);
            this.panelOPTIONNULL.Name = "panelOPTIONNULL";
            this.panelOPTIONNULL.Padding = new System.Windows.Forms.Padding(5);
            this.panelOPTIONNULL.Size = new System.Drawing.Size(63, 49);
            this.panelOPTIONNULL.TabIndex = 3;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelID);
            this.panelInfo.Controls.Add(this.labelUSERNAME);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(61, 7);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panelInfo.Size = new System.Drawing.Size(70, 49);
            this.panelInfo.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(3, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(39, 16);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "#0040";
            // 
            // labelUSERNAME
            // 
            this.labelUSERNAME.AutoSize = true;
            this.labelUSERNAME.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUSERNAME.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSERNAME.Location = new System.Drawing.Point(3, 3);
            this.labelUSERNAME.Name = "labelUSERNAME";
            this.labelUSERNAME.Size = new System.Drawing.Size(65, 16);
            this.labelUSERNAME.TabIndex = 0;
            this.labelUSERNAME.Text = "User Name";
            // 
            // panelPICTUREOPTION
            // 
            this.panelPICTUREOPTION.Controls.Add(this.pictureBox2);
            this.panelPICTUREOPTION.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPICTUREOPTION.Location = new System.Drawing.Point(194, 7);
            this.panelPICTUREOPTION.Name = "panelPICTUREOPTION";
            this.panelPICTUREOPTION.Padding = new System.Windows.Forms.Padding(5, 13, 5, 13);
            this.panelPICTUREOPTION.Size = new System.Drawing.Size(39, 49);
            this.panelPICTUREOPTION.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::UI.Properties.Resources.options;
            this.pictureBox2.Location = new System.Drawing.Point(5, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Avatar
            // 
            this.Avatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Avatar.Image = global::UI.Properties.Resources.avatar;
            this.Avatar.Location = new System.Drawing.Point(12, 7);
            this.Avatar.Name = "Avatar";
            this.Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Avatar.ShadowDecoration.Parent = this.Avatar;
            this.Avatar.Size = new System.Drawing.Size(49, 49);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // panelSEARCH
            // 
            this.panelSEARCH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSEARCH.Controls.Add(this.textBoxSearch);
            this.panelSEARCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSEARCH.Location = new System.Drawing.Point(0, 63);
            this.panelSEARCH.Name = "panelSEARCH";
            this.panelSEARCH.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.panelSEARCH.Size = new System.Drawing.Size(233, 43);
            this.panelSEARCH.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoRoundedCorners = true;
            this.textBoxSearch.BorderRadius = 15;
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
            this.textBoxSearch.IconRight = global::UI.Properties.Resources.search;
            this.textBoxSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.textBoxSearch.Location = new System.Drawing.Point(12, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.ShadowDecoration.Parent = this.textBoxSearch;
            this.textBoxSearch.Size = new System.Drawing.Size(209, 33);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panelLANMESS
            // 
            this.panelLANMESS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLANMESS.Controls.Add(this.panelTEXTLANMESS);
            this.panelLANMESS.Controls.Add(this.pictureBox1);
            this.panelLANMESS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLANMESS.Location = new System.Drawing.Point(0, 0);
            this.panelLANMESS.Margin = new System.Windows.Forms.Padding(0);
            this.panelLANMESS.Name = "panelLANMESS";
            this.panelLANMESS.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.panelLANMESS.Size = new System.Drawing.Size(233, 63);
            this.panelLANMESS.TabIndex = 0;
            // 
            // panelTEXTLANMESS
            // 
            this.panelTEXTLANMESS.Controls.Add(this.labelLANMESS);
            this.panelTEXTLANMESS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTEXTLANMESS.Location = new System.Drawing.Point(63, 10);
            this.panelTEXTLANMESS.Name = "panelTEXTLANMESS";
            this.panelTEXTLANMESS.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelTEXTLANMESS.Size = new System.Drawing.Size(170, 43);
            this.panelTEXTLANMESS.TabIndex = 7;
            // 
            // labelLANMESS
            // 
            this.labelLANMESS.AutoSize = true;
            this.labelLANMESS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLANMESS.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLANMESS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLANMESS.Location = new System.Drawing.Point(0, 10);
            this.labelLANMESS.Name = "labelLANMESS";
            this.labelLANMESS.Size = new System.Drawing.Size(168, 27);
            this.labelLANMESS.TabIndex = 8;
            this.labelLANMESS.Text = "LAN MESSENGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.ButtonUser);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(233, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(419, 448);
            this.panelRight.TabIndex = 6;
            // 
            // ButtonUser
            // 
            this.ButtonUser.CheckedState.Parent = this.ButtonUser;
            this.ButtonUser.CustomImages.Parent = this.ButtonUser;
            this.ButtonUser.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUser.ForeColor = System.Drawing.Color.Black;
            this.ButtonUser.HoverState.Parent = this.ButtonUser;
            this.ButtonUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonUser.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonUser.Location = new System.Drawing.Point(143, 45);
            this.ButtonUser.Name = "ButtonUser";
            this.ButtonUser.ShadowDecoration.Parent = this.ButtonUser;
            this.ButtonUser.Size = new System.Drawing.Size(180, 45);
            this.ButtonUser.TabIndex = 0;
            this.ButtonUser.Text = "UNKNOW";
            this.ButtonUser.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 448);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(668, 487);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.panelOPTION.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPICTUREOPTION.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panelSEARCH.ResumeLayout(false);
            this.panelLANMESS.ResumeLayout(false);
            this.panelTEXTLANMESS.ResumeLayout(false);
            this.panelTEXTLANMESS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLANMESS;
        private System.Windows.Forms.Panel panelSEARCH;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTEXTLANMESS;
        private System.Windows.Forms.Label labelLANMESS;
        private System.Windows.Forms.Panel panelLISTUSER;
        private System.Windows.Forms.Panel panelOPTION;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Avatar;
        private System.Windows.Forms.Panel panelPICTUREOPTION;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelUSERNAME;
        private System.Windows.Forms.Panel panelOPTIONNULL;
        private Guna.UI2.WinForms.Guna2Button ButtonUser;
    }
}

