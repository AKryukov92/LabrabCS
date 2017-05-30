using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            double a, b, c, d;
            t = Console.ReadLine();
            a = double.Parse(t);
            t = Console.ReadLine();
            b = double.Parse(t);
            t = Console.ReadLine();
            c = double.Parse(t);
            t = Console.ReadLine();
            d = double.Parse(t);
            if (a<=0)
            {
                Console.WriteLine("Значение a должно быть неотрицательным");
                return;
            }
            if (b <= 0)
            {
                Console.WriteLine("Значение b должно быть неотрицательным");
                return;
            }
            if (c <= 0)
            {
                Console.WriteLine("Значение c должно быть неотрицательным");
                return;
            }
            if (d <= 0)
            {
                Console.WriteLine("Значение d должно быть неотрицательным");
                return;
            }
            if (a<=c && b<=d)
            {
                Console.WriteLine("Размещение возможно");
            } else {
                Console.WriteLine("Размещение невозможно");
            }

        }
    }
}
