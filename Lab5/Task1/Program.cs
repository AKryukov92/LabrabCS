using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String t;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            if (a < b)
            {
                Console.WriteLine("Второе");
            }
            else
            {
                Console.WriteLine("Первое");
            }
        }
    }
}
