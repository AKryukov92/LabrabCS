using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab13
    {
        public static string checkup1(string filename)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string filename = "test" + input + ".csv";
                    if (!File.Exists(filename))
                        {
                            Console.WriteLine ("Файл не существует");
                        }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
            
        
  