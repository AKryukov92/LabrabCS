using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            string K = Console.ReadLine();//вводим число
            string T = Console.ReadLine();//вводим массив
            string[] sarr = T.Split();
            int L = sarr.Length;
            int i = 0;
            int count = 0;
            while (i < L)//сколько раз число встречается в массиве
            {
                if (sarr[i] == K)
                {
                    count = count + 1;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}
