﻿using System;
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
		private Color myMess;
		private Color peopleMess;
		private Color menu;
		private Color txtBackColor;
		private Color txtForeColor;
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
		public string pictureCircleOnline { get; set; }
		public string pictureCircleOffline { get; set; }
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
		public Color MyMess
		{
			get
			{
				return this.myMess;
			}
			set
			{
				this.myMess = value;
			}
		}
		public Color PeopleMess
		{
			get
            {
				return this.peopleMess;
            }
            set
            {
				this.peopleMess = value;
            }
		}
		public Color Menu
        {
			get
            {
				return this.menu;
            }
            set
            {
				this.menu = value;
            }
        }
		public Color TxtBackColor
        {
            get
            {
				return this.txtBackColor;
            }
			set
            {
				this.txtBackColor = value;
            }
        }
		public Color TxtForeColor
        {
            get
            {
				return this.txtForeColor;
            }
            set
            {
				this.txtForeColor = value;
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
			this.focusColor = Color.FromArgb(212, 215, 220);
			this.textColor = Color.Black;
			this.textMenuColor = Color.DimGray;
			this.lineColor = Color.Gainsboro;
			this.myMess = Color.AliceBlue;
			this.peopleMess = focusColor;
			this.menu = Color.FromArgb(242, 243, 245);
			this.txtBackColor = menu;
			this.txtForeColor = Color.Black;
			pictureGroup = @"..\..\images\group-white.png";
			pictureOption = @"..\..\images\gear-option-black.png";
			picturePlus = @"..\..\images\plus-black.png";
			pictureMessage = @"..\..\images\message-black.png";
			pictureMenu = @"..\..\images\menu-black.png";
			pictureSearch = @"..\..\images\search-black.png";
			pictureCmn = @"..\..\images\menu-black.png";
			pictureCancel = @"..\..\images\cancel-black.png";
			pictureClose = @"..\..\images\close-black.png";
			pictureCheck = @"..\..\images\check-black.png";
			pictureCircleOnline = @"..\..\images\circle-blue.png";
			pictureCircleOffline = @"..\..\images\circle-black.png";
		}
		public void Black()
		{
			isWhite = false;
			this.backColor = Color.FromArgb(54, 57, 63);
			this.focusColor = Color.FromArgb(64, 68, 75);
			this.textColor = Color.White;
			this.textMenuColor = Color.WhiteSmoke;
			this.lineColor = Color.FromArgb(64, 68, 75);
			this.myMess = Color.DimGray;
			this.peopleMess = Color.DimGray;
			this.TxtBackColor = focusColor;
			this.txtForeColor = Color.White;
			pictureGroup = @"..\..\images\group-white-1.png";
			pictureOption = @"..\..\images\gear-option-white-1.png";
			picturePlus = @"..\..\images\plus-white-1.png";
			pictureMessage = @"..\..\images\message-white-1.png";
			pictureMenu = @"..\..\images\menu-white-1.png";
			pictureSearch = @"..\..\images\search-white.png";
			pictureCmn = @"..\..\images\menu-white-1.png";
			pictureCancel = @"..\..\images\cancel-white.png";
			pictureClose = @"..\..\images\close-white.png";
			pictureCheck = @"..\..\images\check-white.png";
			pictureCircleOnline = @"..\..\images\circle-blue.png";
			pictureCircleOffline = @"..\..\images\circle-black.png";
			this.menu = Color.FromArgb(47, 49, 54);
		}
	}
}