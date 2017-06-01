using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int sumleft = 0;
            int sumright = 0;
            while (x<=83 || x>=199)
            {
                if (x <= 83) {
                    sumleft = sumleft + x;
                }
                if (x >= 199)
                {
                    sumright = sumright + x;
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма слева:" + sumleft);
            Console.WriteLine("Сумма справа:" + sumright);
        }
    }
}
