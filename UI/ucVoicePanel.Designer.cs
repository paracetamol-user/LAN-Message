
namespace UI
{
    partial class ucVoicePanel
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
            this.PanelSend = new System.Windows.Forms.Panel();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.PanelDelete = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelSend
            // 
            this.PanelSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSend.Location = new System.Drawing.Point(94, 0);
            this.PanelSend.Name = "PanelSend";
            this.PanelSend.Size = new System.Drawing.Size(47, 47);
            this.PanelSend.TabIndex = 1;
            // 
            // panelRecord
            // 
            this.panelRecord.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRecord.Location = new System.Drawing.Point(47, 0);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(47, 47);
            this.panelRecord.TabIndex = 2;
            // 
            // PanelDelete
            // 
            this.PanelDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDelete.Location = new System.Drawing.Point(0, 0);
            this.PanelDelete.Name = "PanelDelete";
            this.PanelDelete.Size = new System.Drawing.Size(47, 47);
            this.PanelDelete.TabIndex = 3;
            // 
            // ucVoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelDelete);
            this.Controls.Add(this.panelRecord);
            this.Controls.Add(this.PanelSend);
            this.Name = "ucVoicePanel";
            this.Size = new System.Drawing.Size(141, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSend;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Panel PanelDelete;
    }
}
