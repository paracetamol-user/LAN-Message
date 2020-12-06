namespace UI
{
    partial class ucGroup
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
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainAll = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnContain.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnContainAll);
            this.pnContain.Controls.Add(this.pnMenu);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(10, 20);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(779, 378);
            this.pnContain.TabIndex = 0;
            // 
            // pnContainAll
            // 
            this.pnContainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainAll.Location = new System.Drawing.Point(0, 56);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Padding = new System.Windows.Forms.Padding(20, 10, 30, 0);
            this.pnContainAll.Size = new System.Drawing.Size(779, 322);
            this.pnContainAll.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(40, 0, 80, 0);
            this.pnMenu.Size = new System.Drawing.Size(779, 56);
            this.pnMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(510, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(189, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(20, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 36);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ucGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Name = "ucGroup";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.Size = new System.Drawing.Size(799, 408);
            this.pnContain.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainAll;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
    }
}
