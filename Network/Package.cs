using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public partial class Package
    {
		public string IDsend { get; set; }
		public string IDreceive { get; set; }
		public int Ack { get; set; }
		public int Length { get; set; }
		public string Style { get; set; }
		public string FileName { get; set; }
		public string Extension { get; set; }
		public byte[] Data { get; set; }
		public string IDpackage { get; set; }
		public bool isPrivate { get; set; }
		public Package() { }
		public Package(string idsend, string idreceive, int ack, int length, string style, string filename, string extension, string idpackage, bool isPrivate)
		{
			this.IDsend = idsend;
			this.IDreceive = idreceive;
			this.Ack = ack;
			this.Length = length;
			this.Style = style;
			this.FileName = filename;
			this.Extension = extension;
			this.IDpackage = idpackage;
			this.Data = new byte[this.Length];
			this.isPrivate = isPrivate;
		}
	}
}
