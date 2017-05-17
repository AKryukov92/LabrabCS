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
            string msg;
            msg=Console.ReadLine();
            double a;//Объявляем переменную для дробного числа
            a=double.Parse(msg);//Преобразовываем текст в число
            Console.WriteLine("{0:F4}",a);// Округляем до 4 знаков после запятой

        }
    }
}
