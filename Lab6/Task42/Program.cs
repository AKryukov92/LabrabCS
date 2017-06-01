using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            int sum = 0;
            while (x != 0)
            {
                sum = sum + x;
                x = int.Parse(Console.ReadLine());  
            }
            Console.WriteLine(sum);
        }
    }
}
