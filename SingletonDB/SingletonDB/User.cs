using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB
{
    public class User
    {
        public string name
        {
            get;
            private set;
        }

        public int id
        {
            get;
            private set;
        }

        public int age
        {
            get;
            private set;
        }

        public User(int id, string name, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", name, age);
        }
    }
}
