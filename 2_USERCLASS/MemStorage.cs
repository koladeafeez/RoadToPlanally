using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_USERCLASS
{
    public class MemStorage
    {
        private static MemStorage instance = null;
        public List<User> Users = new List<User>();

        private static object applock = new object();


        public static MemStorage Instance
        {
            get
            {
                lock (applock)
                {
                    if (instance == null)
                        instance = new MemStorage();
                    
                    return instance;
                }
            }
        }
    }
}
