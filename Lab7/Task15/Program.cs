using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int i = 0;
            int j = 1;
            int l = t.Length;
            int v = 0;
            string t1; 
            while (i<l)
            {
                t1= t.Substring(i,j);
                if (t1.Contains("{"))
                {
                    v = v + 1;
                    Console.Write(v);
                }
                else
                {
                    v = v - 1;
                    Console.Write(v);
                }
                i++;
            }
            if (v >= 1)
            {
                Console.WriteLine("Неожиданный конец строки");
            }
            if (v < 0)
            {
                Console.WriteLine("Неожиданная закрывающаяся скобка");
            }
        }
    }
}
