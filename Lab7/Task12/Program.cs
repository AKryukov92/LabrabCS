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
            if (!t.Contains(","))
            {
                Console.WriteLine("1");
            }
            else
            {
                int index = t.IndexOf(",");
                int index1 = t.LastIndexOf(",");
                int p;//позиция символа после запятой
                int count = 2;
                while (index < index1)
                {
                    p = index + 1;
                    index = t.IndexOf(",", p);
                    count++;
                }
                Console.WriteLine(count);
            }



        }
    }
}
