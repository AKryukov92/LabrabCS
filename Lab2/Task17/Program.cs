using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1= Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double V1;
            V1 = double.Parse(t1);
            double V2;
            V2 = double.Parse(t2);
            double S;
            S = double.Parse(t3);
            double T;
            if (V1 <= 0)
            {
                Console.WriteLine("Значение V1 должно быть неотрицательным");
                return;
            }
            if (V2 <= 0)
            {
                Console.WriteLine("Значение V2 должно быть неотрицательным");
                return;
            }
            T = S / (V1 + V2);
            Console.WriteLine("{0:F4}", T);
        }
    }
}
