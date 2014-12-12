using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB
{
    public class UserController
    {
        SingletonDB db;

        public UserController(string user, string pw)
        {
            if (!SingletonDB.isOpen())
            {
                db = SingletonDB.getInstance(user, pw);
            }
            else
            {
                Console.WriteLine("Database already opened.");
            }
        }

        public UserController()
        {
            if (SingletonDB.isOpen())
            {
                db = SingletonDB.getInstance();
            }
            else
            {
                Console.WriteLine("Database not opened.");
            }
        }

        public void createTable(string tableName)
        {
            db.create(tableName);
        }

        public void saveUser(string table, int id, string name, int age)
        {
            db.update(table, new User(id, name, age));
        }

        public User getUser(string table, int id)
        {
            return db.query(table, id);
        }
    }
}
