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
            double A, B, C;
            String t;
            t = Console.ReadLine();
            A = double.Parse(t);
            t = Console.ReadLine();
            B = double.Parse(t);
            t = Console.ReadLine();
            C = double.Parse(t);
            if (A <= 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (B <= 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательным");
                return;
            }
            if (C <= 0)
            {
                Console.WriteLine("Значение C должно быть неотрицательным");
                return;
            } 
            if (A == B || B == C || A == C)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }
        }
    }
}
