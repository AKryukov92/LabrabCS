using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            double x, y;
            x = double.Parse(t1);
            y = 7*x*x-3*x+6;
            Console.WriteLine("{0:F4}", y);
        }
    }
}
