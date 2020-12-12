using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
	public partial class SmallPackage
    {
		public int Seq { get; set; }
		public int Length { get; set; }
		public string Style { get; set; }
		public byte[] Data { get; set; }
		public string ID { get; set; }
		public SmallPackage()
		{
			this.Data = new byte[964];
		}
		public SmallPackage(int seq, int length, string style, byte[] data, string id)
		{

			this.Seq = seq;
			this.Length = length;
			this.Style = style;
			this.Data = data;
			this.ID = id;
		}
		public byte[] Packing()
		{
			byte[] package = new byte[1024];
			byte[] tempbuff;
			tempbuff = Encoding.UTF8.GetBytes(Seq.ToString());
			tempbuff.CopyTo(package, 0);
			tempbuff = Encoding.UTF8.GetBytes(Length.ToString());
			tempbuff.CopyTo(package, 8);
			tempbuff = Encoding.UTF8.GetBytes(Style);
			tempbuff.CopyTo(package, 16);
			tempbuff = Encoding.UTF8.GetBytes(ID);
			tempbuff.CopyTo(package, 24);
			Data.CopyTo(package, 60);
			return package;
		}
		public void DividePackage(byte[] package)
		{
			this.Seq = int.Parse(Encoding.UTF8.GetString(package, 0, 8).Trim('\0', '\t', '\r', '\n'));
			this.Length = int.Parse(Encoding.UTF8.GetString(package, 8, 8).Trim('\0', '\t', '\r', '\n'));
			this.Style = Encoding.UTF8.GetString(package, 16, 8).Trim('\0', '\t', '\r', '\n');
			this.ID = Encoding.UTF8.GetString(package, 24, 36).Trim('\0', '\t', '\r', '\n');
			Buffer.BlockCopy(package, 60, Data, 0, 964);
		}
	}
}
