
namespace UI
{
    partial class ucGroupAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGroupAll));
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainId = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picChat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.roundPicAvatar = new UI.roundpicturebox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnContain.SuspendLayout();
            this.pnContainId.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnContainId);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel2);
            this.pnContain.Controls.Add(this.panel1);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(11, 1);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Padding = new System.Windows.Forms.Padding(11, 3, 10, 3);
            this.pnContain.Size = new System.Drawing.Size(393, 62);
            this.pnContain.TabIndex = 5;
            this.pnContain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // pnContainId
            // 
            this.pnContainId.Controls.Add(this.lbId);
            this.pnContainId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainId.Location = new System.Drawing.Point(69, 33);
            this.pnContainId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainId.Name = "pnContainId";
            this.pnContainId.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContainId.Size = new System.Drawing.Size(250, 25);
            this.pnContainId.TabIndex = 9;
            this.pnContainId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.DimGray;
            this.lbId.Location = new System.Drawing.Point(5, 2);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(44, 18);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "label2";
            this.lbId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // pnContrainName
            // 
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(69, 3);
            this.pnContrainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(250, 30);
            this.pnContrainName.TabIndex = 8;
            this.pnContrainName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picChat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(319, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.panel2.Size = new System.Drawing.Size(35, 56);
            this.panel2.TabIndex = 7;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // picChat
            // 
            this.picChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChat.Image = ((System.Drawing.Image)(resources.GetObject("picChat.Image")));
            this.picChat.Location = new System.Drawing.Point(0, 0);
            this.picChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChat.Name = "picChat";
            this.picChat.Size = new System.Drawing.Size(24, 56);
            this.picChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChat.TabIndex = 0;
            this.picChat.TabStop = false;
            this.picChat.Click += new System.EventHandler(this.picChat_Click);
            this.picChat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(354, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(29, 56);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // picAdd
            // 
            this.picAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(11, 0);
            this.picAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAdd.Name = "picAdd";
            this.picAdd.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.picAdd.Size = new System.Drawing.Size(18, 56);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 0;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.Controls.Add(this.roundPicAvatar);
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(11, 3);
            this.pnContainPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainPicture.Size = new System.Drawing.Size(58, 56);
            this.pnContainPicture.TabIndex = 0;
            this.pnContainPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // roundPicAvatar
            // 
            this.roundPicAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundPicAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPicAvatar.Location = new System.Drawing.Point(3, 2);
            this.roundPicAvatar.Name = "roundPicAvatar";
            this.roundPicAvatar.Size = new System.Drawing.Size(52, 52);
            this.roundPicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicAvatar.TabIndex = 1;
            this.roundPicAvatar.TabStop = false;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.ForeColor = System.Drawing.Color.Black;
            this.pnLine.Location = new System.Drawing.Point(11, 0);
            this.pnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(393, 1);
            this.pnLine.TabIndex = 4;
            this.pnLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaPic_MouseClick);
            // 
            // ucGroupAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContain);
            this.Controls.Add(this.pnLine);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucGroupAll";
            this.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Size = new System.Drawing.Size(404, 63);
            this.pnContain.ResumeLayout(false);
            this.pnContainId.ResumeLayout(false);
            this.pnContainId.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Panel pnContainPicture;
        private System.Windows.Forms.Panel pnLine;
		private roundpicturebox roundPicAvatar;
	}
}
