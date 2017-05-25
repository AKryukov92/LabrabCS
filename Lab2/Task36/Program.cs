using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
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
            double xa, ya, xb, yb, R;
            xa = double.Parse(t1);
            ya = double.Parse(t2);
            xb = double.Parse(t3);
            yb = double.Parse(t4);
            R = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
