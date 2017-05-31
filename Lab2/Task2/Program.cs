using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double c;
            if (a <= 0)//если а имеет некорректное значение
            {
                Console.WriteLine("Значение A должно быть положительным");//Выводим ошибку
                return;//Завершаем работу программы
            }
            c = 6 * a * a;
            Console.WriteLine("{0:F4}", c);
        }
    }
}
