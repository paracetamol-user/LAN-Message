
namespace UI
{
    partial class FrmADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmADD));
            this.pnContainAll = new System.Windows.Forms.Panel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnContainAll.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainAll
            // 
            this.pnContainAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainAll.Controls.Add(this.pnUser);
            this.pnContainAll.Controls.Add(this.panel2);
            this.pnContainAll.Controls.Add(this.pnLine);
            this.pnContainAll.Location = new System.Drawing.Point(269, 102);
            this.pnContainAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Size = new System.Drawing.Size(527, 349);
            this.pnContainAll.TabIndex = 1;
            // 
            // pnUser
            // 
            this.pnUser.AutoScroll = true;
            this.pnUser.BackColor = System.Drawing.Color.Transparent;
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUser.Location = new System.Drawing.Point(0, 39);
            this.pnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(525, 308);
            this.pnUser.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBoxAdd);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 38);
            this.panel2.TabIndex = 5;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.Location = new System.Drawing.Point(460, 0);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(24, 38);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 4;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 38);
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
            this.panel3.Controls.Add(this.picBoxClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(484, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 38);
            this.panel3.TabIndex = 2;
            // 
            // picBoxClose
            // 
            this.picBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClose.Image")));
            this.picBoxClose.Location = new System.Drawing.Point(17, 0);
            this.picBoxClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(24, 38);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxClose.TabIndex = 1;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxAdd_Click);
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
            // FrmADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnContainAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmADD";
            this.Text = "frmADD";
            this.pnContainAll.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainAll;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.Panel pnLine;
    }
}