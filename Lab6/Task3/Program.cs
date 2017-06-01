using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
            if (A > B)
            {
                Console.WriteLine("Значение А должно быть не больше значения B");
            }
            while (A<=B) {
            Console.WriteLine(A);
            A=A+1;
            }

        }
    }
}
