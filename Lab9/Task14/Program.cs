using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(filename);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            Console.WriteLine("Введите букву: ");
            string A = Console.ReadLine();
            int i;
            int j = 0;
            int v = 0;
            string fragment = "";
            string t="";
            string t1 = "";
            int index1=0;
            int index2=0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                t = t + line;
            }
            index1 = t.IndexOf("\"");
            index2 = t.IndexOf("\"", index1 + 1);
            do
            {
                //if (t.Substring(index2 + 1, 1) != "," || t.Substring(index2 + 1, 1) != "")
                //{
                //    Console.WriteLine("Фрагменты должны разделяться запятыми");
                //    return;
                //}
                if (index1 == t.LastIndexOf("\""))
                {
                    Console.WriteLine("Фрагмент должен быть обрамлен кавычками");
                    return;
                }
                fragment = t.Substring(index1+1, index2 - index1-1);
                i = 0;
                v = 0;
                while (i < fragment.Length)
                {
                    t1 = fragment.Substring(i, 1);
                    if (t1.Contains(A))
                    {
                        v++;
                    }
                    i++;
                }
                index1 = t.IndexOf("\"", index2 + 1);
                index2 = t.IndexOf("\"", index1 + 1);
                Console.Write(v + " ");
                if (index1 < 0 || index2 < 0)
                {
                    return;
                }
                j++;
            }
            while (j < t.Length);
            reader.Close();
            //indexOf("\"", index2+1)
            //string[] sarr = t.Split(',');
            //i = 0;
            //while (i < sarr.Length)
            //{
            //    v = 0;
            //    j = 0;
            //    fragment = sarr[i];
            //    while (j < fragment.Length)
            //    {
            //        t1 = fragment.Substring(j, 1);
            //        if (t1.Contains(A))
            //        {
            //            v++;
            //        }
            //        j++;
            //    }
            //    Console.Write(v + " ");
            //    i++;
            //}
            //reader.Close();
        }
    }
}
