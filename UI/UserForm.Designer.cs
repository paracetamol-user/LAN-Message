namespace UI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.listViewCHAT = new System.Windows.Forms.ListView();
            this.panelENTERCHAT = new System.Windows.Forms.Panel();
            this.panelCHATBOX = new System.Windows.Forms.Panel();
            this.TextBoxEnterChat = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelENTERCHATOPTION = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSEND = new System.Windows.Forms.Panel();
            this.pictureBoxSend = new System.Windows.Forms.PictureBox();
            this.panelUSERINFO = new System.Windows.Forms.Panel();
            this.panelNULL2 = new System.Windows.Forms.Panel();
            this.panelOPTIONUSER = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelUSERCHATINFO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelENTERCHAT.SuspendLayout();
            this.panelCHATBOX.SuspendLayout();
            this.panelENTERCHATOPTION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSEND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).BeginInit();
            this.panelUSERINFO.SuspendLayout();
            this.panelOPTIONUSER.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.panelUSERCHATINFO.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCHAT
            // 
            this.listViewCHAT.AllowColumnReorder = true;
            this.listViewCHAT.AllowDrop = true;
            this.listViewCHAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCHAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCHAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCHAT.GridLines = true;
            this.listViewCHAT.HideSelection = false;
            this.listViewCHAT.Location = new System.Drawing.Point(0, 50);
            this.listViewCHAT.Margin = new System.Windows.Forms.Padding(20);
            this.listViewCHAT.Name = "listViewCHAT";
            this.listViewCHAT.Size = new System.Drawing.Size(419, 342);
            this.listViewCHAT.TabIndex = 6;
            this.listViewCHAT.UseCompatibleStateImageBehavior = false;
            this.listViewCHAT.View = System.Windows.Forms.View.Tile;
            // 
            // panelENTERCHAT
            // 
            this.panelENTERCHAT.Controls.Add(this.panelCHATBOX);
            this.panelENTERCHAT.Controls.Add(this.panelENTERCHATOPTION);
            this.panelENTERCHAT.Controls.Add(this.panelSEND);
            this.panelENTERCHAT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelENTERCHAT.Location = new System.Drawing.Point(0, 392);
            this.panelENTERCHAT.Name = "panelENTERCHAT";
            this.panelENTERCHAT.Padding = new System.Windows.Forms.Padding(7);
            this.panelENTERCHAT.Size = new System.Drawing.Size(419, 56);
            this.panelENTERCHAT.TabIndex = 5;
            // 
            // panelCHATBOX
            // 
            this.panelCHATBOX.Controls.Add(this.TextBoxEnterChat);
            this.panelCHATBOX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCHATBOX.Location = new System.Drawing.Point(48, 7);
            this.panelCHATBOX.Name = "panelCHATBOX";
            this.panelCHATBOX.Padding = new System.Windows.Forms.Padding(5);
            this.panelCHATBOX.Size = new System.Drawing.Size(325, 42);
            this.panelCHATBOX.TabIndex = 2;
            // 
            // TextBoxEnterChat
            // 
            this.TextBoxEnterChat.AutoRoundedCorners = true;
            this.TextBoxEnterChat.BorderRadius = 15;
            this.TextBoxEnterChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEnterChat.DefaultText = "";
            this.TextBoxEnterChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxEnterChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxEnterChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEnterChat.DisabledState.Parent = this.TextBoxEnterChat;
            this.TextBoxEnterChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEnterChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxEnterChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEnterChat.FocusedState.Parent = this.TextBoxEnterChat;
            this.TextBoxEnterChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxEnterChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEnterChat.HoverState.Parent = this.TextBoxEnterChat;
            this.TextBoxEnterChat.Location = new System.Drawing.Point(5, 5);
            this.TextBoxEnterChat.Name = "TextBoxEnterChat";
            this.TextBoxEnterChat.PasswordChar = '\0';
            this.TextBoxEnterChat.PlaceholderText = "";
            this.TextBoxEnterChat.SelectedText = "";
            this.TextBoxEnterChat.ShadowDecoration.Parent = this.TextBoxEnterChat;
            this.TextBoxEnterChat.Size = new System.Drawing.Size(315, 32);
            this.TextBoxEnterChat.TabIndex = 0;
            this.TextBoxEnterChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEnterChat_KeyPress);
            // 
            // panelENTERCHATOPTION
            // 
            this.panelENTERCHATOPTION.Controls.Add(this.pictureBox1);
            this.panelENTERCHATOPTION.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelENTERCHATOPTION.Location = new System.Drawing.Point(7, 7);
            this.panelENTERCHATOPTION.Name = "panelENTERCHATOPTION";
            this.panelENTERCHATOPTION.Padding = new System.Windows.Forms.Padding(7);
            this.panelENTERCHATOPTION.Size = new System.Drawing.Size(41, 42);
            this.panelENTERCHATOPTION.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSEND
            // 
            this.panelSEND.Controls.Add(this.pictureBoxSend);
            this.panelSEND.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSEND.Location = new System.Drawing.Point(373, 7);
            this.panelSEND.Name = "panelSEND";
            this.panelSEND.Padding = new System.Windows.Forms.Padding(5);
            this.panelSEND.Size = new System.Drawing.Size(39, 42);
            this.panelSEND.TabIndex = 0;
            // 
            // pictureBoxSend
            // 
            this.pictureBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSend.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSend.Image")));
            this.pictureBoxSend.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxSend.Name = "pictureBoxSend";
            this.pictureBoxSend.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSend.TabIndex = 0;
            this.pictureBoxSend.TabStop = false;
            // 
            // panelUSERINFO
            // 
            this.panelUSERINFO.BackColor = System.Drawing.Color.White;
            this.panelUSERINFO.Controls.Add(this.panelNULL2);
            this.panelUSERINFO.Controls.Add(this.panelOPTIONUSER);
            this.panelUSERINFO.Controls.Add(this.panelUSERCHATINFO);
            this.panelUSERINFO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUSERINFO.Location = new System.Drawing.Point(0, 0);
            this.panelUSERINFO.Name = "panelUSERINFO";
            this.panelUSERINFO.Size = new System.Drawing.Size(419, 50);
            this.panelUSERINFO.TabIndex = 4;
            // 
            // panelNULL2
            // 
            this.panelNULL2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNULL2.Location = new System.Drawing.Point(182, 0);
            this.panelNULL2.Name = "panelNULL2";
            this.panelNULL2.Padding = new System.Windows.Forms.Padding(7);
            this.panelNULL2.Size = new System.Drawing.Size(91, 50);
            this.panelNULL2.TabIndex = 2;
            // 
            // panelOPTIONUSER
            // 
            this.panelOPTIONUSER.Controls.Add(this.panelSearch);
            this.panelOPTIONUSER.Controls.Add(this.panelMenu);
            this.panelOPTIONUSER.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOPTIONUSER.Location = new System.Drawing.Point(290, 0);
            this.panelOPTIONUSER.Name = "panelOPTIONUSER";
            this.panelOPTIONUSER.Padding = new System.Windows.Forms.Padding(7, 10, 30, 10);
            this.panelOPTIONUSER.Size = new System.Drawing.Size(129, 50);
            this.panelOPTIONUSER.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.pictureBoxSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearch.Location = new System.Drawing.Point(21, 10);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(7);
            this.panelSearch.Size = new System.Drawing.Size(39, 30);
            this.panelSearch.TabIndex = 1;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(25, 16);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 0;
            this.pictureBoxSearch.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.pictureBoxMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(60, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(7);
            this.panelMenu.Size = new System.Drawing.Size(39, 30);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMenu.Image = global::UI.Properties.Resources.menu__1_1;
            this.pictureBoxMenu.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(25, 16);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            // 
            // panelUSERCHATINFO
            // 
            this.panelUSERCHATINFO.Controls.Add(this.panel1);
            this.panelUSERCHATINFO.Controls.Add(this.guna2CirclePictureBox1);
            this.panelUSERCHATINFO.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUSERCHATINFO.Location = new System.Drawing.Point(0, 0);
            this.panelUSERCHATINFO.Name = "panelUSERCHATINFO";
            this.panelUSERCHATINFO.Padding = new System.Windows.Forms.Padding(12, 7, 0, 7);
            this.panelUSERCHATINFO.Size = new System.Drawing.Size(182, 50);
            this.panelUSERCHATINFO.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(48, 7);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panel1.Size = new System.Drawing.Size(134, 36);
            this.panel1.TabIndex = 3;
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "User Name";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(36, 36);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 448);
            this.Controls.Add(this.listViewCHAT);
            this.Controls.Add(this.panelENTERCHAT);
            this.Controls.Add(this.panelUSERINFO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(419, 448);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panelENTERCHAT.ResumeLayout(false);
            this.panelCHATBOX.ResumeLayout(false);
            this.panelENTERCHATOPTION.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSEND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).EndInit();
            this.panelUSERINFO.ResumeLayout(false);
            this.panelOPTIONUSER.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.panelUSERCHATINFO.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCHAT;
        private System.Windows.Forms.Panel panelENTERCHAT;
        private System.Windows.Forms.Panel panelCHATBOX;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEnterChat;
        private System.Windows.Forms.Panel panelENTERCHATOPTION;
        private System.Windows.Forms.Panel panelSEND;
        private System.Windows.Forms.PictureBox pictureBoxSend;
        private System.Windows.Forms.Panel panelUSERINFO;
        private System.Windows.Forms.Panel panelNULL2;
        private System.Windows.Forms.Panel panelOPTIONUSER;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelUSERCHATINFO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}