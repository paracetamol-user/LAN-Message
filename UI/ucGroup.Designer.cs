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
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnListGroup = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.ucSearch1 = new UI.ucSearch();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.pnListGr = new System.Windows.Forms.Panel();
            this.pnContain.SuspendLayout();
            this.pnContainAll.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnListGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainAll);
            this.pnContain.Controls.Add(this.pnMenu);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(11, 5);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(486, 466);
            this.pnContain.TabIndex = 1;
            // 
            // pnContainAll
            // 
            this.pnContainAll.BackColor = System.Drawing.Color.Transparent;
            this.pnContainAll.Controls.Add(this.pnListGroup);
            this.pnContainAll.Controls.Add(this.pnSearch);
            this.pnContainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainAll.Location = new System.Drawing.Point(0, 57);
            this.pnContainAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Padding = new System.Windows.Forms.Padding(20, 0, 29, 0);
            this.pnContainAll.Size = new System.Drawing.Size(486, 409);
            this.pnContainAll.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.panel4);
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(40, 0, 80, 0);
            this.pnMenu.Size = new System.Drawing.Size(486, 57);
            this.pnMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(217, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(189, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(20, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 37);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.ucSearch1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(20, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnSearch.Size = new System.Drawing.Size(437, 50);
            this.pnSearch.TabIndex = 0;
            this.pnSearch.Visible = false;
            // 
            // pnListGroup
            // 
            this.pnListGroup.Controls.Add(this.pnListGr);
            this.pnListGroup.Controls.Add(this.pnAdd);
            this.pnListGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListGroup.Location = new System.Drawing.Point(20, 50);
            this.pnListGroup.Name = "pnListGroup";
            this.pnListGroup.Size = new System.Drawing.Size(437, 359);
            this.pnListGroup.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCreate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(40, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.panel4.Size = new System.Drawing.Size(177, 57);
            this.panel4.TabIndex = 1;
            // 
            // txtCreate
            // 
            this.txtCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.Location = new System.Drawing.Point(20, 10);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(137, 39);
            this.txtCreate.TabIndex = 3;
            // 
            // ucSearch1
            // 
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearch1.Location = new System.Drawing.Point(10, 5);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucSearch1.Size = new System.Drawing.Size(417, 40);
            this.ucSearch1.TabIndex = 0;
            // 
            // pnAdd
            // 
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAdd.Location = new System.Drawing.Point(243, 0);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(194, 359);
            this.pnAdd.TabIndex = 2;
            this.pnAdd.Visible = false;
            // 
            // pnListGr
            // 
            this.pnListGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListGr.Location = new System.Drawing.Point(0, 0);
            this.pnListGr.Name = "pnListGr";
            this.pnListGr.Size = new System.Drawing.Size(243, 359);
            this.pnListGr.TabIndex = 3;
            // 
            // ucGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucGroup";
            this.Padding = new System.Windows.Forms.Padding(11, 5, 11, 10);
            this.Size = new System.Drawing.Size(508, 481);
            this.pnContain.ResumeLayout(false);
            this.pnContainAll.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnListGroup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
