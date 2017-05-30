using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc, Ss, a, d;//Площадь круга, квадрата, сторона квадрата, диаметр круга
            String t;
            t = Console.ReadLine();
            Sc = double.Parse(t);
            t = Console.ReadLine();
            Ss = double.Parse(t);
            d = 2 * Math.Sqrt(Sc / Math.PI);// диаметр круга
            a = Math.Sqrt(Ss);// сторона квадрата
            if (Sc <=0 )
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            if (Ss <= 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }
            if (d <= a)
            {
                Console.WriteLine("Круг уместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }
        }
    }
}
