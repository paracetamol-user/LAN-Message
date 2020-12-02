using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
    public class Group
    {
        private string name;
        private string id;
        private string avatarPath;
        List<User> memberList;
        User admin;
        // Constructors
        public Group()
        {
            this.name = string.Empty;
            this.id = string.Empty;
            this.avatarPath = string.Empty;
            this.memberList = null;
            this.admin = null;
        }
        public Group(string name)
        {
            this.name = name;
            this.id = string.Empty;
            this.avatarPath = string.Empty;
            this.memberList = null;
            this.admin = null;
        }
        public Group(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.avatarPath = string.Empty;
            this.memberList = null;
            this.admin = null;
        }
        public Group(string id, string name, string avatarPath)
        {
            this.id = id;
            this.name = name;
            this.avatarPath = avatarPath;
            this.memberList = null;
            this.admin = null;
        }
        public Group(string id, string name, string avatarPath, User admin)
        {
            this.id = id;
            this.name = name;
            this.avatarPath = avatarPath;
            this.admin = admin;
        }
        // Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
        public string AvatarPath
        {
            get
            {
                return avatarPath;
            }
            set
            {
                this.avatarPath = value;
            }
        }
        // Get admin
        public User GetAdmin() => this.admin;
        // Get member list
        public List<User> GetMembers() => this.memberList;
        // Add member to group
        public void AddMember(User member) => memberList.Add(member);
        // Kick member
        public void DeleteMember(User member) => memberList.Remove(member);

    }
}
