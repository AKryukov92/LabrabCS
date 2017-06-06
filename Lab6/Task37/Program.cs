using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
    class Program
    {
        static void Main(string[] args)
        {
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
            while (j < H)
            {
                i = 0;
                while (i < W - j)
                {
                    Console.Write("+");
                    i++;
                }
                i = 0;
                while (i < j)
                {
                    Console.Write("#");
                    i++;
                }
                j++;
                Console.WriteLine();
                }
            }
        }
    }

