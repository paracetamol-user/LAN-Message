
namespace UI
{
    partial class ucGroupToAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGroupToAdd));
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.gunaPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainStatus = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).BeginInit();
            this.pnContain.SuspendLayout();
            this.pnContainStatus.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.Controls.Add(this.gunaPic);
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(0, 0);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3);
            this.pnContainPicture.Size = new System.Drawing.Size(59, 54);
            this.pnContainPicture.TabIndex = 0;
            // 
            // gunaPic
            // 
            this.gunaPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPic.Image = ((System.Drawing.Image)(resources.GetObject("gunaPic.Image")));
            this.gunaPic.Location = new System.Drawing.Point(3, 3);
            this.gunaPic.Name = "gunaPic";
            this.gunaPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaPic.ShadowDecoration.Parent = this.gunaPic;
            this.gunaPic.Size = new System.Drawing.Size(53, 48);
            this.gunaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPic.TabIndex = 0;
            this.gunaPic.TabStop = false;
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnContainStatus);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(20, 7);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(337, 54);
            this.pnContain.TabIndex = 6;
            // 
            // pnContainStatus
            // 
            this.pnContainStatus.Controls.Add(this.lbID);
            this.pnContainStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainStatus.Location = new System.Drawing.Point(59, 30);
            this.pnContainStatus.Name = "pnContainStatus";
            this.pnContainStatus.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContainStatus.Size = new System.Drawing.Size(278, 24);
            this.pnContainStatus.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.DimGray;
            this.lbID.Location = new System.Drawing.Point(5, 2);
            this.lbID.Name = "lbID";
            this.lbID.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.lbID.Size = new System.Drawing.Size(53, 21);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "label2";
            // 
            // pnContrainName
            // 
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(59, 0);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(278, 30);
            this.pnContrainName.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // ucGroupToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Name = "ucGroupToAdd";
            this.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.Size = new System.Drawing.Size(377, 68);
            this.MouseLeave += new System.EventHandler(this.ucGroupToAdd_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucGroupToAdd_MouseMove);
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).EndInit();
            this.pnContain.ResumeLayout(false);
            this.pnContainStatus.ResumeLayout(false);
            this.pnContainStatus.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainPicture;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaPic;
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnContainStatus;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
    }
}
