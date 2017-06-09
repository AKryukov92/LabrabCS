using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            if (!t.Contains("\""))
            {
                Console.WriteLine(t);
                return;
            }
            if (t.Contains("\""))
            {
                int index1=-1; 
                int index2 = t.LastIndexOf("\"");
                int indexP=0;
                int p=0;//позиция символа после запятой
                int count = 0;
                do {
                    indexP=index1;
                    index1 = t.IndexOf("\"", p);
                    p = index1 + 1;
                    count++;
                    if (count % 2 == 0)
                    {
                        Console.Write(t.Substring(indexP+1, index1-indexP-1) + "]");
                    }
                    else
                    {
                        Console.Write(t.Substring(indexP+1, index1-indexP-1) + "[");
                    }
                }
                while (index1 < index2);
                }
            }
        }
    }

