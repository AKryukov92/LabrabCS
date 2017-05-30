using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A;
            String t;
            t = Console.ReadLine();
            R = double.Parse(t);
            t = Console.ReadLine();
            A = double.Parse(t);
            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (R < 0)
            {
                Console.WriteLine("Значение R должно быть неотрицательным");
                return;
            }
            if (A*A > Math.PI*R*R)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
            else
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
        }
    }
}
