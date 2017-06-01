using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
                return;
            }
            while (i < n)
            {
                Console.Write("#");
                i++;
                if (i % 20 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
