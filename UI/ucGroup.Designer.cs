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
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainAll);
            this.pnContain.Controls.Add(this.pnMenu);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(8, 16);
            this.pnContain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(587, 308);
            this.pnContain.TabIndex = 0;
            // 
            // pnContainAll
            // 
            this.pnContainAll.BackColor = System.Drawing.Color.Transparent;
            this.pnContainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainAll.Location = new System.Drawing.Point(0, 46);
            this.pnContainAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Padding = new System.Windows.Forms.Padding(15, 8, 22, 0);
            this.pnContainAll.Size = new System.Drawing.Size(587, 262);
            this.pnContainAll.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(30, 0, 60, 0);
            this.pnMenu.Size = new System.Drawing.Size(587, 46);
            this.pnMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(385, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.panel1.Size = new System.Drawing.Size(142, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(15, 8);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // ucGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucGroup";
            this.Padding = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.Size = new System.Drawing.Size(603, 332);
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
