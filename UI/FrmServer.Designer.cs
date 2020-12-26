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
            this.pnPending = new System.Windows.Forms.Panel();
            this.picPoint = new System.Windows.Forms.PictureBox();
            this.btnPending = new System.Windows.Forms.Button();
            this.panelAll = new System.Windows.Forms.Panel();
            this.btnPeople = new System.Windows.Forms.Button();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.btnOnline = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHeaderName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.pnContainCount = new System.Windows.Forms.Panel();
            this.labelCOUNT = new System.Windows.Forms.Label();
            this.pnContainSearch = new System.Windows.Forms.Panel();
            this.pnContainListSearch = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).BeginInit();
            this.panelAll.SuspendLayout();
            this.panelOnline.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnContainCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pnPending);
            this.panel1.Controls.Add(this.panelAll);
            this.panel1.Controls.Add(this.panelOnline);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 53);
            this.panel1.TabIndex = 0;
            // 
            // pnPending
            // 
            this.pnPending.BackColor = System.Drawing.Color.Transparent;
            this.pnPending.Controls.Add(this.picPoint);
            this.pnPending.Controls.Add(this.btnPending);
            this.pnPending.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPending.Location = new System.Drawing.Point(352, 0);
            this.pnPending.Margin = new System.Windows.Forms.Padding(2);
            this.pnPending.Name = "pnPending";
            this.pnPending.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pnPending.Size = new System.Drawing.Size(123, 53);
            this.pnPending.TabIndex = 4;
            // 
            // picPoint
            // 
            this.picPoint.BackColor = System.Drawing.Color.Transparent;
            this.picPoint.Image = ((System.Drawing.Image)(resources.GetObject("picPoint.Image")));
            this.picPoint.Location = new System.Drawing.Point(95, 10);
            this.picPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPoint.Name = "picPoint";
            this.picPoint.Size = new System.Drawing.Size(20, 33);
            this.picPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoint.TabIndex = 3;
            this.picPoint.TabStop = false;
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.Transparent;
            this.btnPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.Black;
            this.btnPending.Location = new System.Drawing.Point(5, 10);
            this.btnPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(113, 33);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click_1);
            this.btnPending.MouseLeave += new System.EventHandler(this.btnPending_MouseLeave);
            this.btnPending.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPending_MouseMove);
            // 
            // panelAll
            // 
            this.panelAll.BackColor = System.Drawing.Color.Transparent;
            this.panelAll.Controls.Add(this.btnPeople);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAll.Location = new System.Drawing.Point(264, 0);
            this.panelAll.Margin = new System.Windows.Forms.Padding(2);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panelAll.Size = new System.Drawing.Size(88, 53);
            this.panelAll.TabIndex = 2;
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.Black;
            this.btnPeople.Location = new System.Drawing.Point(5, 10);
            this.btnPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(78, 33);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            this.btnPeople.MouseLeave += new System.EventHandler(this.btnPending_MouseLeave);
            this.btnPeople.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPending_MouseMove);
            // 
            // panelOnline
            // 
            this.panelOnline.BackColor = System.Drawing.Color.Transparent;
            this.panelOnline.Controls.Add(this.btnOnline);
            this.panelOnline.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOnline.Location = new System.Drawing.Point(175, 0);
            this.panelOnline.Margin = new System.Windows.Forms.Padding(2);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panelOnline.Size = new System.Drawing.Size(89, 53);
            this.panelOnline.TabIndex = 1;
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.Transparent;
            this.btnOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.Black;
            this.btnOnline.Location = new System.Drawing.Point(5, 10);
            this.btnOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(79, 33);
            this.btnOnline.TabIndex = 1;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            this.btnOnline.MouseLeave += new System.EventHandler(this.btnPending_MouseLeave);
            this.btnOnline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPending_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbHeaderName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.panel2.Size = new System.Drawing.Size(175, 53);
            this.panel2.TabIndex = 0;
            // 
            // lbHeaderName
            // 
            this.lbHeaderName.AutoSize = true;
            this.lbHeaderName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderName.Location = new System.Drawing.Point(72, 10);
            this.lbHeaderName.Name = "lbHeaderName";
            this.lbHeaderName.Size = new System.Drawing.Size(90, 29);
            this.lbHeaderName.TabIndex = 1;
            this.lbHeaderName.Text = "Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 53);
            this.panelLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(781, 1);
            this.panelLine.TabIndex = 2;
            // 
            // pnContainCount
            // 
            this.pnContainCount.BackColor = System.Drawing.Color.Transparent;
            this.pnContainCount.Controls.Add(this.labelCOUNT);
            this.pnContainCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainCount.Location = new System.Drawing.Point(0, 54);
            this.pnContainCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainCount.Name = "pnContainCount";
            this.pnContainCount.Padding = new System.Windows.Forms.Padding(31, 5, 40, 5);
            this.pnContainCount.Size = new System.Drawing.Size(781, 34);
            this.pnContainCount.TabIndex = 3;
            // 
            // labelCOUNT
            // 
            this.labelCOUNT.AutoSize = true;
            this.labelCOUNT.BackColor = System.Drawing.Color.Transparent;
            this.labelCOUNT.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCOUNT.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.labelCOUNT.Location = new System.Drawing.Point(31, 5);
            this.labelCOUNT.Name = "labelCOUNT";
            this.labelCOUNT.Size = new System.Drawing.Size(59, 23);
            this.labelCOUNT.TabIndex = 0;
            this.labelCOUNT.Text = "label1";
            // 
            // pnContainSearch
            // 
            this.pnContainSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainSearch.Location = new System.Drawing.Point(0, 88);
            this.pnContainSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainSearch.Name = "pnContainSearch";
            this.pnContainSearch.Size = new System.Drawing.Size(781, 50);
            this.pnContainSearch.TabIndex = 4;
            this.pnContainSearch.Visible = false;
            // 
            // pnContainListSearch
            // 
            this.pnContainListSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainListSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainListSearch.Location = new System.Drawing.Point(0, 138);
            this.pnContainListSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainListSearch.Name = "pnContainListSearch";
            this.pnContainListSearch.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pnContainListSearch.Size = new System.Drawing.Size(781, 328);
            this.pnContainListSearch.TabIndex = 5;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 466);
            this.Controls.Add(this.pnContainListSearch);
            this.Controls.Add(this.pnContainSearch);
            this.Controls.Add(this.pnContainCount);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServerForm";
            this.Text = "AddFriendForm";
            this.panel1.ResumeLayout(false);
            this.pnPending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).EndInit();
            this.panelAll.ResumeLayout(false);
            this.panelOnline.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnContainCount.ResumeLayout(false);
            this.pnContainCount.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel pnContainCount;
        private System.Windows.Forms.Label labelCOUNT;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Panel pnPending;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.PictureBox picPoint;
        private System.Windows.Forms.Panel pnContainSearch;
        private System.Windows.Forms.Panel pnContainListSearch;
		private System.Windows.Forms.Label lbHeaderName;
	}
}