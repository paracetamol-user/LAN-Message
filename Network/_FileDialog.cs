using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network
{
    public partial class _FileDialog
    {
		public void SaveFile(byte[] buffer, string fileName)
		{
			System.IO.Stream fs = new MemoryStream();

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Images (*.BMP;*.JPG;*.PNG) | *.BMP;*.JPG;*.PNG |" + "All files (*.*)|*.*";
			saveFileDialog.Title = "Save File";
			saveFileDialog.InitialDirectory = @"C:\";
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.FileName = fileName;
			
			if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
			{
				fs = (Stream)saveFileDialog.OpenFile();
				fs.Write(buffer, 0, buffer.Length);
				fs.Close();
			}
		}
	}
}
