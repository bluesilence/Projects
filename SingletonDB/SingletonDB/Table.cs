using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB
{
    public class Table
    {
        private Dictionary<int, User> table;
        public string tableName { get; private set; }

        public Table(string name) {
            tableName = name;
            table = new Dictionary<int,User>();
        }

        public User query(int id) {
            if (table.ContainsKey(id)) {
                return table[id];
            } else {
                Console.WriteLine("User with id {0} doesn't exist in Table [{1}]", id, tableName);
                return null;
            }
        }

        public void update(User user) {
            table[user.id] = user;
            Console.WriteLine("User {0} updated with id {1} successfully.", user.name, user.id);
        }
    }
}
