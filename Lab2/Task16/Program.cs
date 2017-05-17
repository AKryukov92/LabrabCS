using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            double a;
            a = double.Parse(t1);
            t2 = Console.ReadLine();
            double b;
            b = double.Parse(t2);
            double c;
            c = -5* Math.Sqrt(a+Math.Sqrt(b));
            Console.WriteLine("{0:F4}", c);
        }
    }
}
