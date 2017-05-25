using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double a, b, c, d;
            a = double.Parse(t1);
            b = double.Parse(t2);
            c = double.Parse(t3);
            d = b * b - 4 * a * c;
            Console.WriteLine("{0:F4}", d);
        }
    }
}
