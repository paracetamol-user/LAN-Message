namespace Server
{
    partial class ServerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnM = new System.Windows.Forms.Panel();
            this.pnM__Header = new System.Windows.Forms.Panel();
            this.pnM__Header__Info = new System.Windows.Forms.Panel();
            this.btnInfomation = new System.Windows.Forms.Button();
            this.pnM__Header__Console = new System.Windows.Forms.Panel();
            this.btnConsole = new System.Windows.Forms.Button();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLine2 = new System.Windows.Forms.Panel();
            this.pnM__Contain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxConsole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnM.SuspendLayout();
            this.pnM__Header.SuspendLayout();
            this.pnM__Header__Info.SuspendLayout();
            this.pnM__Header__Console.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnM__Contain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 536);
            this.panel1.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(39, 193);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset Server";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(39, 110);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(123, 33);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clean Data";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(39, 486);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(123, 30);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(39, 25);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 54);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.Gainsboro;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLine.Location = new System.Drawing.Point(190, 0);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1, 536);
            this.pnLine.TabIndex = 9;
            // 
            // pnM
            // 
            this.pnM.Controls.Add(this.pnM__Contain);
            this.pnM.Controls.Add(this.pnLine2);
            this.pnM.Controls.Add(this.pnM__Header);
            this.pnM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnM.Location = new System.Drawing.Point(191, 0);
            this.pnM.Name = "pnM";
            this.pnM.Size = new System.Drawing.Size(555, 536);
            this.pnM.TabIndex = 10;
            // 
            // pnM__Header
            // 
            this.pnM__Header.Controls.Add(this.pnM__Header__Info);
            this.pnM__Header.Controls.Add(this.pnM__Header__Console);
            this.pnM__Header.Controls.Add(this.pn1);
            this.pnM__Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnM__Header.Location = new System.Drawing.Point(0, 0);
            this.pnM__Header.Name = "pnM__Header";
            this.pnM__Header.Size = new System.Drawing.Size(555, 61);
            this.pnM__Header.TabIndex = 7;
            // 
            // pnM__Header__Info
            // 
            this.pnM__Header__Info.Controls.Add(this.btnInfomation);
            this.pnM__Header__Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnM__Header__Info.Location = new System.Drawing.Point(234, 0);
            this.pnM__Header__Info.Name = "pnM__Header__Info";
            this.pnM__Header__Info.Size = new System.Drawing.Size(135, 61);
            this.pnM__Header__Info.TabIndex = 2;
            // 
            // btnInfomation
            // 
            this.btnInfomation.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnInfomation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfomation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfomation.Location = new System.Drawing.Point(19, 12);
            this.btnInfomation.Name = "btnInfomation";
            this.btnInfomation.Size = new System.Drawing.Size(102, 37);
            this.btnInfomation.TabIndex = 0;
            this.btnInfomation.Text = "Infomation";
            this.btnInfomation.UseVisualStyleBackColor = true;
            this.btnInfomation.Click += new System.EventHandler(this.btnInfomation_Click);
            // 
            // pnM__Header__Console
            // 
            this.pnM__Header__Console.Controls.Add(this.btnConsole);
            this.pnM__Header__Console.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnM__Header__Console.Location = new System.Drawing.Point(115, 0);
            this.pnM__Header__Console.Name = "pnM__Header__Console";
            this.pnM__Header__Console.Size = new System.Drawing.Size(119, 61);
            this.pnM__Header__Console.TabIndex = 1;
            // 
            // btnConsole
            // 
            this.btnConsole.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsole.Location = new System.Drawing.Point(19, 12);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(86, 37);
            this.btnConsole.TabIndex = 0;
            this.btnConsole.Text = "Console";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.pictureBox1);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(115, 61);
            this.pn1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnLine2
            // 
            this.pnLine2.BackColor = System.Drawing.Color.LightGray;
            this.pnLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine2.Location = new System.Drawing.Point(0, 61);
            this.pnLine2.Name = "pnLine2";
            this.pnLine2.Size = new System.Drawing.Size(555, 1);
            this.pnLine2.TabIndex = 9;
            // 
            // pnM__Contain
            // 
            this.pnM__Contain.Controls.Add(this.pictureBox2);
            this.pnM__Contain.Controls.Add(this.txtBoxConsole);
            this.pnM__Contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnM__Contain.Location = new System.Drawing.Point(0, 62);
            this.pnM__Contain.Name = "pnM__Contain";
            this.pnM__Contain.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.pnM__Contain.Size = new System.Drawing.Size(555, 474);
            this.pnM__Contain.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(506, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtBoxConsole
            // 
            this.txtBoxConsole.BackColor = System.Drawing.Color.White;
            this.txtBoxConsole.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConsole.Location = new System.Drawing.Point(21, 102);
            this.txtBoxConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxConsole.Multiline = true;
            this.txtBoxConsole.Name = "txtBoxConsole";
            this.txtBoxConsole.ReadOnly = true;
            this.txtBoxConsole.Size = new System.Drawing.Size(426, 199);
            this.txtBoxConsole.TabIndex = 7;
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 536);
            this.Controls.Add(this.pnM);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServerUI";
            this.Text = "LAN Message Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerUI_FormClosing);
            this.panel1.ResumeLayout(false);
            this.pnM.ResumeLayout(false);
            this.pnM__Header.ResumeLayout(false);
            this.pnM__Header__Info.ResumeLayout(false);
            this.pnM__Header__Console.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnM__Contain.ResumeLayout(false);
            this.pnM__Contain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Panel pnM;
        private System.Windows.Forms.Panel pnM__Header;
        private System.Windows.Forms.Panel pnM__Header__Info;
        private System.Windows.Forms.Button btnInfomation;
        private System.Windows.Forms.Panel pnM__Header__Console;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnM__Contain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBoxConsole;
        private System.Windows.Forms.Panel pnLine2;
    }
}