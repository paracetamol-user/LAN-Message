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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelListGroup = new System.Windows.Forms.Panel();
            this.butgroup = new System.Windows.Forms.Button();
            this.panelListFriend = new System.Windows.Forms.Panel();
            this.butfriend = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.panelPresonal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInfoFriend = new System.Windows.Forms.Panel();
            this.panelMess = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.panelInfoChat = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelPresonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMess.SuspendLayout();
            this.panelChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panelListGroup);
            this.panel1.Controls.Add(this.butgroup);
            this.panel1.Controls.Add(this.panelListFriend);
            this.panel1.Controls.Add(this.butfriend);
            this.panel1.Controls.Add(this.butadd);
            this.panel1.Controls.Add(this.panelPresonal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 611);
            this.panel1.TabIndex = 0;
            // 
            // panelListGroup
            // 
            this.panelListGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.panelListGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListGroup.Location = new System.Drawing.Point(0, 438);
            this.panelListGroup.Name = "panelListGroup";
            this.panelListGroup.Size = new System.Drawing.Size(200, 173);
            this.panelListGroup.TabIndex = 5;
            // 
            // butgroup
            // 
            this.butgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.butgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.butgroup.FlatAppearance.BorderSize = 0;
            this.butgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butgroup.ForeColor = System.Drawing.Color.White;
            this.butgroup.Location = new System.Drawing.Point(0, 398);
            this.butgroup.Name = "butgroup";
            this.butgroup.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butgroup.Size = new System.Drawing.Size(200, 40);
            this.butgroup.TabIndex = 4;
            this.butgroup.Text = "GROUP";
            this.butgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butgroup.UseVisualStyleBackColor = false;
            this.butgroup.Click += new System.EventHandler(this.butgroup_Click);
            // 
            // panelListFriend
            // 
            this.panelListFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.panelListFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListFriend.Location = new System.Drawing.Point(0, 218);
            this.panelListFriend.Name = "panelListFriend";
            this.panelListFriend.Size = new System.Drawing.Size(200, 180);
            this.panelListFriend.TabIndex = 3;
            // 
            // butfriend
            // 
            this.butfriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.butfriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.butfriend.FlatAppearance.BorderSize = 0;
            this.butfriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butfriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butfriend.ForeColor = System.Drawing.Color.White;
            this.butfriend.Location = new System.Drawing.Point(0, 178);
            this.butfriend.Name = "butfriend";
            this.butfriend.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butfriend.Size = new System.Drawing.Size(200, 40);
            this.butfriend.TabIndex = 2;
            this.butfriend.Text = "FRIEND";
            this.butfriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butfriend.UseVisualStyleBackColor = false;
            this.butfriend.Click += new System.EventHandler(this.butfriend_Click);
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.butadd.Dock = System.Windows.Forms.DockStyle.Top;
            this.butadd.FlatAppearance.BorderSize = 0;
            this.butadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.ForeColor = System.Drawing.Color.White;
            this.butadd.Location = new System.Drawing.Point(0, 138);
            this.butadd.Name = "butadd";
            this.butadd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butadd.Size = new System.Drawing.Size(200, 40);
            this.butadd.TabIndex = 1;
            this.butadd.Text = "ADD FRIEND";
            this.butadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // panelPresonal
            // 
            this.panelPresonal.BackColor = System.Drawing.Color.Gray;
            this.panelPresonal.Controls.Add(this.label1);
            this.panelPresonal.Controls.Add(this.labelIP);
            this.panelPresonal.Controls.Add(this.pictureBox1);
            this.panelPresonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPresonal.Location = new System.Drawing.Point(0, 0);
            this.panelPresonal.Name = "panelPresonal";
            this.panelPresonal.Size = new System.Drawing.Size(200, 138);
            this.panelPresonal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: User 1";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.BackColor = System.Drawing.Color.Gray;
            this.labelIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIP.Location = new System.Drawing.Point(0, 89);
            this.labelIP.Name = "labelIP";
            this.labelIP.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.labelIP.Size = new System.Drawing.Size(167, 16);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "IP: 192.168.1.200";
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::UI.Properties.Resources.avatar_den_dep_2_015639673;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelInfoFriend
            // 
            this.panelInfoFriend.BackColor = System.Drawing.Color.LightGray;
            this.panelInfoFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoFriend.ForeColor = System.Drawing.SystemColors.Control;
            this.panelInfoFriend.Location = new System.Drawing.Point(200, 0);
            this.panelInfoFriend.Name = "panelInfoFriend";
            this.panelInfoFriend.Size = new System.Drawing.Size(534, 60);
            this.panelInfoFriend.TabIndex = 3;
            // 
            // panelMess
            // 
            this.panelMess.BackColor = System.Drawing.Color.Transparent;
            this.panelMess.Controls.Add(this.panelChat);
            this.panelMess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMess.Location = new System.Drawing.Point(200, 60);
            this.panelMess.Name = "panelMess";
            this.panelMess.Size = new System.Drawing.Size(534, 551);
            this.panelMess.TabIndex = 5;
            // 
            // panelChat
            // 
            this.panelChat.Controls.Add(this.textBoxChat);
            this.panelChat.Controls.Add(this.butSend);
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChat.Location = new System.Drawing.Point(0, 451);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(534, 100);
            this.panelChat.TabIndex = 0;
            // 
            // textBoxChat
            // 
            this.textBoxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChat.Location = new System.Drawing.Point(0, 0);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(459, 100);
            this.textBoxChat.TabIndex = 1;
            // 
            // butSend
            // 
            this.butSend.BackColor = System.Drawing.Color.White;
            this.butSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.butSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSend.ForeColor = System.Drawing.Color.DimGray;
            this.butSend.Location = new System.Drawing.Point(459, 0);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 100);
            this.butSend.TabIndex = 0;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = false;
            // 
            // panelInfoChat
            // 
            this.panelInfoChat.BackColor = System.Drawing.Color.Gray;
            this.panelInfoChat.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfoChat.Location = new System.Drawing.Point(734, 0);
            this.panelInfoChat.Name = "panelInfoChat";
            this.panelInfoChat.Size = new System.Drawing.Size(200, 611);
            this.panelInfoChat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panelMess);
            this.Controls.Add(this.panelInfoFriend);
            this.Controls.Add(this.panelInfoChat);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelPresonal.ResumeLayout(false);
            this.panelPresonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMess.ResumeLayout(false);
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPresonal;
        private System.Windows.Forms.Panel panelInfoFriend;
        private System.Windows.Forms.Panel panelListFriend;
        private System.Windows.Forms.Button butfriend;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Panel panelMess;
        private System.Windows.Forms.Panel panelListGroup;
        private System.Windows.Forms.Button butgroup;
        private System.Windows.Forms.Panel panelInfoChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button butSend;
    }
}

