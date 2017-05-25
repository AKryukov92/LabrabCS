using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3, t4;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            double a, b, c, d, R;
            a = double.Parse(t1);
            b = double.Parse(t2);
            c = double.Parse(t3);
            d = double.Parse(t4);
            R=(a*d+b*c)/(a*d);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
