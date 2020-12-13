
namespace UI
{
    partial class ucVoicePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVoicePanel));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSEND = new System.Windows.Forms.Panel();
            this.pictureBoxSend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSEND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panelSEND
            // 
            this.panelSEND.BackColor = System.Drawing.Color.Transparent;
            this.panelSEND.Controls.Add(this.pictureBoxSend);
            this.panelSEND.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSEND.Location = new System.Drawing.Point(1, 0);
            this.panelSEND.Margin = new System.Windows.Forms.Padding(4);
            this.panelSEND.Name = "panelSEND";
            this.panelSEND.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelSEND.Size = new System.Drawing.Size(52, 44);
            this.panelSEND.TabIndex = 6;
            // 
            // pictureBoxSend
            // 
            this.pictureBoxSend.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSend.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSend.Image")));
            this.pictureBoxSend.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxSend.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSend.Name = "pictureBoxSend";
            this.pictureBoxSend.Size = new System.Drawing.Size(38, 32);
            this.pictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSend.TabIndex = 0;
            this.pictureBoxSend.TabStop = false;
            // 
            // ucVoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelSEND);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ucVoicePanel";
            this.Size = new System.Drawing.Size(94, 44);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSEND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSEND;
        private System.Windows.Forms.PictureBox pictureBoxSend;
    }
}
