namespace UI
{
    partial class ServerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.gunaButtonAll = new Guna.UI2.WinForms.Guna2Button();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.gunaButtonOnline = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.panelOnline.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAll);
            this.panel1.Controls.Add(this.panelOnline);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 57);
            this.panel1.TabIndex = 0;
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.gunaButtonAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAll.Location = new System.Drawing.Point(238, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelAll.Size = new System.Drawing.Size(95, 57);
            this.panelAll.TabIndex = 2;
            // 
            // gunaButtonAll
            // 
            this.gunaButtonAll.CheckedState.Parent = this.gunaButtonAll;
            this.gunaButtonAll.CustomImages.Parent = this.gunaButtonAll;
            this.gunaButtonAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaButtonAll.FillColor = System.Drawing.Color.White;
            this.gunaButtonAll.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.gunaButtonAll.ForeColor = System.Drawing.Color.DimGray;
            this.gunaButtonAll.HoverState.Parent = this.gunaButtonAll;
            this.gunaButtonAll.IndicateFocus = true;
            this.gunaButtonAll.Location = new System.Drawing.Point(20, 10);
            this.gunaButtonAll.Name = "gunaButtonAll";
            this.gunaButtonAll.ShadowDecoration.Parent = this.gunaButtonAll;
            this.gunaButtonAll.Size = new System.Drawing.Size(55, 37);
            this.gunaButtonAll.TabIndex = 1;
            this.gunaButtonAll.Text = "All";
            this.gunaButtonAll.Click += new System.EventHandler(this.gunaButtonAll_Click);
            // 
            // panelOnline
            // 
            this.panelOnline.Controls.Add(this.gunaButtonOnline);
            this.panelOnline.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOnline.Location = new System.Drawing.Point(109, 0);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelOnline.Size = new System.Drawing.Size(129, 57);
            this.panelOnline.TabIndex = 1;
            // 
            // gunaButtonOnline
            // 
            this.gunaButtonOnline.CheckedState.Parent = this.gunaButtonOnline;
            this.gunaButtonOnline.CustomImages.Parent = this.gunaButtonOnline;
            this.gunaButtonOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaButtonOnline.FillColor = System.Drawing.Color.White;
            this.gunaButtonOnline.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonOnline.ForeColor = System.Drawing.Color.DimGray;
            this.gunaButtonOnline.HoverState.Parent = this.gunaButtonOnline;
            this.gunaButtonOnline.IndicateFocus = true;
            this.gunaButtonOnline.Location = new System.Drawing.Point(20, 10);
            this.gunaButtonOnline.Name = "gunaButtonOnline";
            this.gunaButtonOnline.ShadowDecoration.Parent = this.gunaButtonOnline;
            this.gunaButtonOnline.Size = new System.Drawing.Size(89, 37);
            this.gunaButtonOnline.TabIndex = 0;
            this.gunaButtonOnline.Text = "Online";
            this.gunaButtonOnline.Click += new System.EventHandler(this.gunaButtonOnline_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.panel2.Size = new System.Drawing.Size(109, 57);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 1, 0, 0);
            this.panel3.Size = new System.Drawing.Size(693, 38);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServerForm";
            this.Text = "AddFriendForm";
            this.panel1.ResumeLayout(false);
            this.panelAll.ResumeLayout(false);
            this.panelOnline.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelOnline;
        private Guna.UI2.WinForms.Guna2Button gunaButtonOnline;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button gunaButtonAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}