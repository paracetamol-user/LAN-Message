using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
namespace UI
{
    public partial class PanelFile : UserControl
    {
        private Panel panelListFile;
        private List<FileInfo> files;
        private FileInfo fileInfo;
        private string fileId;
        public PanelFile()
        {
            InitializeComponent();
        }
        public PanelFile(Panel panelListFile , List<FileInfo> files, FileInfo fileInfo)
        {
            InitializeComponent();
            this.panelListFile = panelListFile;
            this.files = files;
            this.fileInfo = fileInfo;
        }
        public string _FileName
        {
            get
            {
                return this.labelFileName.Text;
            }
            set
            {
                this.labelFileName.Text = value;
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (panelListFile.Contains(this))
            {
                panelListFile.Controls.Remove(this);
            }
            this.files.Remove(fileInfo);
            if (this.panelListFile.Controls.Count < 1) this.panelListFile.Visible = false;
        }
    }
}
