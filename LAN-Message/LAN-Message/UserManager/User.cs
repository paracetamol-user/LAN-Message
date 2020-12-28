using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
	public partial class User
	{
		private string name;
		private string id;
		private bool status;
		private string avatarPath;
		private bool isFriend;
		public User()
		{
			this.name = "";
			this.id = "";
			this.status = false;
		}
		public User(string name)
		{
			this.name =name;
			this.id = "";
			this.status = false;
		}
		public User(string id , string name, bool status)
		{
			this.name = name;
			this.id = id;
			this.status = status ;
			this.avatarPath = "";
		}
		public User(string id, string name, bool status, string path)
		{
			this.name = name;
			this.id = id;
			this.status = status;
			this.avatarPath = path;
			this.isFriend = false;
		}
		public string AvatarPath
		{
			get
			{
				return this.avatarPath;
			}
			set
			{
				this.avatarPath = value;
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
		public string Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}
		public bool Status
		{
			get
			{
				return this.status;
			}
			set
			{
				this.status = value;
			}
		}
		public bool IsFriend
		{
			get
			{
				return this.isFriend;
			}
            set
            {
				this.isFriend = value;
            }
		}
	}
}
