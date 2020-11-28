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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnContainStatus = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).BeginInit();
            this.pnContrainName.SuspendLayout();
            this.pnContainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 61);
            this.panel1.TabIndex = 0;
            // 
            // gunaPic
            // 
            this.gunaPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPic.Image = ((System.Drawing.Image)(resources.GetObject("gunaPic.Image")));
            this.gunaPic.Location = new System.Drawing.Point(0, 0);
            this.gunaPic.Name = "gunaPic";
            this.gunaPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaPic.ShadowDecoration.Parent = this.gunaPic;
            this.gunaPic.Size = new System.Drawing.Size(57, 61);
            this.gunaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPic.TabIndex = 0;
            this.gunaPic.TabStop = false;
            this.gunaPic.Click += new System.EventHandler(this.gunaPic_Click);
            this.gunaPic.MouseLeave += new System.EventHandler(this.gunaPic_MouseLeave);
            this.gunaPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseMove);
            // 
            // pnContrainName
            // 
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(77, 5);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(366, 32);
            this.pnContrainName.TabIndex = 1;
            this.pnContrainName.Click += new System.EventHandler(this.pnContrainName_Click);
            this.pnContrainName.MouseLeave += new System.EventHandler(this.pnContrainName_MouseLeave);
            this.pnContrainName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnContrainName_MouseMove);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseMove);
            // 
            // pnContainStatus
            // 
            this.pnContainStatus.Controls.Add(this.lbStatus);
            this.pnContainStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainStatus.Location = new System.Drawing.Point(77, 37);
            this.pnContainStatus.Name = "pnContainStatus";
            this.pnContainStatus.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.pnContainStatus.Size = new System.Drawing.Size(366, 23);
            this.pnContainStatus.TabIndex = 2;
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
            this.lbStatus.Location = new System.Drawing.Point(5, 3);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 20);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "label2";
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            this.lbStatus.MouseLeave += new System.EventHandler(this.lbStatus_MouseLeave);
            this.lbStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbStatus_MouseMove);
            // 
            // ucInterac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.pnContainStatus);
            this.Controls.Add(this.pnContrainName);
            this.Controls.Add(this.panel1);
            this.Name = "ucInterac";
            this.Padding = new System.Windows.Forms.Padding(20, 5, 10, 3);
            this.Size = new System.Drawing.Size(453, 69);
            this.Click += new System.EventHandler(this.ucInterac_Click);
            this.MouseLeave += new System.EventHandler(this.ucInterac_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucInterac_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).EndInit();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.pnContainStatus.ResumeLayout(false);
            this.pnContainStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaPic;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Panel pnContainStatus;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStatus;
    }
}
