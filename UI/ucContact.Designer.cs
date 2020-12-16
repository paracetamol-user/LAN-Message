
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
			this.pictureClose = new System.Windows.Forms.PictureBox();
			this.pictureAdd = new System.Windows.Forms.PictureBox();
			this.pnLine = new System.Windows.Forms.Panel();
			this.pnList = new System.Windows.Forms.Panel();
			this.pnHeader.SuspendLayout();
			this.pnInfo.SuspendLayout();
			this.pnPic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.pnMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
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
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.pnHeader.Size = new System.Drawing.Size(461, 30);
			this.pnHeader.TabIndex = 3;
			// 
			// pnInfo
			// 
			this.pnInfo.Controls.Add(this.lbNameContact);
			this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnInfo.Location = new System.Drawing.Point(43, 0);
			this.pnInfo.Name = "pnInfo";
			this.pnInfo.Size = new System.Drawing.Size(352, 30);
			this.pnInfo.TabIndex = 5;
			// 
			// lbNameContact
			// 
			this.lbNameContact.AutoSize = true;
			this.lbNameContact.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameContact.Location = new System.Drawing.Point(7, 6);
			this.lbNameContact.Name = "lbNameContact";
			this.lbNameContact.Size = new System.Drawing.Size(44, 18);
			this.lbNameContact.TabIndex = 0;
			this.lbNameContact.Text = "label1";
			// 
			// pnPic
			// 
			this.pnPic.Controls.Add(this.pic);
			this.pnPic.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnPic.Location = new System.Drawing.Point(10, 0);
			this.pnPic.Name = "pnPic";
			this.pnPic.Size = new System.Drawing.Size(33, 30);
			this.pnPic.TabIndex = 3;
			// 
			// pic
			// 
			this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
			this.pic.Location = new System.Drawing.Point(0, 0);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(33, 30);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			// 
			// pnMenu
			// 
			this.pnMenu.Controls.Add(this.pictureClose);
			this.pnMenu.Controls.Add(this.pictureAdd);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnMenu.Location = new System.Drawing.Point(395, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Padding = new System.Windows.Forms.Padding(0, 7, 10, 7);
			this.pnMenu.Size = new System.Drawing.Size(66, 30);
			this.pnMenu.TabIndex = 4;
			// 
			// pictureClose
			// 
			this.pictureClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
			this.pictureClose.Location = new System.Drawing.Point(40, 7);
			this.pictureClose.Name = "pictureClose";
			this.pictureClose.Size = new System.Drawing.Size(16, 16);
			this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureClose.TabIndex = 1;
			this.pictureClose.TabStop = false;
			// 
			// pictureAdd
			// 
			this.pictureAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureAdd.Image")));
			this.pictureAdd.Location = new System.Drawing.Point(10, 7);
			this.pictureAdd.Name = "pictureAdd";
			this.pictureAdd.Size = new System.Drawing.Size(19, 16);
			this.pictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureAdd.TabIndex = 0;
			this.pictureAdd.TabStop = false;
			// 
			// pnLine
			// 
			this.pnLine.BackColor = System.Drawing.Color.Gainsboro;
			this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnLine.Location = new System.Drawing.Point(0, 30);
			this.pnLine.Name = "pnLine";
			this.pnLine.Size = new System.Drawing.Size(461, 1);
			this.pnLine.TabIndex = 7;
			// 
			// pnList
			// 
			this.pnList.AutoSize = true;
			this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnList.Location = new System.Drawing.Point(0, 31);
			this.pnList.Name = "pnList";
			this.pnList.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			this.pnList.Size = new System.Drawing.Size(461, 5);
			this.pnList.TabIndex = 8;
			// 
			// ucContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pnList);
			this.Controls.Add(this.pnLine);
			this.Controls.Add(this.pnHeader);
			this.Name = "ucContact";
			this.Size = new System.Drawing.Size(461, 44);
			this.pnHeader.ResumeLayout(false);
			this.pnInfo.ResumeLayout(false);
			this.pnInfo.PerformLayout();
			this.pnPic.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.pnMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureClose;
		private System.Windows.Forms.PictureBox pictureAdd;
		private System.Windows.Forms.Panel pnLine;
		private System.Windows.Forms.Panel pnList;
	}
}
