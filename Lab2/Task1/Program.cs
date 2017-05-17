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
            String t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            double c;
            c = x + 7;
            Console.WriteLine("{0:F4}", c);
        }
    }
}
