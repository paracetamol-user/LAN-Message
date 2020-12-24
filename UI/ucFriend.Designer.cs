namespace UI
{
    partial class ucFriend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFriend));
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainId = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picmess = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRemove = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.roundPicAvatar = new UI.roundpicturebox();
            this.pnContain.SuspendLayout();
            this.pnContainId.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmess)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainId);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel2);
            this.pnContain.Controls.Add(this.panel1);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Padding = new System.Windows.Forms.Padding(11, 3, 20, 3);
            this.pnContain.Size = new System.Drawing.Size(372, 64);
            this.pnContain.TabIndex = 3;
            this.pnContain.Click += new System.EventHandler(this.pnContainPicture_Click);
            // 
            // pnContainId
            // 
            this.pnContainId.BackColor = System.Drawing.Color.Transparent;
            this.pnContainId.Controls.Add(this.lbId);
            this.pnContainId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContainId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainId.Location = new System.Drawing.Point(67, 33);
            this.pnContainId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainId.Name = "pnContainId";
            this.pnContainId.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContainId.Size = new System.Drawing.Size(221, 25);
            this.pnContainId.TabIndex = 6;
            this.pnContainId.Click += new System.EventHandler(this.pnContainPicture_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.DimGray;
            this.lbId.Location = new System.Drawing.Point(5, 2);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(44, 18);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "label2";
            this.lbId.Click += new System.EventHandler(this.pnContainPicture_Click);
            // 
            // pnContrainName
            // 
            this.pnContrainName.BackColor = System.Drawing.Color.Transparent;
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(67, 3);
            this.pnContrainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(221, 30);
            this.pnContrainName.TabIndex = 5;
            this.pnContrainName.Click += new System.EventHandler(this.pnContainPicture_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.pnContainPicture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picmess);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(288, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 11, 5);
            this.panel2.Size = new System.Drawing.Size(35, 58);
            this.panel2.TabIndex = 4;
            // 
            // picmess
            // 
            this.picmess.BackColor = System.Drawing.Color.Transparent;
            this.picmess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picmess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picmess.Image = ((System.Drawing.Image)(resources.GetObject("picmess.Image")));
            this.picmess.Location = new System.Drawing.Point(0, 5);
            this.picmess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picmess.Name = "picmess";
            this.picmess.Size = new System.Drawing.Size(24, 48);
            this.picmess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmess.TabIndex = 0;
            this.picmess.TabStop = false;
            this.picmess.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picRemove);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(323, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(29, 58);
            this.panel1.TabIndex = 1;
            // 
            // picRemove
            // 
            this.picRemove.BackColor = System.Drawing.Color.Transparent;
            this.picRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRemove.Image = ((System.Drawing.Image)(resources.GetObject("picRemove.Image")));
            this.picRemove.Location = new System.Drawing.Point(11, 5);
            this.picRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRemove.Name = "picRemove";
            this.picRemove.Size = new System.Drawing.Size(18, 48);
            this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRemove.TabIndex = 0;
            this.picRemove.TabStop = false;
            this.picRemove.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.BackColor = System.Drawing.Color.Transparent;
            this.pnContainPicture.Controls.Add(this.roundPicAvatar);
            this.pnContainPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(11, 3);
            this.pnContainPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContainPicture.Size = new System.Drawing.Size(56, 58);
            this.pnContainPicture.TabIndex = 0;
            this.pnContainPicture.Click += new System.EventHandler(this.pnContainPicture_Click);
            // 
            // roundPicAvatar
            // 
            this.roundPicAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.roundPicAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPicAvatar.Location = new System.Drawing.Point(3, 4);
            this.roundPicAvatar.Name = "roundPicAvatar";
            this.roundPicAvatar.Size = new System.Drawing.Size(50, 50);
            this.roundPicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicAvatar.TabIndex = 1;
            this.roundPicAvatar.TabStop = false;
            // 
            // ucFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucFriend";
            this.Size = new System.Drawing.Size(372, 64);
            this.pnContain.ResumeLayout(false);
            this.pnContainId.ResumeLayout(false);
            this.pnContainId.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picmess)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picmess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picRemove;
        private System.Windows.Forms.Panel pnContainPicture;
		private roundpicturebox roundPicAvatar;
	}
}
