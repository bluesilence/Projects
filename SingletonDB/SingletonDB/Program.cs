using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserController uc1 = new UserController("quinzh", "test");
            UserController uc2 = new UserController();
            UserController uc3 = new UserController();

            string tableName = "SunnyFun";
            uc1.createTable(tableName);
            uc2.saveUser(tableName, 1, "Sunny", 20);
            Console.WriteLine(uc3.getUser(tableName, 2));
        }
    }
}
