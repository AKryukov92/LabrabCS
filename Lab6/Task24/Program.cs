using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            int sum = 0;
            while (i <= 1000) {
                if (i % 13 == 0)
                {
                    sum = sum + 1;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
