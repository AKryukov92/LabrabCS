using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;
            int sum = 0;
            while (a <= b)
            {
                sum = sum + a;
                a = a + 1;
            }
            Console.WriteLine(sum);
        }
    }
}
