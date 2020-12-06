namespace UI
{
    partial class ucEditMessage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.pnContainTxt = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnContainTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbSave);
            this.panel1.Controls.Add(this.lbCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 32);
            this.panel1.TabIndex = 1;
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancel.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(179, 3);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(52, 25);
            this.lbCancel.TabIndex = 0;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSave.Font = new System.Drawing.Font("Dubai", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSave.ForeColor = System.Drawing.Color.White;
            this.lbSave.Location = new System.Drawing.Point(252, 3);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(41, 25);
            this.lbSave.TabIndex = 1;
            this.lbSave.Text = "Save";
            this.lbSave.Click += new System.EventHandler(this.lbSave_Click);
            // 
            // pnContainTxt
            // 
            this.pnContainTxt.Controls.Add(this.textBox1);
            this.pnContainTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnContainTxt.Location = new System.Drawing.Point(20, 3);
            this.pnContainTxt.Name = "pnContainTxt";
            this.pnContainTxt.Padding = new System.Windows.Forms.Padding(5, 7, 10, 7);
            this.pnContainTxt.Size = new System.Drawing.Size(486, 44);
            this.pnContainTxt.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 36);
            this.textBox1.TabIndex = 0;
            // 
            // ucEditMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContainTxt);
            this.Controls.Add(this.panel1);
            this.Name = "ucEditMessage";
            this.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.Size = new System.Drawing.Size(526, 84);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnContainTxt.ResumeLayout(false);
            this.pnContainTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Panel pnContainTxt;
        private System.Windows.Forms.TextBox textBox1;
    }
}
