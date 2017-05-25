using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double m;
            m = double.Parse(t1);
            double v;
            v = double.Parse(t2);
            double h;
            h = double.Parse(t3);
            double T, W;
            double g=9.8067;
            T=m*v*v/2;
            W = m * g * h;
            Console.WriteLine("{0:F4}", T);
            Console.WriteLine("{0:F4}", W);
        }
    }
}
