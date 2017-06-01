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
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            int A, B;
            A = int.Parse(t1);
            B = int.Parse(t2);
            if (A < B)
            {
                while (A <= B)
                {
                    Console.Write(A + " ");
                    A = A + 1;
                }
            }
            else  {
                while (A >= B)
                {
                    Console.Write(B + " ");
                    B = B + 1;
                }
            }

        }
    }
}
