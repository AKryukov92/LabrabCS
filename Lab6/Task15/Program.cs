using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int cub=0;
            while (a <= 40)
            {
                cub = cub + a * a * a;
                a = a + 1;
            }
            Console.WriteLine(cub);
        }
    }
}
