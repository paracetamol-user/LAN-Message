
namespace UI
{
    partial class ucVoiceMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVoiceMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturePause = new System.Windows.Forms.PictureBox();
            this.picturePlay = new System.Windows.Forms.PictureBox();
            this.picturePlayBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picturePause
            // 
            this.picturePause.BackColor = System.Drawing.Color.Transparent;
            this.picturePause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePause.Dock = System.Windows.Forms.DockStyle.Right;
            this.picturePause.Location = new System.Drawing.Point(237, 2);
            this.picturePause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePause.Name = "picturePause";
            this.picturePause.Size = new System.Drawing.Size(41, 36);
            this.picturePause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePause.TabIndex = 4;
            this.picturePause.TabStop = false;
            this.picturePause.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picturePlay
            // 
            this.picturePlay.BackColor = System.Drawing.Color.Transparent;
            this.picturePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.picturePlay.Location = new System.Drawing.Point(196, 2);
            this.picturePlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePlay.Name = "picturePlay";
            this.picturePlay.Size = new System.Drawing.Size(41, 36);
            this.picturePlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlay.TabIndex = 5;
            this.picturePlay.TabStop = false;
            this.picturePlay.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picturePlayBack
            // 
            this.picturePlayBack.BackColor = System.Drawing.Color.Transparent;
            this.picturePlayBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePlayBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.picturePlayBack.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayBack.Image")));
            this.picturePlayBack.Location = new System.Drawing.Point(155, 2);
            this.picturePlayBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePlayBack.Name = "picturePlayBack";
            this.picturePlayBack.Size = new System.Drawing.Size(41, 36);
            this.picturePlayBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlayBack.TabIndex = 6;
            this.picturePlayBack.TabStop = false;
            this.picturePlayBack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // ucVoiceMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picturePlayBack);
            this.Controls.Add(this.picturePlay);
            this.Controls.Add(this.picturePause);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucVoiceMessage";
            this.Padding = new System.Windows.Forms.Padding(11, 2, 20, 1);
            this.Size = new System.Drawing.Size(298, 39);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picturePause;
        private System.Windows.Forms.PictureBox picturePlay;
        private System.Windows.Forms.PictureBox picturePlayBack;
    }
}
