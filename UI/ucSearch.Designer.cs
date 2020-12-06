
namespace UI
{
    partial class ucSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSearch));
            this.pnSearch = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.pnSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnSearch.Controls.Add(this.textBox1);
            this.pnSearch.Controls.Add(this.panel3);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(7, 6);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.pnSearch.Size = new System.Drawing.Size(454, 43);
            this.pnSearch.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(27, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(390, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(37, 31);
            this.panel3.TabIndex = 3;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(7, 0);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(30, 31);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 2;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucSearch";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(468, 55);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picSearch;
    }
}
