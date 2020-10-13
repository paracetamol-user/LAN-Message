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
            this.panelListFriend = new System.Windows.Forms.Panel();
            this.iconButtonFriend = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddF = new FontAwesome.Sharp.IconButton();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.pictureBoxAvata = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelChatBox = new System.Windows.Forms.Panel();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvata)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelChatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelListFriend);
            this.panelMenu.Controls.Add(this.iconButtonFriend);
            this.panelMenu.Controls.Add(this.iconButtonAddF);
            this.panelMenu.Controls.Add(this.panelPersonal);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 535);
            this.panelMenu.TabIndex = 1;
            // 
            // panelListFriend
            // 
            this.panelListFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(213)))));
            this.panelListFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListFriend.Location = new System.Drawing.Point(0, 262);
            this.panelListFriend.Name = "panelListFriend";
            this.panelListFriend.Size = new System.Drawing.Size(204, 100);
            this.panelListFriend.TabIndex = 3;
            // 
            // iconButtonFriend
            // 
            this.iconButtonFriend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonFriend.FlatAppearance.BorderSize = 0;
            this.iconButtonFriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.iconButtonFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFriend.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonFriend.IconChar = FontAwesome.Sharp.IconChar.Twitch;
            this.iconButtonFriend.IconColor = System.Drawing.Color.Black;
            this.iconButtonFriend.IconSize = 40;
            this.iconButtonFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFriend.Location = new System.Drawing.Point(0, 220);
            this.iconButtonFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonFriend.Name = "iconButtonFriend";
            this.iconButtonFriend.Rotation = 0D;
            this.iconButtonFriend.Size = new System.Drawing.Size(204, 42);
            this.iconButtonFriend.TabIndex = 2;
            this.iconButtonFriend.Text = "CHAT";
            this.iconButtonFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFriend.UseVisualStyleBackColor = false;
            this.iconButtonFriend.Click += new System.EventHandler(this.iconButtonFriend_Click_1);
            // 
            // iconButtonAddF
            // 
            this.iconButtonAddF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonAddF.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAddF.FlatAppearance.BorderSize = 0;
            this.iconButtonAddF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAddF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddF.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAddF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddF.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonAddF.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddF.IconSize = 40;
            this.iconButtonAddF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddF.Location = new System.Drawing.Point(0, 183);
            this.iconButtonAddF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonAddF.Name = "iconButtonAddF";
            this.iconButtonAddF.Rotation = 0D;
            this.iconButtonAddF.Size = new System.Drawing.Size(204, 37);
            this.iconButtonAddF.TabIndex = 1;
            this.iconButtonAddF.Text = "ADD Friend";
            this.iconButtonAddF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddF.UseVisualStyleBackColor = false;
            this.iconButtonAddF.Click += new System.EventHandler(this.iconButtonAddF_Click);
            // 
            // panelPersonal
            // 
            this.panelPersonal.Controls.Add(this.pictureBoxAvata);
            this.panelPersonal.Controls.Add(this.panel1);
            this.panelPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPersonal.Location = new System.Drawing.Point(0, 0);
            this.panelPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(204, 183);
            this.panelPersonal.TabIndex = 0;
            // 
            // pictureBoxAvata
            // 
            this.pictureBoxAvata.BackColor = System.Drawing.Color.White;
            this.pictureBoxAvata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAvata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAvata.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvata.Image")));
            this.pictureBoxAvata.InitialImage = null;
            this.pictureBoxAvata.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvata.Name = "pictureBoxAvata";
            this.pictureBoxAvata.Size = new System.Drawing.Size(204, 148);
            this.pictureBoxAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvata.TabIndex = 1;
            this.pictureBoxAvata.TabStop = false;
            this.pictureBoxAvata.Click += new System.EventHandler(this.pictureBoxAvata_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 35);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panelInfo);
            this.panelRight.Controls.Add(this.panelChatBox);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(206, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(546, 535);
            this.panelRight.TabIndex = 6;
            // 
            // panelChatBox
            // 
            this.panelChatBox.BackColor = System.Drawing.Color.White;
            this.panelChatBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChatBox.Controls.Add(this.textBoxChat);
            this.panelChatBox.Controls.Add(this.pictureBox4);
            this.panelChatBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChatBox.Location = new System.Drawing.Point(0, 495);
            this.panelChatBox.Name = "panelChatBox";
            this.panelChatBox.Size = new System.Drawing.Size(546, 40);
            this.panelChatBox.TabIndex = 6;
            // 
            // textBoxChat
            // 
            this.textBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxChat.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChat.Location = new System.Drawing.Point(0, 0);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(482, 36);
            this.textBoxChat.TabIndex = 15;
            this.textBoxChat.Text = "Enter Chat";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(482, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.labelFriendName);
            this.panelInfo.Controls.Add(this.pictureBox3);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(546, 50);
            this.panelInfo.TabIndex = 7;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFriendName.Font = new System.Drawing.Font("Yu Gothic UI", 20.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendName.Location = new System.Drawing.Point(59, 0);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(109, 46);
            this.labelFriendName.TabIndex = 4;
            this.labelFriendName.Text = "Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(485, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 535);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(770, 582);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelChatBox.ResumeLayout(false);
            this.panelChatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelListFriend;
        private FontAwesome.Sharp.IconButton iconButtonFriend;
        private FontAwesome.Sharp.IconButton iconButtonAddF;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.PictureBox pictureBoxAvata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelChatBox;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

