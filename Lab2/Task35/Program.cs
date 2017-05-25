using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double x1, x2, R;
            x1 = double.Parse(t1);
            x2 = double.Parse(t2);
            R = Math.Sqrt(x2 * x2 + x1 * x1);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
