using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int A = int.Parse(t);
            int sum=0;
            if (A>500 || A<-100)
            {
                Console.WriteLine("Значение А должно быть диапазоне от -100 до 500");
            }
            while (A <= 500)
            {
                sum = sum + A;
                A = A + 1;
            }
            Console.WriteLine(sum);
        }
    }
}
