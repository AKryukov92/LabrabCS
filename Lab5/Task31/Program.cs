using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            double A1, B1, A2, B2;
            t = Console.ReadLine();
            A1 = double.Parse(t);
            t = Console.ReadLine();
            B1 = double.Parse(t);
            t = Console.ReadLine();
            A2 = double.Parse(t);
            t = Console.ReadLine();
            B2 = double.Parse(t);
            if (A1>B1 || A2>B2)
            {
                Console.WriteLine("Значение A должно быть меньше значения B");
                return;
            }
            if (A2>B1||B2<A1)
            {
                Console.WriteLine("Не пересекаются");
            }
            else
            {
                if (A1 < A2 && A2 < B1 && B1 < B2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", A2, B1);
                    return;
                }
                if (A1 < A2 && A2 < B1 && B1 > B2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", A2, B2);
                    return;
                }
                if (A1 > A2 && A2 < B1 && B1 < B2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", A1, B1);
                    return;
                }
                if (A1 > A2 && A2 < B1 && B1 > B2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", A1, B2);
                    return;
                }

            }
        }
    }
}
