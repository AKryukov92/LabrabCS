using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int sum = x;
            int count = 1;
            while (sum<=1000)
            {
                x = int.Parse(Console.ReadLine());
                sum = sum + x;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
