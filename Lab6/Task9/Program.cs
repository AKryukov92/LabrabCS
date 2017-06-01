using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b;
            while (a<10)
            {
                b = a * 7;
                Console.WriteLine("{0}*7={1}", a, b);
                a = a + 1;
            }
        }
    }
}
