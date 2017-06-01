using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int B = int.Parse(t);
            int sum = 0;
            if (B > 10000 || B < -10)
            {
                Console.WriteLine("Значение b должно быть в интервале [-10,10000]");
                return;
            }
            while (B >= -10)
            {
                sum = sum + B;
                B = B - 1;
            }
            Console.WriteLine(sum);
        }
    }
}
