using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int i = 2;
            bool isPrime=false;//true или false
            if (y <= 0)
            {
                Console.WriteLine("Значение X должно быть положительным");
                return;
            }
            while (i <= y / 2)
            {
                if (y % i == 0)
                {
                    isPrime=true;
                }
                i++;
            }
            if (isPrime)
            {
                Console.WriteLine("Число не простое");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
        }
    }
}
    

