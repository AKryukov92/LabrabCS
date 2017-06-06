using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        { 
            string t="abcdefwxyz";
            string t1 = Console.ReadLine();
            if (t.Contains(t1)==true)
            {
                Console.WriteLine("Содержится");
            }
            else
            {
                Console.WriteLine("Не содержится");
            }
        }
    }
}
