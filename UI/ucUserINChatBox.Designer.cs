namespace UI
{
    partial class ucUserINChatBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserINChatBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelAddMessage = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnPin = new System.Windows.Forms.Panel();
            this.picPin = new System.Windows.Forms.PictureBox();
            this.pnDelete = new System.Windows.Forms.Panel();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnPin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPin)).BeginInit();
            this.pnDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.pnEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(9, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 562);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panelAddMessage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(66, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(932, 41);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panelAddMessage
            // 
            this.panelAddMessage.AutoSize = true;
            this.panelAddMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelAddMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddMessage.Location = new System.Drawing.Point(5, 41);
            this.panelAddMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAddMessage.Name = "panelAddMessage";
            this.panelAddMessage.Size = new System.Drawing.Size(927, 0);
            this.panelAddMessage.TabIndex = 1;
            this.panelAddMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pnMenu);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 3, 0, 5);
            this.panel3.Size = new System.Drawing.Size(927, 41);
            this.panel3.TabIndex = 0;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.pnPin);
            this.pnMenu.Controls.Add(this.pnDelete);
            this.pnMenu.Controls.Add(this.pnEdit);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMenu.Location = new System.Drawing.Point(784, 3);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(143, 33);
            this.pnMenu.TabIndex = 1;
            this.pnMenu.Visible = false;
            this.pnMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnPin
            // 
            this.pnPin.Controls.Add(this.picPin);
            this.pnPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPin.Location = new System.Drawing.Point(47, 0);
            this.pnPin.Margin = new System.Windows.Forms.Padding(10);
            this.pnPin.Name = "pnPin";
            this.pnPin.Size = new System.Drawing.Size(49, 33);
            this.pnPin.TabIndex = 3;
            this.pnPin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // picPin
            // 
            this.picPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPin.Location = new System.Drawing.Point(0, 0);
            this.picPin.Name = "picPin";
            this.picPin.Size = new System.Drawing.Size(49, 33);
            this.picPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin.TabIndex = 1;
            this.picPin.TabStop = false;
            this.picPin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnDelete
            // 
            this.pnDelete.Controls.Add(this.picDelete);
            this.pnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDelete.Location = new System.Drawing.Point(96, 0);
            this.pnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.pnDelete.Name = "pnDelete";
            this.pnDelete.Size = new System.Drawing.Size(47, 33);
            this.pnDelete.TabIndex = 2;
            this.pnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // picDelete
            // 
            this.picDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDelete.Location = new System.Drawing.Point(0, 0);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(47, 33);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 1;
            this.picDelete.TabStop = false;
            this.picDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.picEdit);
            this.pnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnEdit.Location = new System.Drawing.Point(0, 0);
            this.pnEdit.Margin = new System.Windows.Forms.Padding(10);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(47, 33);
            this.pnEdit.TabIndex = 0;
            this.pnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // picEdit
            // 
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(0, 0);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(47, 33);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 0;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            this.picEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(5, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(101, 34);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            this.labelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ucUserINChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucUserINChatBox";
            this.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Size = new System.Drawing.Size(998, 562);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnPin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPin)).EndInit();
            this.pnDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.pnEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAddMessage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnPin;
        private System.Windows.Forms.PictureBox picPin;
        private System.Windows.Forms.Panel pnDelete;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.Panel pnEdit;
        private System.Windows.Forms.PictureBox picEdit;
    }
}
