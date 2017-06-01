using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            double n = double.Parse(t1);
            int i=1;
            double j=n;
            double sum=1;
            if (n <=0) {
                Console.WriteLine("Значение N должно быть положительным");
                return;
            }
            while(i<j && n>0) {
                sum = sum + 1 / n;
                n=n-1;
                i=i+1;
            }
            Console.WriteLine("{0:F4}", sum);
        }
    }
}
