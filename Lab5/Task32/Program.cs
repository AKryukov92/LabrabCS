using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double x1, y1, h1, w1, x2, y2, h2, w2;
            t = Console.ReadLine();
            x1 = double.Parse(t);//верхний левый угол прямоугольника 1
            t = Console.ReadLine();
            y1 = double.Parse(t);//верхний левый угол прямоугольника 1
            t = Console.ReadLine();
            h1 = double.Parse(t);//высота прямоугольника 1
            t = Console.ReadLine();
            w1 = double.Parse(t);//ширина прямоугольника 1
            t = Console.ReadLine();
            x2 = double.Parse(t);//верхний левый угол прямоугольника 2
            t = Console.ReadLine();
            y2 = double.Parse(t);//верхний левый угол прямоугольника 2
            t = Console.ReadLine();
            h2 = double.Parse(t);//высота прямоугольника 2
            t = Console.ReadLine();
            w2 = double.Parse(t);//ширина прямоугольника 2
            double w3; //ширина прямоугольника, образующегося при пересечении
            double h3; //высота прямоугольника, образующегося при пересечении
            double z1, z2, k1, k2;
            z1 = x1 + w1;//координата по оси Х правого верхнего угла прямоугольника 1
            z2 = x2 + w2;//координата по оси X правого верхнего угла прямоугольника 2
            k1 = y1 + h1;//координата по оси Y правого верхнего угла прямоугольника 1
            k2 = y2 + h2;//координата по оси Y правого верхнего угла прямоугольника 2
            if (x1 < 0 || x2 < 0)
            {
                Console.WriteLine("Значение х должно быть неотрицательным");
                return;
            }
            if (y1 < 0 || y2 < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            if (h1 <= 0 || h2 <= 0)
            {
                Console.WriteLine("Значение h должно быть положительным");
                return;
            }
            if (w1 <= 0 || w2 <= 0)
            {
                Console.WriteLine("Значение w должно быть положительным");
                return;
            }
            if (x2 >= z1 || y2 >= k1 || z2 <= x1 || k2 <= y1)
            {
                Console.WriteLine(" Не пересекаются");
            }
            else
            {
                if (x1 <= x2 && x2 < z1 && z1 <= z2)
                {
                    if (y1 <= y2 && y2 < k1 && k1 <= k2)
                    {
                    w3 = z1-x2;
                    h3 = k1-y2;
                    Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                    return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                }
                if (x1 <= x2 && x2 < z1 && z1 >= z2)
                {
                    if (y1 <= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                }
                if (x1 >= x2 && x2 < z1 && z1 <= z2)
                {
                    if (y1 < y2 && y2 < k1 && k1 < k2)
                    {
                        w3 = z1 - x1;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x1;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z1 - x1;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x1;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                }
                if (x1 >= x2 && x2 < z1 && z1 >= z2)
                {
                    if (y1 <= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                }
            }
        }
    }
}
