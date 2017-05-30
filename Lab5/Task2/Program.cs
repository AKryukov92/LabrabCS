using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;
            String t;
            t = Console.ReadLine();
            p = int.Parse(t);
            t = Console.ReadLine();
            q = int.Parse(t);
            if (p > q)
            {
                Console.WriteLine("Максимальное {0}, минимальное {1}", p, q);
            }
            else
            {
                Console.WriteLine("Максимальное {1}, минимальное {0}", p, q);
            }
        }
    }
}
