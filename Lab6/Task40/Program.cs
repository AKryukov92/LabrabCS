using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1 = Console.ReadLine();
            string S2 = Console.ReadLine();
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int i=0;
            int j=0;
            if (W < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (H < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            while (i < H)
            {
                if (i % 2 == 0)
                {
                    while (j < W)
                    {
                        Console.Write(S1);
                        j++;
                    }
                }
                else
                {
                    while (j < W)
                    {
                        Console.Write(S2);
                        j++;
                    }
                }
                Console.Write("\n");
                j = 0;
                i++;
            }
        }
    }
}
