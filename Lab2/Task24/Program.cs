using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
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
            double y, m1, m2, r, C;
            y = double.Parse(t1);
            m1 = double.Parse(t2);
            m2 = double.Parse(t3);
            r = double.Parse(t4);
            if (r == 0)
            {
                Console.WriteLine("Значение r должно быть не равно нулю");
                return;
            }
            C = y * m1 * m2 / (r * r);
            Console.WriteLine("{0:F4}", C);
        }
    }
}
