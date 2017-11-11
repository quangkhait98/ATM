using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Users
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        float balance;

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Users()
        { }

        public Users(int id, string name, string username, string password, int age, float balance)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
            this.age = age;
            this.balance = balance;
        }
    }
}

