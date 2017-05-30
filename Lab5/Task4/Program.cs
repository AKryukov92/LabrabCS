using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            String t;
            t = Console.ReadLine();
            A = int.Parse(t);
            if (A >= 0)
            {

                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(-1*A);
            }
        }
    }
}
