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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 43);
            this.panel1.TabIndex = 0;
            // 
            // pnPending
            // 
            this.pnPending.BackColor = System.Drawing.Color.Transparent;
            this.pnPending.Controls.Add(this.picPoint);
            this.pnPending.Controls.Add(this.btnPending);
            this.pnPending.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPending.Location = new System.Drawing.Point(279, 0);
            this.pnPending.Margin = new System.Windows.Forms.Padding(2);
            this.pnPending.Name = "pnPending";
            this.pnPending.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.pnPending.Size = new System.Drawing.Size(125, 43);
            this.pnPending.TabIndex = 4;
            // 
            // picPoint
            // 
            this.picPoint.BackColor = System.Drawing.Color.Transparent;
            this.picPoint.Dock = System.Windows.Forms.DockStyle.Right;
            this.picPoint.Image = ((System.Drawing.Image)(resources.GetObject("picPoint.Image")));
            this.picPoint.Location = new System.Drawing.Point(95, 8);
            this.picPoint.Margin = new System.Windows.Forms.Padding(2);
            this.picPoint.Name = "picPoint";
            this.picPoint.Size = new System.Drawing.Size(15, 27);
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
            this.btnPending.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.DimGray;
            this.btnPending.Location = new System.Drawing.Point(15, 8);
            this.btnPending.Margin = new System.Windows.Forms.Padding(2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(95, 27);
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
            this.panelAll.Location = new System.Drawing.Point(179, 0);
            this.panelAll.Margin = new System.Windows.Forms.Padding(2);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.panelAll.Size = new System.Drawing.Size(100, 43);
            this.panelAll.TabIndex = 2;
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.DimGray;
            this.btnPeople.Location = new System.Drawing.Point(15, 8);
            this.btnPeople.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(70, 27);
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
            this.panelOnline.Location = new System.Drawing.Point(82, 0);
            this.panelOnline.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnOnline.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(67, 27);
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 2, 15, 2);
            this.panel2.Size = new System.Drawing.Size(82, 43);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Transparent;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 43);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(781, 1);
            this.panelLine.TabIndex = 2;
            // 
            // pnContainCount
            // 
            this.pnContainCount.BackColor = System.Drawing.Color.Transparent;
            this.pnContainCount.Controls.Add(this.labelCOUNT);
            this.pnContainCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainCount.Location = new System.Drawing.Point(0, 44);
            this.pnContainCount.Margin = new System.Windows.Forms.Padding(2);
            this.pnContainCount.Name = "pnContainCount";
            this.pnContainCount.Padding = new System.Windows.Forms.Padding(30, 5, 40, 5);
            this.pnContainCount.Size = new System.Drawing.Size(781, 23);
            this.pnContainCount.TabIndex = 3;
            // 
            // labelCOUNT
            // 
            this.labelCOUNT.AutoSize = true;
            this.labelCOUNT.BackColor = System.Drawing.Color.Transparent;
            this.labelCOUNT.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCOUNT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOUNT.Location = new System.Drawing.Point(30, 5);
            this.labelCOUNT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCOUNT.Name = "labelCOUNT";
            this.labelCOUNT.Size = new System.Drawing.Size(49, 14);
            this.labelCOUNT.TabIndex = 0;
            this.labelCOUNT.Text = "label1";
            // 
            // pnContainSearch
            // 
            this.pnContainSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainSearch.Location = new System.Drawing.Point(0, 67);
            this.pnContainSearch.Name = "pnContainSearch";
            this.pnContainSearch.Size = new System.Drawing.Size(781, 45);
            this.pnContainSearch.TabIndex = 4;
            this.pnContainSearch.Visible = false;
            // 
            // pnContainListSearch
            // 
            this.pnContainListSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainListSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainListSearch.Location = new System.Drawing.Point(0, 112);
            this.pnContainListSearch.Name = "pnContainListSearch";
            this.pnContainListSearch.Padding = new System.Windows.Forms.Padding(30, 20, 20, 0);
            this.pnContainListSearch.Size = new System.Drawing.Size(781, 355);
            this.pnContainListSearch.TabIndex = 5;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 467);
            this.Controls.Add(this.pnContainListSearch);
            this.Controls.Add(this.pnContainSearch);
            this.Controls.Add(this.pnContainCount);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerForm";
            this.Text = "AddFriendForm";
            this.panel1.ResumeLayout(false);
            this.pnPending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).EndInit();
            this.panelAll.ResumeLayout(false);
            this.panelOnline.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
    }
}