using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class InfoByte
    {
        private int byteRead;
        private int length;
        private int allByteRead;
        private int nextPackageSize;
        string fileID;
        string name;
        string extension;
        byte[] dataFile;
        public InfoByte()
        {
            byteRead = 0;
            length = 0;
            this.allByteRead = 0;
            this.nextPackageSize = 0;

            this.dataFile = null;
            extension = "";
        }
        public InfoByte(int length)
        {
            this.byteRead = 0;
            this.allByteRead = 0;
            this.nextPackageSize = 0;
            this.length = length;
            extension = "";
        }
        public string Extension
        {
            get
            {
                return this.extension;
            }
            set
            {
                this.extension = value;
            }
        }
        public int ByteRead
        {
            get
            {
                return this.byteRead;
            }
            set
            {
                this.byteRead = value;
            }
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }
        public int AllByteRead
        {
            get
            {
                return this.allByteRead;
            }
            set
            {
                this.allByteRead = value;
            }
        }
        public int NextPackageSize
        {
            get
            {
                return this.nextPackageSize;
            }
            set
            {
                this.nextPackageSize = value;
            }
        }
        public string ID
        {
            get
            {
                return this.fileID;
            }
            set
            {
                this.fileID = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public byte[] DataFile
        {
            get
            {
                return this.dataFile;
            }
            set
            {
                this.dataFile = value;
            }
        }
    }
}
