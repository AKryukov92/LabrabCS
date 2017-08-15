using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7738
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
            IList<String> list = new List<string>();
            ISet<String> setString = new HashSet<string>();
            ISet<int> setCount = new HashSet<int>();
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                list.Add(line);
                setString.Add(line);
            }
            reader.Close();
            int i = 0;
            int j = 0;
            int count = 0;
            int[] arr=new int[setString.Count];
            while (j < list.Count)
            {
                i = 0;
                count = 0;
                while (i < list.Count)
                {
                    if (list[j] == list[i])
                    {
                        count++;
                    }
                    i++;
                }
                if (j < arr.Length)
                {
                    arr[j] = count;
                }
                j++;
            }
            Console.WriteLine(String.Join("\n", setString) + String.Join("\n", setCount));
        }
    }
}
