
namespace UI
{
    partial class ucGroupInteract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGroupInteract));
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainStatus = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.roundPicAvatar = new UI.roundpicturebox();
            this.pnContain.SuspendLayout();
            this.pnContainStatus.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnContainStatus);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel2);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(20, 7);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(415, 54);
            this.pnContain.TabIndex = 6;
            this.pnContain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // pnContainStatus
            // 
            this.pnContainStatus.Controls.Add(this.lbStatus);
            this.pnContainStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContainStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainStatus.Location = new System.Drawing.Point(56, 30);
            this.pnContainStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainStatus.Name = "pnContainStatus";
            this.pnContainStatus.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContainStatus.Size = new System.Drawing.Size(340, 24);
            this.pnContainStatus.TabIndex = 3;
            this.pnContainStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbStatus.Location = new System.Drawing.Point(5, 2);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.lbStatus.Size = new System.Drawing.Size(44, 19);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "label2";
            this.lbStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // pnContrainName
            // 
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(56, 0);
            this.pnContrainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(340, 30);
            this.pnContrainName.TabIndex = 2;
            this.pnContrainName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(396, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 54);
            this.panel2.TabIndex = 1;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picClose.Location = new System.Drawing.Point(0, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(19, 54);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.Controls.Add(this.roundPicAvatar);
            this.pnContainPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(0, 0);
            this.pnContainPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainPicture.Size = new System.Drawing.Size(56, 54);
            this.pnContainPicture.TabIndex = 0;
            this.pnContainPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // roundPicAvatar
            // 
            this.roundPicAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundPicAvatar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roundPicAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPicAvatar.Location = new System.Drawing.Point(3, 2);
            this.roundPicAvatar.Name = "roundPicAvatar";
            this.roundPicAvatar.Size = new System.Drawing.Size(50, 50);
            this.roundPicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicAvatar.TabIndex = 1;
            this.roundPicAvatar.TabStop = false;
            // 
            // ucGroupInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucGroupInteract";
            this.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.Size = new System.Drawing.Size(455, 68);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            this.MouseLeave += new System.EventHandler(this.ucGroupInteract_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucGroupInteract_MouseMove);
            this.pnContain.ResumeLayout(false);
            this.pnContainStatus.ResumeLayout(false);
            this.pnContainStatus.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel pnContainPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
		private roundpicturebox roundPicAvatar;
	}
}
