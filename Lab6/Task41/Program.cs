using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1 = Console.ReadLine();
            string S2 = Console.ReadLine();
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
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
                while (j < W)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(S1);
                    }
                    else
                    {
                        Console.Write(S2);
                    }
                    j++;
                }
                j = 0;
                i++;
                Console.WriteLine();
            }
        }
    }
}
