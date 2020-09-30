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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChatBox = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvata)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChatBox.SuspendLayout();
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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 35);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
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
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.iconButton4);
            this.panelInfo.Controls.Add(this.labelFriendName);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(546, 50);
            this.panelInfo.TabIndex = 4;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(486, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(58, 48);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendName.Location = new System.Drawing.Point(57, 13);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(124, 22);
            this.labelFriendName.TabIndex = 1;
            this.labelFriendName.Text = "Name Friend";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChatBox
            // 
            this.panelChatBox.BackColor = System.Drawing.Color.White;
            this.panelChatBox.Controls.Add(this.textBox2);
            this.panelChatBox.Controls.Add(this.iconButton1);
            this.panelChatBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChatBox.Location = new System.Drawing.Point(0, 500);
            this.panelChatBox.Name = "panelChatBox";
            this.panelChatBox.Size = new System.Drawing.Size(546, 35);
            this.panelChatBox.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SmileWink;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(487, 0);
            this.iconButton1.MaximumSize = new System.Drawing.Size(59, 35);
            this.iconButton1.MinimumSize = new System.Drawing.Size(59, 35);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(59, 35);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(487, 35);
            this.textBox2.TabIndex = 13;
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
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChatBox.ResumeLayout(false);
            this.panelChatBox.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelInfo;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelChatBox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

