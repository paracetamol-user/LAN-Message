
namespace UI
{
	partial class ucContact__User
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContact__User));
			this.pnLine = new System.Windows.Forms.Panel();
			this.pnMenu = new System.Windows.Forms.Panel();
			this.picRemove = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnInfo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pnMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnLine
			// 
			this.pnLine.BackColor = System.Drawing.Color.Transparent;
			this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnLine.Location = new System.Drawing.Point(0, 4);
			this.pnLine.Name = "pnLine";
			this.pnLine.Size = new System.Drawing.Size(216, 1);
			this.pnLine.TabIndex = 2;
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.Color.Transparent;
			this.pnMenu.Controls.Add(this.picRemove);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnMenu.Location = new System.Drawing.Point(187, 5);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(29, 31);
			this.pnMenu.TabIndex = 6;
			// 
			// picRemove
			// 
			this.picRemove.BackColor = System.Drawing.Color.Transparent;
			this.picRemove.Dock = System.Windows.Forms.DockStyle.Right;
			this.picRemove.Image = ((System.Drawing.Image)(resources.GetObject("picRemove.Image")));
			this.picRemove.Location = new System.Drawing.Point(19, 0);
			this.picRemove.Name = "picRemove";
			this.picRemove.Size = new System.Drawing.Size(10, 31);
			this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picRemove.TabIndex = 0;
			this.picRemove.TabStop = false;
			this.picRemove.Click += new System.EventHandler(this.picRemove_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 5);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(4);
			this.panel1.Size = new System.Drawing.Size(36, 31);
			this.panel1.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 23);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pnInfo
			// 
			this.pnInfo.BackColor = System.Drawing.Color.Transparent;
			this.pnInfo.Controls.Add(this.label1);
			this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnInfo.Location = new System.Drawing.Point(36, 5);
			this.pnInfo.Name = "pnInfo";
			this.pnInfo.Size = new System.Drawing.Size(151, 31);
			this.pnInfo.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// ucContact__User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pnInfo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnMenu);
			this.Controls.Add(this.pnLine);
			this.Name = "ucContact__User";
			this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.Size = new System.Drawing.Size(216, 40);
			this.pnMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnInfo.ResumeLayout(false);
			this.pnInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.PictureBox picRemove;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnInfo;
		private System.Windows.Forms.Label label1;
	}
}
