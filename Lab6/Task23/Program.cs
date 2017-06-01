using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            int A = int.Parse(t1);
            string t2 = Console.ReadLine();
            int B = int.Parse(t2);
            int sum = 0;
            if (A < B)
            {
                while (A <= B)
                {
                    if (A % 7 == 0)
                    {
                        sum = sum + A;
                    }
                    A++;
                }
                Console.WriteLine(sum);
            }
            else
            {
                while (B<=A)
                {
                    if (B % 7 == 0)
                    {
                        sum = sum + B;
                    }
                    B++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
