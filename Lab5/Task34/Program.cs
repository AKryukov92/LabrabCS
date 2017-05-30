using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int W, H, C, D;
            t = Console.ReadLine();
            W = int.Parse(t);
            t = Console.ReadLine();
            H = int.Parse(t);
            t = Console.ReadLine();
            C = int.Parse(t);
            t = Console.ReadLine();
            D = int.Parse(t);
            if (W <= 0)
            {
                Console.WriteLine("Значение W должно быть положительным");
                return;
            }
            if (H <= 0)
            {
                Console.WriteLine("Значение H должно быть положительным");
                return;
            }
            if (C <= 0)
            {
                Console.WriteLine("Значение C должно быть положительным");
                return;
            }
            if (D <= 0)
            {
                Console.WriteLine("Значение D должно быть положительным");
                return;
            }
            if (C<=D)
            {
                Console.WriteLine("Значение C должно быть больше D");
                return;
            }
            double S1 = (H / C) * (W / D);//Сколько прямоугольников поместится, если разместить стороной C вдоль стороны H
            double S2 = (W / C) * (H / D);//Сколько прямоугольников поместится, если разместить стороной C вдоль стороны W
            if (S1 > S2)
            {
                Console.WriteLine("{0} при С вдоль Н", S1);
            }
            else
            {
                Console.WriteLine("{0} при С вдоль W", S2);
            }
        }
    }
}
