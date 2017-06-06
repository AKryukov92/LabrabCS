using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "abcdefwxyz";
            int CA = int.Parse(Console.ReadLine());
            int CB = int.Parse(Console.ReadLine());
            int l=t.Length;
            if (CA > l )
            {
                Console.WriteLine("Значение A должно быть в интервале [0,{0}]", l);
                return;
            }
            if (CB > l)
            {
                Console.WriteLine("Значение B должно быть в интервале [0,{0}]", l);
                return;
            }
            if (CA < CB)
            {
                int r = CB - CA + 1;
                Console.WriteLine(t.Substring(CA, r));
            }
            else
            {
                int r = CA - CB + 1;
                Console.WriteLine(t.Substring(CB, r));
            }
        }
    }
}
