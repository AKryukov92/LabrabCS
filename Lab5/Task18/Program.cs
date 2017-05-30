using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int a = int.Parse(t);
            if (a < 1000 || a > 9999)
            {
                Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
                return;
            }
            if ((a%1000-(a % 1000) % 100)/100==a%10)//равно ли количество сотен количеству единиц
            {
                Console.WriteLine("Количество сотен равно количеству единиц.");
            } 
            else 
            {
                Console.WriteLine("Количество сотен не равно количеству единиц.");
            }
        }
    }
}
