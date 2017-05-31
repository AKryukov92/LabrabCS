using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            double b;
            if (x < 0)
            {
                Console.WriteLine("Значение x должно быть неотрицательным");
                return;
            }
            b = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
