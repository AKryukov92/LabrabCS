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
            string t1 = Console.ReadLine();
            int A = int.Parse(t1);
            string t2 = Console.ReadLine();
            int B = int.Parse(t2);
            long sum = 0;
            int C;//разность чисел
            if (A < B)
            {
                C = B - A + 1;
                while (C > 0)
                {
                    sum = sum + A*A;
                    A = A + 1;
                    C = C - 1;
                }
                Console.WriteLine(sum);
            }
            else
            {
                C = A - B + 1;
                while (C > 0)
                {
                    sum = sum + B*B;
                    B = B + 1;
                    C = C - 1;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
