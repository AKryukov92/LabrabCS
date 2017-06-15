using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            string t2 = Console.ReadLine();
            string[] top = t1.Split(' ');
            string[] left = t2.Split(' ');
            int l1 = top.Length;
            int l2 = left.Length;
            int i=0;
            int j=0;
            int count = 0;
            if (t1 == "" )
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            if (t2 == "")
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            while (i < l1)
            {
                while (j < l2)
                {
                    if (top[i]==left[j])
                    {
                        count = count + 1;
                    }
                    j++;
                }
                j = 0;
                i++;
            }
            Console.WriteLine("Повторений: {0}", count);
        }
    }
}
