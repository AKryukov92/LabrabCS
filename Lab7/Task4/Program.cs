using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "abcdacadbacdaabaadc";
            string t1 = Console.ReadLine();
            if (t1.Length !=2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;
            }
            int index1 = t.IndexOf(t1);//позиция символа в строке
            if (index1 != -1)
            {
                Console.WriteLine(index1);
            }
            int i = index1 + 1;
            int index2 = t.IndexOf(t1, i);//позиция символа в строке после символа в позиции i
            if (index2 != -1)
            {
                Console.WriteLine(index2);
            }
        }
    }
}
