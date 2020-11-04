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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelListFriend.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvata)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(155, 441);
            this.panelMenu.TabIndex = 1;
            // 
            // panelListFriend
            // 
            this.panelListFriend.AutoScroll = true;
            this.panelListFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(213)))));
            this.panelListFriend.Controls.Add(this.button3);
            this.panelListFriend.Controls.Add(this.button1);
            this.panelListFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListFriend.Location = new System.Drawing.Point(0, 213);
            this.panelListFriend.Margin = new System.Windows.Forms.Padding(2);
            this.panelListFriend.Name = "panelListFriend";
            this.panelListFriend.Size = new System.Drawing.Size(153, 182);
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
            this.iconButtonFriend.Location = new System.Drawing.Point(0, 179);
            this.iconButtonFriend.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonFriend.Name = "iconButtonFriend";
            this.iconButtonFriend.Rotation = 0D;
            this.iconButtonFriend.Size = new System.Drawing.Size(153, 34);
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
            this.iconButtonAddF.Location = new System.Drawing.Point(0, 149);
            this.iconButtonAddF.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonAddF.Name = "iconButtonAddF";
            this.iconButtonAddF.Rotation = 0D;
            this.iconButtonAddF.Size = new System.Drawing.Size(153, 30);
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
            this.panelPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(153, 149);
            this.panelPersonal.TabIndex = 0;
            // 
            // pictureBoxAvata
            // 
            this.pictureBoxAvata.BackColor = System.Drawing.Color.White;
            this.pictureBoxAvata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAvata.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvata.Image")));
            this.pictureBoxAvata.InitialImage = null;
            this.pictureBoxAvata.Location = new System.Drawing.Point(20, 24);
            this.pictureBoxAvata.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAvata.Name = "pictureBoxAvata";
            this.pictureBoxAvata.Size = new System.Drawing.Size(119, 66);
            this.pictureBoxAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvata.TabIndex = 1;
            this.pictureBoxAvata.TabStop = false;
            this.pictureBoxAvata.Click += new System.EventHandler(this.pictureBoxAvata_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.pictureBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 29);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(118, 27);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.Text = "|";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(118, 0);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(33, 27);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 4;
            this.pictureBoxSearch.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Controls.Add(this.listView1);
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Location = new System.Drawing.Point(189, 27);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(366, 342);
            this.panelRight.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 49);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 100);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 62);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 441);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(582, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.panelListFriend.ResumeLayout(false);
            this.panelPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

