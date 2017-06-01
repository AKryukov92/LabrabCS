using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int i = 30;
            while (i <= 40)
            {
                if (i == x)
                {
                    Console.WriteLine(i + "+");
                } else {
                    Console.WriteLine(i + "-");
                }
                i = i + 1;
            }
        }
    }
}
