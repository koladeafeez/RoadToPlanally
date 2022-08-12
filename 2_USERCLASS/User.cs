using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_USERCLASS
{
    public class User
    {
        private string Name { get; set; }
        private List<User> Users 
        { get 
            { 
                return MemStorage.Instance.Users; 
            } 
        }


        public void Add(string name)
        {
            this.Name = name;
            Users.Add(this);
        }

        public int GetUsersCount()
        {
            return Users.Count;
        }



    }
}

