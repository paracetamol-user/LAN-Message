using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
	public partial class Theme
	{
		private Color backColor;
		private Color focusColor;
		private Color textColor;
        private Color textMenuColor;
        private Color lineColor;
        private string pictureGroup;
        private string pictureOption;
        private string picturePlus;
        private string pictureMessage;
        private string pictureMenu;
        private string pictureSearch;
        private string pictureCmn;
        private string pictureCancel;
        private string pictureClose;
        private string pictureCheck;
        private bool isWhite;
		public Theme() { }
		public Theme(Color backColor ,  Color focusColor , Color textColor ) 
		{
			this.backColor = backColor;
			this.focusColor = focusColor;
			this.textColor = textColor;
		}
		public Color BackColor
        {
            get
            {
				return this.backColor;
            }
            set
            {
				this.backColor = value;
            }
        }
		public Color FocusColor
        {
            get
            {
				return this.focusColor;
            }
            set
            {
				this.focusColor = value;
            }
        }
		public Color TextColor
        {
            get
            {
                return this.textColor;
            }
            set
            {
                this.textColor = value;
            }
        }
        public Color TextMenuColor
        {
            get
            {
                return this.textMenuColor;
            }
            set
            {
                this.textMenuColor = value;
            }
        }
        public Color LineColor
        {
            get
            {
                return this.lineColor;
            }
            set
            {
                this.lineColor = value;
            }
        }

        public string PictureGroup
        {
            get
            {
                return this.pictureGroup;
            }
            set
            {
                this.pictureGroup = value;
            }
        }
        public string PictureOption
        {
            get
            {
                return this.pictureOption;
            }
            set
            {
                this.pictureOption = value;
            }
        }
        public string PictureMessage
        {
            get
            {
                return this.pictureMessage;
            }
            set
            {
                this.PictureMessage = value;
            }
        }
        public string PicturePlus
        {
            get
            {
                return this.picturePlus;
            }
            set
            {
                this.picturePlus = value;
            }
        }
        public string PictureMenu
        {
            get
            {
                return this.pictureMenu;
            }
            set
            {
                this.pictureMenu = value;
            }
        }
        public string PictureSearch
        {
            get
            {
                return this.pictureSearch;
            }
            set
            {
                this.pictureSearch = value;
            }
        }
        public string PictureCmn
        {
            get
            {
                return this.pictureCmn;
            }
            set
            {
                this.pictureCmn = value;
            }
        }
        public string PictureCancel
        {
            get
            {
                return this.pictureCancel;
            }
            set
            {
                this.pictureCancel = value;
            }
        }
        public string PictureClose
        {
            get
            {
                return this.pictureClose;
            }
            set
            {
                this.pictureClose = value;
            }
        }
        public string PictureCheck
        {
            get
            {
                return this.pictureCheck;
            }
            set
            {
                this.pictureCheck = value;
            }
        }
        public bool IsWhite
        {
            get
            {
                return this.isWhite;
            }
            set
            {
                this.isWhite = value;
            }
        }
        public void White()
        {
            isWhite = true;
            this.backColor = Color.White;
            this.focusColor = Color.FromArgb(242, 243, 245);
            this.textColor = Color.Black;
            this.textMenuColor = Color.DimGray;
            this.lineColor = Color.Gainsboro;
            pictureGroup = @"..\..\images\group-black.png";
            pictureOption = @"..\..\images\gear-option-black.png";
            picturePlus = @"..\..\images\plus-black.png";
            pictureMessage = @"..\..\images\message-black.png";
            pictureMenu = @"..\..\images\menu-black.png";
            pictureSearch = @"..\..\images\search-black.png";
            pictureCmn = @"..\..\images\cmn-black.png";
            pictureCancel = @"..\..\images\cancel-black.png";
            pictureClose = @"..\..\images\close-black.png";
            pictureCheck = @"..\..\images\check-black.png";
        }
        public void Black()
        {
            isWhite = false;
            this.backColor = Color.FromArgb(54, 57, 63);
            this.focusColor = Color.FromArgb(116, 127, 140);
            this.textColor = Color.White;
            this.textMenuColor = Color.WhiteSmoke;
            this.lineColor = Color.FromArgb(116, 127, 140); ;
            pictureGroup = @"..\..\images\group-white-1.png";
            pictureOption = @"..\..\images\gear-option-white-1.png";
            picturePlus = @"..\..\images\plus-white-1.png";
            pictureMessage = @"..\..\images\message-white-1.png";
            pictureMenu = @"..\..\images\menu-white-1.png";
            pictureSearch = @"..\..\images\search-white.png";
            pictureCmn = @"..\..\images\cmn-white.png";
            pictureCancel = @"..\..\images\cancel-white.png";
            pictureClose = @"..\..\images\close-white.png";
            pictureCheck = @"..\..\images\check-white.png";
        }
	}
}
