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
            double V1, V2;
            String t;
            t = Console.ReadLine();
            V1 = double.Parse(t);
            t = Console.ReadLine();
            V2 = double.Parse(t);
            if (V1 < 0)
            {
                Console.WriteLine("Значение V1 должно быть неотрицательным");
                return;
            }
            if (V2 < 0)
            {
                Console.WriteLine("Значение V2 должно быть неотрицательным");
                return;
            }
            if (V1 * 1000/3600 > V2)
            {
                Console.WriteLine("V2 (км/ч) меньше V1 (м/с)");
            }
            else
            {
                Console.WriteLine("V1 (м/с) меньше V2(км/ч)");
            }
        }
    }
}
