using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            double x, y;
            x = double.Parse(t1);
            y = 12*x*x+7*x-16;
            Console.WriteLine("{0:F4}", y);
        }
    }
}
