using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass, host, port, db;
            user = Console.ReadLine();
            pass = Console.ReadLine();
            host = Console.ReadLine();
            port = Console.ReadLine();
            db = Console.ReadLine();
            Console.WriteLine("User ID={0}; Password={1}; Host={2}; Port={3}; Data_base={4}", user, pass, host, port, db);
        }
    }
}
