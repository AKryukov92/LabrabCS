using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            double a, R;
            a = double.Parse(t1);
            if (a < 1)
            {
                Console.WriteLine("Значение X должно быть не меньше 1");
                return;
            }
            R = (Math.Sqrt(a+1)+ Math.Sqrt(a-1))/(2*Math.Sqrt(a));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
