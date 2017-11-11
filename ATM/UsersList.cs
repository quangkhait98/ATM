using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    [Serializable]
    public class UsersList
    {

        List<Users> item;

        public List<Users> Item
        {
            get { return item; }
            set { item = value; }
        }

        public UsersList()
        {
            item = new List<Users>();
        }

        public void Add(Users user)
        {
            item.Add(user);
        }
    }
}
