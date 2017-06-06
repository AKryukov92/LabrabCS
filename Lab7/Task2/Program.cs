using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "abcdefwxyz";
            string t1 = Console.ReadLine();
            int index = t.IndexOf(t1);//позиция символа в строке
            if (index==-1)
            { 
                Console.WriteLine("Значение отсутствует в строке");
                return;
            }
            int l = t.Length;//длина строки
            int m = l - index-1;//сколько символов после введенного символа
            Console.WriteLine(m);
        }
    }
}
