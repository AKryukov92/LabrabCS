using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double L, P;
            String t;
            t = Console.ReadLine();
            L = double.Parse(t);
            t = Console.ReadLine();
            P = double.Parse(t);
            if (L < 0)
            {
                Console.WriteLine("Значение L должно быть неотрицательным");
                return;
            }
            if (P < 0)
            {
                Console.WriteLine("Значение P должно быть неотрицательным");
                return;
            }
            if (L*1000 < P*0.305)
            {
                Console.WriteLine("Расстояние в километрах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в футах меньше");
            }
        }
    }
}
