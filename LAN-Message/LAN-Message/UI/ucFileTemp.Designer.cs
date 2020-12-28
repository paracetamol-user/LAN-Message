namespace UI
{
    partial class ucFileTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFileTemp));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxPictureFile = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureFile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.AutoSize = true;
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.panel2);
            this.panelForm.Controls.Add(this.pictureBoxClose);
            this.panelForm.Controls.Add(this.pictureBoxPictureFile);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(4, 4);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(4);
            this.panelForm.Size = new System.Drawing.Size(172, 33);
            this.panelForm.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(27, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.panel2.Size = new System.Drawing.Size(126, 23);
            this.panel2.TabIndex = 9;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoEllipsis = true;
            this.labelFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFileName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(0, 2);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.labelFileName.Size = new System.Drawing.Size(123, 21);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFileName.UseMnemonic = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(153, 4);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(13, 23);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxPictureFile
            // 
            this.pictureBoxPictureFile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPictureFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPictureFile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPictureFile.Image")));
            this.pictureBoxPictureFile.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxPictureFile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPictureFile.Name = "pictureBoxPictureFile";
            this.pictureBoxPictureFile.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBoxPictureFile.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxPictureFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPictureFile.TabIndex = 3;
            this.pictureBoxPictureFile.TabStop = false;
            // 
            // ucFileTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelForm);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucFileTemp";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(180, 41);
            this.panelForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox pictureBoxPictureFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}
