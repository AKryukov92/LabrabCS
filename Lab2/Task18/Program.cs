using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double x1;
            x1 = double.Parse(t1);
            double x2;
            x2 = double.Parse(t2);
            double x3;
            x3 = double.Parse(t3);
            double R;
            R = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine("{0:F4}", R);
        }
    }
}
