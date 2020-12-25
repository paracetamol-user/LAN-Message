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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGroup));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHeaderName = new System.Windows.Forms.Label();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnBody.SuspendLayout();
            this.pnContain.SuspendLayout();
            this.pnContainAll.SuspendLayout();
            this.pnListGroup.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.lbHeaderName);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.pnHeader.Size = new System.Drawing.Size(508, 53);
            this.pnHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbHeaderName
            // 
            this.lbHeaderName.AutoSize = true;
            this.lbHeaderName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderName.Location = new System.Drawing.Point(71, 14);
            this.lbHeaderName.Name = "lbHeaderName";
            this.lbHeaderName.Size = new System.Drawing.Size(86, 29);
            this.lbHeaderName.TabIndex = 1;
            this.lbHeaderName.Text = "Group";
            // 
            // pnLine
            // 
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(0, 53);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(508, 1);
            this.pnLine.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnContain);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 54);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(508, 427);
            this.pnBody.TabIndex = 2;
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainAll);
            this.pnContain.Controls.Add(this.pnMenu);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(508, 427);
            this.pnContain.TabIndex = 2;
            // 
            // pnContainAll
            // 
            this.pnContainAll.BackColor = System.Drawing.Color.Transparent;
            this.pnContainAll.Controls.Add(this.pnListGroup);
            this.pnContainAll.Controls.Add(this.pnSearch);
            this.pnContainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainAll.Location = new System.Drawing.Point(0, 52);
            this.pnContainAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainAll.Name = "pnContainAll";
            this.pnContainAll.Padding = new System.Windows.Forms.Padding(20, 0, 29, 0);
            this.pnContainAll.Size = new System.Drawing.Size(508, 375);
            this.pnContainAll.TabIndex = 1;
            // 
            // pnListGroup
            // 
            this.pnListGroup.Controls.Add(this.pnListGr);
            this.pnListGroup.Controls.Add(this.pnAdd);
            this.pnListGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListGroup.Location = new System.Drawing.Point(20, 50);
            this.pnListGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnListGroup.Name = "pnListGroup";
            this.pnListGroup.Size = new System.Drawing.Size(459, 325);
            this.pnListGroup.TabIndex = 1;
            // 
            // pnListGr
            // 
            this.pnListGr.AutoScroll = true;
            this.pnListGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListGr.Location = new System.Drawing.Point(0, 0);
            this.pnListGr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnListGr.Name = "pnListGr";
            this.pnListGr.Size = new System.Drawing.Size(264, 325);
            this.pnListGr.TabIndex = 3;
            // 
            // pnAdd
            // 
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAdd.Location = new System.Drawing.Point(264, 0);
            this.pnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(195, 325);
            this.pnAdd.TabIndex = 2;
            this.pnAdd.Visible = false;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.ucSearch1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(20, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.pnSearch.Size = new System.Drawing.Size(459, 50);
            this.pnSearch.TabIndex = 0;
            this.pnSearch.Visible = false;
            // 
            // ucSearch1
            // 
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearch1.Location = new System.Drawing.Point(11, 5);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(5);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucSearch1.Size = new System.Drawing.Size(437, 40);
            this.ucSearch1.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.panel4);
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnMenu.Size = new System.Drawing.Size(508, 52);
            this.pnMenu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCreate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.panel4.Size = new System.Drawing.Size(303, 52);
            this.panel4.TabIndex = 1;
            // 
            // txtCreate
            // 
            this.txtCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.Location = new System.Drawing.Point(10, 10);
            this.txtCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(283, 28);
            this.txtCreate.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(323, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(165, 52);
            this.panel2.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(7, 7);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ucGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucGroup";
            this.Size = new System.Drawing.Size(508, 481);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.pnContain.ResumeLayout(false);
            this.pnContainAll.ResumeLayout(false);
            this.pnListGroup.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnBody;
		private System.Windows.Forms.Panel pnContain;
		private System.Windows.Forms.Panel pnContainAll;
		private System.Windows.Forms.Panel pnListGroup;
		private System.Windows.Forms.Panel pnListGr;
		private System.Windows.Forms.Panel pnAdd;
		private System.Windows.Forms.Panel pnSearch;
		private ucSearch ucSearch1;
		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtCreate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label lbHeaderName;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
