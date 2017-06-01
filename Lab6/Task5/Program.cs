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
            String t1, B;
            t1 = Console.ReadLine();
            B = Console.ReadLine();
            int A;
            A = int.Parse(t1);
            int C=0;
            if (A<0)
            {
                Console.WriteLine("Значение А должно быть неотрицательным");
            }
            Console.Write("\"");
            while (C<A)
            {
                Console.Write(B);
                C = C + 1;
            }
            Console.Write("\"");
        }
    }
}
