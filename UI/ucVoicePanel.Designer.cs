
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
            this.panelSEND = new System.Windows.Forms.Panel();
            this.pictureBoxSend = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRecording = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.panelSEND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecording)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSEND
            // 
            this.panelSEND.BackColor = System.Drawing.Color.Transparent;
            this.panelSEND.Controls.Add(this.pictureBoxSend);
            this.panelSEND.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSEND.Location = new System.Drawing.Point(107, 0);
            this.panelSEND.Margin = new System.Windows.Forms.Padding(4);
            this.panelSEND.Name = "panelSEND";
            this.panelSEND.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelSEND.Size = new System.Drawing.Size(52, 50);
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
            this.pictureBoxSend.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSend.TabIndex = 0;
            this.pictureBoxSend.TabStop = false;
            this.pictureBoxSend.Click += new System.EventHandler(this.pictureBoxSend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxRecording);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(55, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(52, 50);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxRecording
            // 
            this.pictureBoxRecording.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRecording.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRecording.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRecording.Image")));
            this.pictureBoxRecording.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxRecording.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxRecording.Name = "pictureBoxRecording";
            this.pictureBoxRecording.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRecording.TabIndex = 0;
            this.pictureBoxRecording.TabStop = false;
            this.pictureBoxRecording.Click += new System.EventHandler(this.pictureBoxRecording_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBoxStop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(52, 50);
            this.panel2.TabIndex = 8;
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStop.Image")));
            this.pictureBoxStop.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxStop.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStop.TabIndex = 0;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click);
            // 
            // ucVoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSEND);
            this.Name = "ucVoicePanel";
            this.Size = new System.Drawing.Size(159, 50);
            this.panelSEND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecording)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSEND;
        private System.Windows.Forms.PictureBox pictureBoxSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxRecording;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxStop;
    }
}
