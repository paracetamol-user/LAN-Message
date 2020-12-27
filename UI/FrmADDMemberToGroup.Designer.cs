
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
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnContainAll.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainAll
            // 
            this.pnContainAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainAll.Controls.Add(this.pnGroup);
            this.pnContainAll.Controls.Add(this.panel2);
            this.pnContainAll.Controls.Add(this.pnLine);
            this.pnContainAll.Location = new System.Drawing.Point(293, 175);
            this.pnContainAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Size = new System.Drawing.Size(527, 349);
            this.pnContainAll.TabIndex = 0;
            // 
            // pnGroup
            // 
            this.pnGroup.AutoScroll = true;
            this.pnGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGroup.Location = new System.Drawing.Point(0, 39);
            this.pnGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnGroup.Name = "pnGroup";
            this.pnGroup.Size = new System.Drawing.Size(525, 308);
            this.pnGroup.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picAdd);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 38);
            this.panel2.TabIndex = 5;
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(460, 0);
            this.picAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(24, 38);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 4;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 38);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD TO GROUP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.picClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(484, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 38);
            this.panel3.TabIndex = 2;
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(17, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 38);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picBoxAdd_Click_1);
            // 
            // pnLine
            // 
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(0, 0);
            this.pnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(525, 1);
            this.pnLine.TabIndex = 4;
            // 
            // FrmADDMemberToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1225, 703);
            this.Controls.Add(this.pnContainAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmADDMemberToGroup";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUserToGroup";
            this.pnContainAll.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainAll;
        private System.Windows.Forms.Panel pnGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel pnLine;
    }
}