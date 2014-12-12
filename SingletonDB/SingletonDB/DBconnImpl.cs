using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB
{
    public class DBconnImpl
    {
        private Dictionary<string, Table> tables;
        private bool connected;

        private string username;
        private string password;

        public DBconnImpl()
        {
            tables = new Dictionary<string, Table>();
            this.username = "quinzh";
            this.password = "test";
            connected = false;
        }

        public bool connect(string username, string password)
        {
            if (connected)
            {
                throw new Exception("Error: Database already opened.");
            }

            if (this.username != username || this.password != password)
            {
                Console.WriteLine("Incorrect username or password.");
                return false;
            }

            connected = true;
            return true;
        }

        public void create(string tableName) {
            if (!connected) {
                throw new Exception("Error: Database not opened.");
            }

            if (tables.ContainsKey(tableName)) {
                Console.WriteLine("Table {0} already exists.", tableName);
            }

            tables[tableName] = new Table(tableName);
        }

        public User query(string tableName, int rowId) {
            if (!connected)
            {
                throw new Exception("Error: Database not opened.");
            }

            if (!tables.ContainsKey(tableName)) {
                Console.WriteLine("Table {0} doesn't exist.", tableName);
                return null;
            }

            return tables[tableName].query(rowId);
        }

        public void update(string tableName, User user) {
            if (!connected) {
                throw new Exception("Error: Database not opened.");
            }

            if (!tables.ContainsKey(tableName)) {
                Console.WriteLine("Table {0} doesn't exist.", tableName);
            }

            tables[tableName].update(user);
        }

        public bool disconnect() {
            if (!connected) {
                throw new Exception("Error: Database not opened.");
            }

            connected = false;
            return true;
        }
    }
}
