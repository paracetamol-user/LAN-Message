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
        public User()
        {
            this.name = "";
            this.id = "";
        }
        public User(string name)
        {
            this.name =name;
            this.id = "";
        }
        public User(string name , string id)
        {
            this.name = name;
            this.id = id;
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
    }
}
