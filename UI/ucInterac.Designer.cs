namespace UI
{
    partial class ucInterac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInterac));
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainMess = new System.Windows.Forms.Panel();
            this.lbMess = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.picStatus = new UI.roundpicturebox();
            this.roundPicAvatar = new UI.roundpicturebox();
            this.pnContain.SuspendLayout();
            this.pnContainMess.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainMess);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel2);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(20, 5);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(428, 50);
            this.pnContain.TabIndex = 5;
            this.pnContain.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // pnContainMess
            // 
            this.pnContainMess.BackColor = System.Drawing.Color.Transparent;
            this.pnContainMess.Controls.Add(this.lbMess);
            this.pnContainMess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContainMess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainMess.Location = new System.Drawing.Point(56, 23);
            this.pnContainMess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContainMess.Name = "pnContainMess";
            this.pnContainMess.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnContainMess.Size = new System.Drawing.Size(357, 27);
            this.pnContainMess.TabIndex = 3;
            this.pnContainMess.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lbMess
            // 
            this.lbMess.AutoEllipsis = true;
            this.lbMess.BackColor = System.Drawing.Color.Transparent;
            this.lbMess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbMess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMess.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess.ForeColor = System.Drawing.Color.DimGray;
            this.lbMess.Location = new System.Drawing.Point(5, 0);
            this.lbMess.Name = "lbMess";
            this.lbMess.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.lbMess.Size = new System.Drawing.Size(352, 27);
            this.lbMess.TabIndex = 0;
            this.lbMess.Text = "mess";
            this.lbMess.Visible = false;
            this.lbMess.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // pnContrainName
            // 
            this.pnContrainName.BackColor = System.Drawing.Color.Transparent;
            this.pnContrainName.Controls.Add(this.lbStatus);
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(56, 0);
            this.pnContrainName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(357, 23);
            this.pnContrainName.TabIndex = 2;
            this.pnContrainName.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbStatus.Location = new System.Drawing.Point(73, 1);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.lbStatus.Size = new System.Drawing.Size(42, 18);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "status";
            this.lbStatus.Visible = false;
            this.lbStatus.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(413, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 50);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(0, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 50);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.BackColor = System.Drawing.Color.Transparent;
            this.pnContainPicture.Controls.Add(this.picStatus);
            this.pnContainPicture.Controls.Add(this.roundPicAvatar);
            this.pnContainPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(0, 0);
            this.pnContainPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnContainPicture.Size = new System.Drawing.Size(56, 50);
            this.pnContainPicture.TabIndex = 0;
            this.pnContainPicture.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // picStatus
            // 
            this.picStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.picStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picStatus.Location = new System.Drawing.Point(38, 32);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(15, 15);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatus.TabIndex = 5;
            this.picStatus.TabStop = false;
            // 
            // roundPicAvatar
            // 
            this.roundPicAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundPicAvatar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roundPicAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPicAvatar.Location = new System.Drawing.Point(3, 0);
            this.roundPicAvatar.Name = "roundPicAvatar";
            this.roundPicAvatar.Size = new System.Drawing.Size(50, 50);
            this.roundPicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicAvatar.TabIndex = 3;
            this.roundPicAvatar.TabStop = false;
            // 
            // ucInterac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucInterac";
            this.Padding = new System.Windows.Forms.Padding(20, 5, 11, 5);
            this.Size = new System.Drawing.Size(459, 60);
            this.pnContain.ResumeLayout(false);
            this.pnContainMess.ResumeLayout(false);
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainMess;
        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel pnContainPicture;
        private System.Windows.Forms.Label lbStatus;
		private roundpicturebox roundPicAvatar;
		private roundpicturebox picStatus;
	}
}
