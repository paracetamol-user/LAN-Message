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
            this.pnContainStatus = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.gunaPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnContain.SuspendLayout();
            this.pnContainStatus.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnContainStatus);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel2);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(20, 7);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(415, 54);
            this.pnContain.TabIndex = 5;
            // 
            // pnContainStatus
            // 
            this.pnContainStatus.Controls.Add(this.lbStatus);
            this.pnContainStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainStatus.Location = new System.Drawing.Point(59, 30);
            this.pnContainStatus.Name = "pnContainStatus";
            this.pnContainStatus.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContainStatus.Size = new System.Drawing.Size(337, 24);
            this.pnContainStatus.TabIndex = 3;
            this.pnContainStatus.Click += new System.EventHandler(this.pnContainStatus_Click);
            this.pnContainStatus.MouseLeave += new System.EventHandler(this.pnContainStatus_MouseLeave);
            this.pnContainStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnContainStatus_MouseMove);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbStatus.Location = new System.Drawing.Point(5, 2);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.lbStatus.Size = new System.Drawing.Size(53, 21);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "label2";
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            this.lbStatus.MouseLeave += new System.EventHandler(this.lbStatus_MouseLeave);
            this.lbStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbStatus_MouseMove);
            // 
            // pnContrainName
            // 
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(59, 0);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(337, 30);
            this.pnContrainName.TabIndex = 2;
            this.pnContrainName.Click += new System.EventHandler(this.pnContrainName_Click);
            this.pnContrainName.MouseLeave += new System.EventHandler(this.pnContrainName_MouseLeave);
            this.pnContrainName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnContrainName_MouseMove);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(396, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 54);
            this.panel2.TabIndex = 1;
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(0, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(19, 54);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.Controls.Add(this.gunaPic);
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(0, 0);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3);
            this.pnContainPicture.Size = new System.Drawing.Size(59, 54);
            this.pnContainPicture.TabIndex = 0;
            // 
            // gunaPic
            // 
            this.gunaPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPic.Image = ((System.Drawing.Image)(resources.GetObject("gunaPic.Image")));
            this.gunaPic.Location = new System.Drawing.Point(3, 3);
            this.gunaPic.Name = "gunaPic";
            this.gunaPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaPic.ShadowDecoration.Parent = this.gunaPic;
            this.gunaPic.Size = new System.Drawing.Size(53, 48);
            this.gunaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPic.TabIndex = 0;
            this.gunaPic.TabStop = false;
            this.gunaPic.Click += new System.EventHandler(this.gunaPic_Click);
            this.gunaPic.MouseLeave += new System.EventHandler(this.gunaPic_MouseLeave);
            this.gunaPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseMove);
            // 
            // ucInterac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.pnContain);
            this.Name = "ucInterac";
            this.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.Size = new System.Drawing.Size(455, 68);
            this.Click += new System.EventHandler(this.ucInterac_Click);
            this.MouseLeave += new System.EventHandler(this.ucInterac_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucInterac_MouseMove);
            this.pnContain.ResumeLayout(false);
            this.pnContainStatus.ResumeLayout(false);
            this.pnContainStatus.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).EndInit();
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaPic;
    }
}
