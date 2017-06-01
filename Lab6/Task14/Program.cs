using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            int A = int.Parse(t1);
            string t2 = Console.ReadLine();
            int B = int.Parse(t2);
            long mult=1;//произведение
            int C;//разность чисел
            if (A < B)
            {
                C = B - A + 1;
                while (C > 0)
                {
                    mult = mult * A;
                    A = A + 1;
                    C = C - 1;
                }
                Console.WriteLine(mult);
            }
            else
            {
                C = A - B + 1;
                while (C > 0)
                {
                    mult=mult*B;
                    B = B + 1;
                    C = C - 1;
                }
                Console.WriteLine(mult);
            }
        }
    }
}
