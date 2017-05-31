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
            double x;
            x = double.Parse(t1);
            t2 = Console.ReadLine();
            double y;
            y = double.Parse(t2);
            double c;
            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            if (x + Math.Sqrt(y) < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            c = -5* Math.Sqrt(x+Math.Sqrt(y));
            Console.WriteLine("{0:F4}", c);
        }
    }
}
