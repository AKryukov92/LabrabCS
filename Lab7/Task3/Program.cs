using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
            if (indexCA == -1)
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            if (indexCB == -1)
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            int r = indexCA - indexCB;
            if (r < 0)
            {
                r = -1 * (r + 1);
                Console.WriteLine(r);
            } else {
                r = r - 1;
                Console.WriteLine(r);
            }
        }
    }
}
