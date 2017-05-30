using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task30
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            double Xt, Yt, Xn1, Yn1, Xn2, Yn2;
            t = Console.ReadLine();
            Xt = double.Parse(t);//координаты точки
            t = Console.ReadLine();
            Yt = double.Parse(t);//координаты точки
            t = Console.ReadLine();
            Xn1 = double.Parse(t);//координаты прямой
            t = Console.ReadLine();
            Yn1 = double.Parse(t);//координаты прямой
            t = Console.ReadLine();
            Xn2 = double.Parse(t);//координаты прямой
            t = Console.ReadLine();
            Yn2 = double.Parse(t);//координаты прямой
            if (Xt < 0 || Xn1 < 0 || Xn2 <0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }
            if (Yt < 0 || Yn1 < 0 || Yn2 <0)
            {
                Console.WriteLine("Координата Y должна быть неотрицательной");
                return;
            }
            if ((Xt-Xn1)/(Xn2-Xn1)==(Yt-Yn1)/(Yn2-Yn1))
            {
                Console.WriteLine("Точка принадлежит прямой");
            } else {
                Console.WriteLine("Точка не принадлежит прямой");
            }
        }
    }
}
