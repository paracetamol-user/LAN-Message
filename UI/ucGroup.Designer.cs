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
            this.pnListGroup = new System.Windows.Forms.Panel();
            this.pnListGr = new System.Windows.Forms.Panel();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.ucSearch1 = new UI.ucSearch();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnContain.SuspendLayout();
            this.pnContainAll.SuspendLayout();
            this.pnListGroup.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainAll);
            this.pnContain.Controls.Add(this.pnMenu);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(8, 4);
            this.pnContain.Margin = new System.Windows.Forms.Padding(2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(365, 379);
            this.pnContain.TabIndex = 1;
            // 
            // pnContainAll
            // 
            this.pnContainAll.BackColor = System.Drawing.Color.Transparent;
            this.pnContainAll.Controls.Add(this.pnListGroup);
            this.pnContainAll.Controls.Add(this.pnSearch);
            this.pnContainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainAll.Location = new System.Drawing.Point(0, 42);
            this.pnContainAll.Margin = new System.Windows.Forms.Padding(2);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Padding = new System.Windows.Forms.Padding(15, 0, 22, 0);
            this.pnContainAll.Size = new System.Drawing.Size(365, 337);
            this.pnContainAll.TabIndex = 1;
            // 
            // pnListGroup
            // 
            this.pnListGroup.Controls.Add(this.pnListGr);
            this.pnListGroup.Controls.Add(this.pnAdd);
            this.pnListGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListGroup.Location = new System.Drawing.Point(15, 41);
            this.pnListGroup.Margin = new System.Windows.Forms.Padding(2);
            this.pnListGroup.Name = "pnListGroup";
            this.pnListGroup.Size = new System.Drawing.Size(328, 296);
            this.pnListGroup.TabIndex = 1;
            // 
            // pnListGr
            // 
            this.pnListGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListGr.Location = new System.Drawing.Point(0, 0);
            this.pnListGr.Margin = new System.Windows.Forms.Padding(2);
            this.pnListGr.Name = "pnListGr";
            this.pnListGr.Size = new System.Drawing.Size(182, 296);
            this.pnListGr.TabIndex = 3;
            // 
            // pnAdd
            // 
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAdd.Location = new System.Drawing.Point(182, 0);
            this.pnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(146, 296);
            this.pnAdd.TabIndex = 2;
            this.pnAdd.Visible = false;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.ucSearch1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(15, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pnSearch.Size = new System.Drawing.Size(328, 41);
            this.pnSearch.TabIndex = 0;
            this.pnSearch.Visible = false;
            // 
            // ucSearch1
            // 
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearch1.Location = new System.Drawing.Point(8, 4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucSearch1.Size = new System.Drawing.Size(312, 33);
            this.ucSearch1.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.panel4);
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(30, 0, 60, 0);
            this.pnMenu.Size = new System.Drawing.Size(365, 42);
            this.pnMenu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCreate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(30, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15, 8, 15, 4);
            this.panel4.Size = new System.Drawing.Size(133, 42);
            this.panel4.TabIndex = 1;
            // 
            // txtCreate
            // 
            this.txtCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.Location = new System.Drawing.Point(15, 8);
            this.txtCreate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(103, 25);
            this.txtCreate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(163, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.panel1.Size = new System.Drawing.Size(142, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(15, 8);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ucGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucGroup";
            this.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.Size = new System.Drawing.Size(381, 391);
            this.pnContain.ResumeLayout(false);
            this.pnContainAll.ResumeLayout(false);
            this.pnListGroup.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainAll;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnListGroup;
        private System.Windows.Forms.Panel pnSearch;
        private ucSearch ucSearch1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Panel pnListGr;
        private System.Windows.Forms.Panel pnAdd;
    }
}
