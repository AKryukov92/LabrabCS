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
            string t1 = Console.ReadLine();
            string t2 = Console.ReadLine();
            string[] top = t1.Split(' ');
            string[] left = t2.Split(' ');
            int l1 = top.Length;
            int l2 = left.Length;
            int i = 0;
            int j = 0;
            if (t1 == "")
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            if (t2 == "")
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            Console.Write(" ");
            while (i < l1)
            {
                Console.Write(" " + top[i]);
                i++;
            }
            Console.WriteLine();
            while (j < l2)
            {
                Console.Write(left[j]);
                i=0;
                while (i<l1) 
                {
                    if (top[i] == left[j])
                    {
                        Console.Write(" +");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    i++;
                }
                Console.Write("|");
                j++;
                Console.WriteLine();
            }
            j = 0;
            Console.Write(" ");
            while (j<l1) {
                Console.Write("--");
                j++;
            }
        }
    }
}
