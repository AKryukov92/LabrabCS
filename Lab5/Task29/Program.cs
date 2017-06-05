using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            double Xt, Yt, Xn, Yn, H, W;
            t = Console.ReadLine();
            Xt = double.Parse(t);//координаты точки
            t = Console.ReadLine();
            Yt = double.Parse(t);//координаты точки
            t = Console.ReadLine();
            Xn = double.Parse(t);//координаты верхнего левого угла 
            t = Console.ReadLine();
            Yn = double.Parse(t);//координаты верхнего левого угла 
            t = Console.ReadLine();
            H = double.Parse(t);//высота прямоугольника
            t = Console.ReadLine();
            W = double.Parse(t);//ширина прямоугольника
            if (Xt < 0 || Xn <0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }
            if (Yt < 0 || Yn < 0)
            {
                Console.WriteLine("Координата Y должна быть неотрицательной");
                return;
            }
            if (H <= 0)
            {
                Console.WriteLine("Высота должна быть положительна");
                return;
            }
            if (W <= 0)
            {
                Console.WriteLine("Ширина должна быть положительна");
                return;
            }
            if (Xt > Xn && Xt < Xn + W && Yt > Yn && Yt < Yn + H)
            { 
                Console.WriteLine("Точка внутри"); 
            }
            else {
                Console.WriteLine("Точка не внутри");
            }
        }
    }
}
