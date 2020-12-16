
namespace UI
{
	partial class FrmContactBook
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactBook));
			this.pnLine = new System.Windows.Forms.Panel();
			this.pnHeader = new System.Windows.Forms.Panel();
			this.lbContactBook = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnListContact = new System.Windows.Forms.Panel();
			this.pnCreate = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnBtnCreate = new System.Windows.Forms.Panel();
			this.btnCreate = new System.Windows.Forms.Button();
			this.pnHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnCreate.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnBtnCreate.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnLine
			// 
			this.pnLine.BackColor = System.Drawing.Color.LightGray;
			this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnLine.Location = new System.Drawing.Point(0, 49);
			this.pnLine.Name = "pnLine";
			this.pnLine.Size = new System.Drawing.Size(669, 1);
			this.pnLine.TabIndex = 3;
			// 
			// pnHeader
			// 
			this.pnHeader.BackColor = System.Drawing.Color.Transparent;
			this.pnHeader.Controls.Add(this.lbContactBook);
			this.pnHeader.Controls.Add(this.pictureBox1);
			this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnHeader.Location = new System.Drawing.Point(0, 5);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
			this.pnHeader.Size = new System.Drawing.Size(669, 44);
			this.pnHeader.TabIndex = 2;
			// 
			// lbContactBook
			// 
			this.lbContactBook.AutoSize = true;
			this.lbContactBook.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbContactBook.Location = new System.Drawing.Point(58, 11);
			this.lbContactBook.Name = "lbContactBook";
			this.lbContactBook.Size = new System.Drawing.Size(138, 23);
			this.lbContactBook.TabIndex = 1;
			this.lbContactBook.Text = "Contact Book";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(20, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 34);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.pnListContact);
			this.panel1.Controls.Add(this.pnCreate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 50);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
			this.panel1.Size = new System.Drawing.Size(669, 393);
			this.panel1.TabIndex = 4;
			// 
			// pnListContact
			// 
			this.pnListContact.AutoScroll = true;
			this.pnListContact.BackColor = System.Drawing.Color.Transparent;
			this.pnListContact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnListContact.Location = new System.Drawing.Point(20, 35);
			this.pnListContact.Name = "pnListContact";
			this.pnListContact.Size = new System.Drawing.Size(629, 353);
			this.pnListContact.TabIndex = 1;
			// 
			// pnCreate
			// 
			this.pnCreate.Controls.Add(this.panel2);
			this.pnCreate.Controls.Add(this.pnBtnCreate);
			this.pnCreate.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnCreate.Location = new System.Drawing.Point(20, 5);
			this.pnCreate.Name = "pnCreate";
			this.pnCreate.Size = new System.Drawing.Size(629, 30);
			this.pnCreate.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
			this.panel2.Size = new System.Drawing.Size(506, 30);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(10, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(486, 20);
			this.textBox1.TabIndex = 0;
			// 
			// pnBtnCreate
			// 
			this.pnBtnCreate.Controls.Add(this.btnCreate);
			this.pnBtnCreate.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnBtnCreate.Location = new System.Drawing.Point(506, 0);
			this.pnBtnCreate.Name = "pnBtnCreate";
			this.pnBtnCreate.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.pnBtnCreate.Size = new System.Drawing.Size(123, 30);
			this.pnBtnCreate.TabIndex = 0;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.Transparent;
			this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Location = new System.Drawing.Point(5, 1);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(113, 28);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			// 
			// FrmContactBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 443);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnLine);
			this.Controls.Add(this.pnHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmContactBook";
			this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.Text = "FrmContactList";
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pnCreate.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnBtnCreate.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Label lbContactBook;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnListContact;
		private System.Windows.Forms.Panel pnCreate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel pnBtnCreate;
		private System.Windows.Forms.Button btnCreate;
	}
}