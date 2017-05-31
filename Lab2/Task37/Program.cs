using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
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
            double V1, T1, V2, T2, V, T;
            V1 = double.Parse(t1);
            T1 = double.Parse(t2);
            V2 = double.Parse(t3);
            T2 = double.Parse(t4);
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
            if (V1 == 0 && V2 == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен 0");
                return;
            }
            V=V1+V2;
            T = (T1 * V1 + T2 * V2) / (V1 + V2);
            Console.WriteLine("{0:F4}", V);
            Console.WriteLine("{0:F4}", T);
        }
    }
}
