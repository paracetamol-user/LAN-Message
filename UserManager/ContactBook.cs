using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
	public partial class ContactBook
	{
		public List<User> listMember { get; set; }
		public string ID { get; set; }
		public string Name { get; set; }
		public ContactBook()
		{
			this.ID = ID;
			this.Name = Name;
		}
		public ContactBook(string ID, string Name)
		{
			this.ID = ID;
			this.Name = Name;
			listMember = new List<User>();
		}
		public void _AddMember(User newUser)
		{
			listMember.Add(newUser);
		}
		public void _RemoveMember(User removeUser)
		{
			listMember.Remove(removeUser);
		}
		public bool _IsInContactBook(User user)
		{
			if (listMember.Contains(user)) return true;
			return false;
		}
		public bool _IsInContactBook(string ID)
		{
			foreach (var item in listMember)
			{
				if (item.Id == ID) return true;
			}
			return false;
		}
	}
}
