using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int l = t.Length;
            string t1 = t.Substring(0,1);
            string t2 = t.Substring(l-1, 1);
            if (t1.Contains("\"") && t2.Contains("\""))
            {
                string t3 = t.Remove(0, 1);//удаляем первые кавычки 
                int l1 = t3.Length;
                int p1 = l1 - 1;//индекс последнего символа
                string t4 = t3.Remove(p1, 1);//удаляем последние кавычки
                string t5 = t4.Trim();//удаляем пробелы
                Console.WriteLine(t5);
            }
            else
            {
                Console.WriteLine("Строка должна начинаться и заканчиваться кавычкой");
            }
            }
        }
    }

