
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
			this.roundPicAvatar = new UI.roundpicturebox();
			this.pnInfo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pnMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).BeginInit();
			this.pnInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnLine
			// 
			this.pnLine.BackColor = System.Drawing.Color.Transparent;
			this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnLine.Location = new System.Drawing.Point(0, 5);
			this.pnLine.Margin = new System.Windows.Forms.Padding(4);
			this.pnLine.Name = "pnLine";
			this.pnLine.Size = new System.Drawing.Size(288, 1);
			this.pnLine.TabIndex = 2;
			this.pnLine.Click += new System.EventHandler(this.pnLine_Click);
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.Color.Transparent;
			this.pnMenu.Controls.Add(this.picRemove);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnMenu.Location = new System.Drawing.Point(249, 6);
			this.pnMenu.Margin = new System.Windows.Forms.Padding(4);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(39, 45);
			this.pnMenu.TabIndex = 6;
			this.pnMenu.Click += new System.EventHandler(this.pnLine_Click);
			// 
			// picRemove
			// 
			this.picRemove.BackColor = System.Drawing.Color.Transparent;
			this.picRemove.Dock = System.Windows.Forms.DockStyle.Right;
			this.picRemove.Image = ((System.Drawing.Image)(resources.GetObject("picRemove.Image")));
			this.picRemove.Location = new System.Drawing.Point(26, 0);
			this.picRemove.Margin = new System.Windows.Forms.Padding(4);
			this.picRemove.Name = "picRemove";
			this.picRemove.Size = new System.Drawing.Size(13, 45);
			this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picRemove.TabIndex = 0;
			this.picRemove.TabStop = false;
			this.picRemove.Click += new System.EventHandler(this.picRemove_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.roundPicAvatar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(5);
			this.panel1.Size = new System.Drawing.Size(45, 45);
			this.panel1.TabIndex = 8;
			this.panel1.Click += new System.EventHandler(this.pnLine_Click);
			// 
			// roundPicAvatar
			// 
			this.roundPicAvatar.BackColor = System.Drawing.SystemColors.Control;
			this.roundPicAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.roundPicAvatar.Location = new System.Drawing.Point(5, 5);
			this.roundPicAvatar.Name = "roundPicAvatar";
			this.roundPicAvatar.Size = new System.Drawing.Size(35, 35);
			this.roundPicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.roundPicAvatar.TabIndex = 1;
			this.roundPicAvatar.TabStop = false;
			this.roundPicAvatar.Click += new System.EventHandler(this.pnLine_Click);
			// 
			// pnInfo
			// 
			this.pnInfo.BackColor = System.Drawing.Color.Transparent;
			this.pnInfo.Controls.Add(this.label1);
			this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnInfo.Location = new System.Drawing.Point(45, 6);
			this.pnInfo.Margin = new System.Windows.Forms.Padding(4);
			this.pnInfo.Name = "pnInfo";
			this.pnInfo.Size = new System.Drawing.Size(204, 45);
			this.pnInfo.TabIndex = 9;
			this.pnInfo.Click += new System.EventHandler(this.pnLine_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.pnLine_Click);
			// 
			// ucContact__User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pnInfo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnMenu);
			this.Controls.Add(this.pnLine);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ucContact__User";
			this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.Size = new System.Drawing.Size(288, 56);
			this.pnMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).EndInit();
			this.pnInfo.ResumeLayout(false);
			this.pnInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.PictureBox picRemove;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnInfo;
		private System.Windows.Forms.Label label1;
		private roundpicturebox roundPicAvatar;
	}
}
