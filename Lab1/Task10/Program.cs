using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg1, msg2;
            msg1 = Console.ReadLine();
            msg2 = Console.ReadLine();
            Console.WriteLine("INSERT INTO points (x, y) VALUES ('{0}', '{1}')", msg1, msg2);
        }
    }
}
