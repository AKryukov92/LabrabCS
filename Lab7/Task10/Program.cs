using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "abcdacadbacdaabaadc";
            string t1 = Console.ReadLine();
            int l = t1.Length;
            string t2 = " ";
            if (l != 2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
            }
            else
            {
                Console.WriteLine(t.Replace(t1, t2));
            }
        }
    }
}
