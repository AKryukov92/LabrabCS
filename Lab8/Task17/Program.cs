using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            int i = 0; 
            int j = 0;
            int count = 0;
            while (i < l)
            {
                j = 0;
                while (j < l)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        count = count + 1;
                    }
                    j++;
                }
                i++;
            }
            if (count > 0)
            {
                Console.WriteLine("Повторения есть");
            }
            else
            {
                Console.WriteLine("Повторений нет");
            }
  

        }
    }
}
