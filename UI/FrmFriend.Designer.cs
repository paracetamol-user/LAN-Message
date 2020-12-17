namespace UI
{
    partial class FrmFriend
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFriend));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelAll = new System.Windows.Forms.Panel();
			this.btnAll = new System.Windows.Forms.Button();
			this.panelOnline = new System.Windows.Forms.Panel();
			this.btnOnline = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelLine = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelCOUNT = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnOnline = new System.Windows.Forms.Panel();
			this.pnAll = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panelAll.SuspendLayout();
			this.panelOnline.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.panelAll);
			this.panel1.Controls.Add(this.panelOnline);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(604, 43);
			this.panel1.TabIndex = 1;
			// 
			// panelAll
			// 
			this.panelAll.BackColor = System.Drawing.Color.Transparent;
			this.panelAll.Controls.Add(this.btnAll);
			this.panelAll.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelAll.Location = new System.Drawing.Point(179, 0);
			this.panelAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelAll.Name = "panelAll";
			this.panelAll.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
			this.panelAll.Size = new System.Drawing.Size(100, 43);
			this.panelAll.TabIndex = 2;
			// 
			// btnAll
			// 
			this.btnAll.BackColor = System.Drawing.Color.Transparent;
			this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAll.FlatAppearance.BorderSize = 0;
			this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAll.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAll.ForeColor = System.Drawing.Color.DimGray;
			this.btnAll.Location = new System.Drawing.Point(15, 8);
			this.btnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(70, 27);
			this.btnAll.TabIndex = 1;
			this.btnAll.Text = "All";
			this.btnAll.UseVisualStyleBackColor = false;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			this.btnAll.MouseLeave += new System.EventHandler(this.btnAll_MouseLeave);
			this.btnAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAll_MouseMove);
			// 
			// panelOnline
			// 
			this.panelOnline.BackColor = System.Drawing.Color.Transparent;
			this.panelOnline.Controls.Add(this.btnOnline);
			this.panelOnline.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelOnline.Location = new System.Drawing.Point(82, 0);
			this.panelOnline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelOnline.Name = "panelOnline";
			this.panelOnline.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
			this.panelOnline.Size = new System.Drawing.Size(97, 43);
			this.panelOnline.TabIndex = 1;
			// 
			// btnOnline
			// 
			this.btnOnline.BackColor = System.Drawing.Color.Transparent;
			this.btnOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnOnline.FlatAppearance.BorderSize = 0;
			this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOnline.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOnline.ForeColor = System.Drawing.Color.DimGray;
			this.btnOnline.Location = new System.Drawing.Point(15, 8);
			this.btnOnline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnOnline.Name = "btnOnline";
			this.btnOnline.Size = new System.Drawing.Size(67, 27);
			this.btnOnline.TabIndex = 1;
			this.btnOnline.Text = "Online";
			this.btnOnline.UseVisualStyleBackColor = false;
			this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
			this.btnOnline.MouseLeave += new System.EventHandler(this.btnAll_MouseLeave);
			this.btnOnline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAll_MouseMove);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
			this.panel2.Size = new System.Drawing.Size(82, 43);
			this.panel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 8);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 27);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panelLine
			// 
			this.panelLine.BackColor = System.Drawing.Color.Transparent;
			this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLine.Location = new System.Drawing.Point(0, 43);
			this.panelLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelLine.Name = "panelLine";
			this.panelLine.Size = new System.Drawing.Size(604, 1);
			this.panelLine.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.labelCOUNT);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 44);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(23, 5, 0, 0);
			this.panel3.Size = new System.Drawing.Size(604, 29);
			this.panel3.TabIndex = 4;
			// 
			// labelCOUNT
			// 
			this.labelCOUNT.AutoSize = true;
			this.labelCOUNT.BackColor = System.Drawing.Color.Transparent;
			this.labelCOUNT.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelCOUNT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCOUNT.Location = new System.Drawing.Point(23, 5);
			this.labelCOUNT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCOUNT.Name = "labelCOUNT";
			this.labelCOUNT.Size = new System.Drawing.Size(49, 19);
			this.labelCOUNT.TabIndex = 1;
			this.labelCOUNT.Text = "label1";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.pnOnline);
			this.panel4.Controls.Add(this.pnAll);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 73);
			this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
			this.panel4.Size = new System.Drawing.Size(604, 315);
			this.panel4.TabIndex = 7;
			// 
			// pnOnline
			// 
			this.pnOnline.Location = new System.Drawing.Point(265, 178);
			this.pnOnline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnOnline.Name = "pnOnline";
			this.pnOnline.Size = new System.Drawing.Size(226, 134);
			this.pnOnline.TabIndex = 7;
			// 
			// pnAll
			// 
			this.pnAll.Location = new System.Drawing.Point(109, 86);
			this.pnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnAll.Name = "pnAll";
			this.pnAll.Size = new System.Drawing.Size(226, 134);
			this.pnAll.TabIndex = 6;
			// 
			// FrmFriend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(604, 432);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panelLine);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmFriend";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
			this.Text = "FrmFriend";
			this.panel1.ResumeLayout(false);
			this.panelAll.ResumeLayout(false);
			this.panelOnline.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnOnline;
        private System.Windows.Forms.Panel pnAll;
        private System.Windows.Forms.Label labelCOUNT;
    }
}