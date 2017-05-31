using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            String t2;
            t2 = Console.ReadLine();
            double a;
            a = double.Parse(t1);
            double h;
            h = double.Parse(t2);
            double s;
            if (a <= 0)
            {
                Console.WriteLine("Значение а должно быть положительным");
                return;
            }
            if (h <= 0)
            {
                Console.WriteLine("Значение h должно быть положительным");
                return;
            }
            s = a*h/2;
            Console.WriteLine("{0:F4}", s);
        }
    }
}
