using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB {
    public class SingletonDB {
        private static DBconnImpl db = null;
        private static SingletonDB singleDb = null;

        private SingletonDB(string username, string password) {
            db = new DBconnImpl();
        }

        public static bool isOpen() {
            return (null != db);
        }

        public static SingletonDB getInstance(string username, string password) {
            lock (typeof(SingletonDB))
            {
                if (null == db)
                {
                    Console.WriteLine("Open database...");
                    singleDb = new SingletonDB(username, password);
                }

                db.connect(username, password);
                Console.WriteLine("Database connected.");

                return singleDb;
            }
        }

        public static SingletonDB getInstance() {
            if (null == db)
            {
                throw new Exception("Database not opened");
            }

            return singleDb;
        }

        public void create(string tableName)  {
            db.create(tableName);
        }

        public User query(string tableName, int rowId)
        {
            if (null == db)
            {
                Console.WriteLine("Error: Database not opened");

                return null;
            }

            return db.query(tableName, rowId);
        }

        public void update(string tableName, User user)
        {
            if (null == db)
            {
                Console.WriteLine("Error: Database not opened");

                return;
            }

            db.update(tableName, user);
        }
    }
}
