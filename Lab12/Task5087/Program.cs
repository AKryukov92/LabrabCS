using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5087
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            string t = Console.ReadLine();
            string[] sarr = t.Split(' ');
            IList<String> list = new List<string>();
            ISet<String> set = new HashSet<String>();
            for (int i = 0; i < sarr.Length; i++)
            {
                list.Add(sarr[i]);
                set.Add(sarr[i]);
            }
            Console.WriteLine("Set: " + String.Join(" ", set));
            Console.WriteLine("List: " + String.Join(" ", list));
        }
    }
}

