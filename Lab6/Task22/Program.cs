using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int i = 1;
            if (y > 15 || y<0)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }
            while (i <=15)
            {
                if (i <= y)
                {
                    Console.Write("#");
                }
                if (i > y)
                {
                    Console.Write(".");
                }
                i++;
            }
        }
    }
}
