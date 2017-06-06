using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "abcdefwxyz";
            string CA = Console.ReadLine();
            string CB = Console.ReadLine();
            int indexCA = t.IndexOf(CA);
            int indexCB = t.IndexOf(CB);
            int l = t.Length;
            int m;//длина второй части
            int n;//длина третьей части
            if (!t.Contains(CA))
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            if (!t.Contains(CB))
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            if (indexCA < indexCB)
            {
                m = indexCB - indexCA;
                n = l - indexCB;
                Console.WriteLine("Часть 1: " + t.Substring(0, indexCA));
                Console.WriteLine("Часть 2: " + t.Substring(indexCA, m));
                Console.WriteLine("Часть 3: " + t.Substring(indexCB, n));
            }
            else
            {
                m = indexCA - indexCB;
                n = l - indexCA;
                Console.WriteLine("Часть 1: " + t.Substring(0, indexCB));
                Console.WriteLine("Часть 2: " + t.Substring(indexCB, m));
                Console.WriteLine("Часть 3: " + t.Substring(indexCA, n));
            }

        }
    }
}
