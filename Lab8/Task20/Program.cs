using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] sarr = t.Split(' ');
            int L = sarr.Length;
            string M = "";
            string[] arr = new string[L];
            if (P < 0 || Q<0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            if (P>=L || Q>=L)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            while (P <= Q)
            {
                arr[P] = sarr[P];
                M = arr.Min();
                P++;
            }
            Console.WriteLine(M);
        }
    }
}
