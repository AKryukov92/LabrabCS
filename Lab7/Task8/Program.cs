using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            string t = "abcdefwxyz";
            int CA = int.Parse(Console.ReadLine());
            int CB = int.Parse(Console.ReadLine());
            int CC = CA + CB;//индекс конечного символа в удаляемом отрезке
            int l=t.Length;
            int k = l - CC;//длина конечного отрезка
            if (CA >= l)
            {
                Console.WriteLine("Значение CA должно быть в интервале [0, {0})", l);
                return;
            }
            if (CB < 0)
            {
                Console.WriteLine("Значение CB должно быть неотрицательно");
                return;
            }
            if (CA + CB >=l)
            {
                Console.WriteLine("Сумма значений CA и CB должна быть меньше длины строки");
                return;
            }
            Console.Write(t.Substring(0,CA));
            Console.Write(t.Substring(CC, k));
        }
    }
}
