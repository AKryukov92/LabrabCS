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
            string msg;
            msg = Console.ReadLine();
            int a;//Объявляем переменную для дробного числа
            a = int.Parse(msg);//Преобразовываем текст в число
            Console.WriteLine("\"{0}\"", a);
        }
    }
}
