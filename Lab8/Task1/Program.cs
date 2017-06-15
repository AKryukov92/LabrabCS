using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] sarr;//объявляем массив
            sarr = t.Split(' ');
            int l = sarr.Length;
            if (A >= l || A < 0)
            {
                Console.WriteLine("Число A должно быть в интервале [0, {0})", l);
                return;
            }
            if (t == "")
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            Console.WriteLine(sarr[A]);//выводим на экран элемент под индексом А
        }
    }
}

