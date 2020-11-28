namespace UI
{
    partial class ucUserOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserOnline));
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainId = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.gunaPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnContain.SuspendLayout();
            this.pnContainId.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnContainId);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel1);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(10, 1);
            this.pnContain.Name = "pnContain";
            this.pnContain.Padding = new System.Windows.Forms.Padding(10, 7, 20, 7);
            this.pnContain.Size = new System.Drawing.Size(452, 69);
            this.pnContain.TabIndex = 3;
            this.pnContain.Click += new System.EventHandler(this.pnContain_Click);
            this.pnContain.MouseLeave += new System.EventHandler(this.pnContain_MouseLeave);
            this.pnContain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnContain_MouseMove);
            // 
            // pnContainId
            // 
            this.pnContainId.Controls.Add(this.lbId);
            this.pnContainId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainId.Location = new System.Drawing.Point(69, 36);
            this.pnContainId.Name = "pnContainId";
            this.pnContainId.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.pnContainId.Size = new System.Drawing.Size(336, 24);
            this.pnContainId.TabIndex = 3;
            this.pnContainId.Click += new System.EventHandler(this.pnContainId_Click);
            this.pnContainId.MouseLeave += new System.EventHandler(this.pnContainId_MouseLeave);
            this.pnContainId.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnContainId_MouseMove);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.DimGray;
            this.lbId.Location = new System.Drawing.Point(5, 3);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(68, 25);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "label2";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            this.lbId.MouseLeave += new System.EventHandler(this.lbId_MouseLeave);
            this.lbId.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbId_MouseMove);
            // 
            // pnContrainName
            // 
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(69, 7);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(336, 29);
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
            this.lbName.Location = new System.Drawing.Point(5, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(87, 32);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(405, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 55);
            this.panel1.TabIndex = 1;
            // 
            // picMenu
            // 
            this.picMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(0, 0);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(27, 55);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMenu_MouseMove);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.Controls.Add(this.gunaPic);
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(10, 7);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3);
            this.pnContainPicture.Size = new System.Drawing.Size(59, 55);
            this.pnContainPicture.TabIndex = 0;
            this.pnContainPicture.MouseLeave += new System.EventHandler(this.pnContainPicture_MouseLeave);
            // 
            // gunaPic
            // 
            this.gunaPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPic.Image = ((System.Drawing.Image)(resources.GetObject("gunaPic.Image")));
            this.gunaPic.Location = new System.Drawing.Point(3, 3);
            this.gunaPic.Name = "gunaPic";
            this.gunaPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaPic.ShadowDecoration.Parent = this.gunaPic;
            this.gunaPic.Size = new System.Drawing.Size(53, 49);
            this.gunaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPic.TabIndex = 0;
            this.gunaPic.TabStop = false;
            this.gunaPic.Click += new System.EventHandler(this.gunaPic_Click);
            this.gunaPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseMove);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.ForeColor = System.Drawing.Color.Black;
            this.pnLine.Location = new System.Drawing.Point(10, 0);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(452, 1);
            this.pnLine.TabIndex = 2;
            // 
            // ucUserOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Controls.Add(this.pnLine);
            this.Name = "ucUserOnline";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.Size = new System.Drawing.Size(492, 70);
            this.Click += new System.EventHandler(this.ucUserOnline_Click);
            this.MouseLeave += new System.EventHandler(this.ucUserOnline_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucUserOnline_MouseMove);
            this.pnContain.ResumeLayout(false);
            this.pnContainId.ResumeLayout(false);
            this.pnContainId.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Panel pnContainPicture;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaPic;
        private System.Windows.Forms.Panel pnLine;
    }
}
