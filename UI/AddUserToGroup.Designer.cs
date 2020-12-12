
namespace UI
{
    partial class AddUserToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserToGroup));
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnGroup = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLine
            // 
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(10, 10);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(481, 1);
            this.pnLine.TabIndex = 0;
            // 
            // pnGroup
            // 
            this.pnGroup.AutoScroll = true;
            this.pnGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGroup.Location = new System.Drawing.Point(10, 49);
            this.pnGroup.Name = "pnGroup";
            this.pnGroup.Size = new System.Drawing.Size(481, 216);
            this.pnGroup.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 38);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD TO GROUP";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picBoxAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(440, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 38);
            this.panel3.TabIndex = 2;
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAdd.Image")));
            this.picBoxAdd.Location = new System.Drawing.Point(17, 0);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(24, 38);
            this.picBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAdd.TabIndex = 1;
            this.picBoxAdd.TabStop = false;
            this.picBoxAdd.Click += new System.EventHandler(this.picBoxAdd_Click);
            // 
            // AddUserToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(501, 275);
            this.Controls.Add(this.pnGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserToGroup";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUserToGroup";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Panel pnGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxAdd;
    }
}