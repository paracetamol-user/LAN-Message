
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnListContact = new System.Windows.Forms.Panel();
			this.pnCreate = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnBtnCreate = new System.Windows.Forms.Panel();
			this.btnCreate = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnCreate.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnBtnCreate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnLine
			// 
			this.pnLine.BackColor = System.Drawing.Color.Gainsboro;
			this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnLine.Location = new System.Drawing.Point(0, 53);
			this.pnLine.Margin = new System.Windows.Forms.Padding(4);
			this.pnLine.Name = "pnLine";
			this.pnLine.Size = new System.Drawing.Size(892, 1);
			this.pnLine.TabIndex = 3;
			// 
			// pnHeader
			// 
			this.pnHeader.BackColor = System.Drawing.Color.Transparent;
			this.pnHeader.Controls.Add(this.pictureBox1);
			this.pnHeader.Controls.Add(this.lbContactBook);
			this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnHeader.Location = new System.Drawing.Point(0, 0);
			this.pnHeader.Margin = new System.Windows.Forms.Padding(4);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
			this.pnHeader.Size = new System.Drawing.Size(892, 53);
			this.pnHeader.TabIndex = 2;
			// 
			// lbContactBook
			// 
			this.lbContactBook.AutoSize = true;
			this.lbContactBook.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbContactBook.Location = new System.Drawing.Point(71, 14);
			this.lbContactBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbContactBook.Name = "lbContactBook";
			this.lbContactBook.Size = new System.Drawing.Size(173, 29);
			this.lbContactBook.TabIndex = 1;
			this.lbContactBook.Text = "Contact Book";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.pnListContact);
			this.panel1.Controls.Add(this.pnCreate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 54);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20, 6, 20, 6);
			this.panel1.Size = new System.Drawing.Size(892, 491);
			this.panel1.TabIndex = 4;
			// 
			// pnListContact
			// 
			this.pnListContact.AutoScroll = true;
			this.pnListContact.BackColor = System.Drawing.Color.Transparent;
			this.pnListContact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnListContact.Location = new System.Drawing.Point(20, 43);
			this.pnListContact.Margin = new System.Windows.Forms.Padding(4);
			this.pnListContact.Name = "pnListContact";
			this.pnListContact.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
			this.pnListContact.Size = new System.Drawing.Size(852, 442);
			this.pnListContact.TabIndex = 1;
			// 
			// pnCreate
			// 
			this.pnCreate.Controls.Add(this.panel2);
			this.pnCreate.Controls.Add(this.pnBtnCreate);
			this.pnCreate.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnCreate.Location = new System.Drawing.Point(20, 6);
			this.pnCreate.Margin = new System.Windows.Forms.Padding(4);
			this.pnCreate.Name = "pnCreate";
			this.pnCreate.Size = new System.Drawing.Size(852, 37);
			this.pnCreate.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
			this.panel2.Size = new System.Drawing.Size(688, 37);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(13, 4);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(662, 29);
			this.textBox1.TabIndex = 0;
			// 
			// pnBtnCreate
			// 
			this.pnBtnCreate.Controls.Add(this.btnCreate);
			this.pnBtnCreate.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnBtnCreate.Location = new System.Drawing.Point(688, 0);
			this.pnBtnCreate.Margin = new System.Windows.Forms.Padding(4);
			this.pnBtnCreate.Name = "pnBtnCreate";
			this.pnBtnCreate.Padding = new System.Windows.Forms.Padding(7, 1, 7, 1);
			this.pnBtnCreate.Size = new System.Drawing.Size(164, 37);
			this.pnBtnCreate.TabIndex = 0;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.Transparent;
			this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.Black;
			this.btnCreate.Location = new System.Drawing.Point(7, 1);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(150, 35);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(20, 8);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 38);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// FrmContactBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 545);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnLine);
			this.Controls.Add(this.pnHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmContactBook";
			this.Text = "FrmContactList";
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.pnCreate.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnBtnCreate.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Label lbContactBook;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnListContact;
		private System.Windows.Forms.Panel pnCreate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel pnBtnCreate;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}