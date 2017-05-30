using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int T = int.Parse(t);
            if (T <= 0 || T > 60)
            {
                Console.WriteLine("Значение T должно быть в интервале [0, 59]");
                return;
            }
            if (T%5==0 || T%5==4)
            {
                Console.WriteLine("Красный");
            }
            else
            {
                Console.WriteLine("Зелёный");
            }
        }
    }
}
