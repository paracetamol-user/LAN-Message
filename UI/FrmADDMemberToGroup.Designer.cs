
namespace UI
{
    partial class FrmADDMemberToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmADDMemberToGroup));
            this.pnContainAll = new System.Windows.Forms.Panel();
            this.pnGroup = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnContainAll.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainAll
            // 
            this.pnContainAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainAll.Controls.Add(this.pnGroup);
            this.pnContainAll.Controls.Add(this.panel2);
            this.pnContainAll.Controls.Add(this.pnLine);
            this.pnContainAll.Location = new System.Drawing.Point(220, 142);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Size = new System.Drawing.Size(396, 284);
            this.pnContainAll.TabIndex = 0;
            // 
            // pnGroup
            // 
            this.pnGroup.AutoScroll = true;
            this.pnGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGroup.Location = new System.Drawing.Point(0, 32);
            this.pnGroup.Margin = new System.Windows.Forms.Padding(2);
            this.pnGroup.Name = "pnGroup";
            this.pnGroup.Size = new System.Drawing.Size(394, 250);
            this.pnGroup.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 31);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 31);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD TO GROUP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.picBoxAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(363, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(31, 31);
            this.panel3.TabIndex = 2;
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAdd.Image")));
            this.picBoxAdd.Location = new System.Drawing.Point(13, 0);
            this.picBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(18, 31);
            this.picBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAdd.TabIndex = 1;
            this.picBoxAdd.TabStop = false;
            this.picBoxAdd.Click += new System.EventHandler(this.picBoxAdd_Click_1);
            // 
            // pnLine
            // 
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(0, 0);
            this.pnLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(394, 1);
            this.pnLine.TabIndex = 4;
            // 
            // AddUserToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(919, 571);
            this.Controls.Add(this.pnContainAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddUserToGroup";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUserToGroup";
            this.pnContainAll.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainAll;
        private System.Windows.Forms.Panel pnGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxAdd;
        private System.Windows.Forms.Panel pnLine;
    }
}