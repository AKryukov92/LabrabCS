using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            int r;//количество выводимых символов
            int m;//индекс первого символа в выводимой строке
            if (t.Contains(CA) == false)
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            if (t.Contains(CB) == false)
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            if (indexCA < indexCB)
            {
                r = indexCB - indexCA - 1;
                m = indexCA + 1;
                Console.WriteLine(t.Substring(m, r));
            }
            else
            {
                r = indexCA - indexCB - 1;
                m = indexCB + 1;
                Console.WriteLine(t.Substring(m, r));
            }
        }
    }
}
