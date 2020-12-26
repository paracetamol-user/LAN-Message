
namespace UI
{
	partial class ucContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContact));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbNameContact = new System.Windows.Forms.Label();
            this.pnPic = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pictureDelete = new System.Windows.Forms.PictureBox();
            this.pictureAdd = new System.Windows.Forms.PictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.pnPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.pnInfo);
            this.pnHeader.Controls.Add(this.pnPic);
            this.pnHeader.Controls.Add(this.pnMenu);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.pnHeader.Size = new System.Drawing.Size(615, 37);
            this.pnHeader.TabIndex = 3;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.lbNameContact);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(57, 0);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(470, 37);
            this.pnInfo.TabIndex = 5;
            // 
            // lbNameContact
            // 
            this.lbNameContact.AutoSize = true;
            this.lbNameContact.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameContact.Location = new System.Drawing.Point(9, 7);
            this.lbNameContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameContact.Name = "lbNameContact";
            this.lbNameContact.Size = new System.Drawing.Size(68, 23);
            this.lbNameContact.TabIndex = 0;
            this.lbNameContact.Text = "label1";
            // 
            // pnPic
            // 
            this.pnPic.Controls.Add(this.pic);
            this.pnPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPic.Location = new System.Drawing.Point(13, 0);
            this.pnPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnPic.Name = "pnPic";
            this.pnPic.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnPic.Size = new System.Drawing.Size(44, 37);
            this.pnPic.TabIndex = 3;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(0, 4);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(44, 29);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.pictureDelete);
            this.pnMenu.Controls.Add(this.pictureAdd);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMenu.Location = new System.Drawing.Point(527, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(0, 9, 13, 9);
            this.pnMenu.Size = new System.Drawing.Size(88, 37);
            this.pnMenu.TabIndex = 4;
            // 
            // pictureDelete
            // 
            this.pictureDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureDelete.Location = new System.Drawing.Point(54, 9);
            this.pictureDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureDelete.Name = "pictureDelete";
            this.pictureDelete.Size = new System.Drawing.Size(21, 19);
            this.pictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDelete.TabIndex = 1;
            this.pictureDelete.TabStop = false;
            this.pictureDelete.Click += new System.EventHandler(this.pictureDelete_Click);
            // 
            // pictureAdd
            // 
            this.pictureAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAdd.Location = new System.Drawing.Point(13, 9);
            this.pictureAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureAdd.Name = "pictureAdd";
            this.pictureAdd.Size = new System.Drawing.Size(25, 20);
            this.pictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAdd.TabIndex = 0;
            this.pictureAdd.TabStop = false;
            this.pictureAdd.Click += new System.EventHandler(this.pictureAdd_Click);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.Gainsboro;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(0, 37);
            this.pnLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(615, 1);
            this.pnLine.TabIndex = 7;
            this.pnLine.Visible = false;
            // 
            // pnList
            // 
            this.pnList.AutoSize = true;
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 38);
            this.pnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnList.Name = "pnList";
            this.pnList.Padding = new System.Windows.Forms.Padding(27, 6, 27, 0);
            this.pnList.Size = new System.Drawing.Size(615, 6);
            this.pnList.TabIndex = 8;
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(615, 54);
            this.pnHeader.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Panel pnInfo;
		private System.Windows.Forms.Label lbNameContact;
		private System.Windows.Forms.Panel pnPic;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.PictureBox pictureDelete;
		private System.Windows.Forms.PictureBox pictureAdd;
		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnList;
	}
}
