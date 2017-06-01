using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            if (x<=0) {
                Console.WriteLine("Значение X должно быть положительным");
                return;
            }
            while (i <= x)
            {
                if (x % i == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}
