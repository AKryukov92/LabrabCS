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
        public static string checkup(string input)
        {
             string filename = "test" + input + ".csv";
             if (!File.Exists(filename))
             {
                 Exception error=new Exception("Файл не существует");
                 throw error;
             }
             StreamReader reader = new StreamReader(filename);
             if (reader.EndOfStream)
             {
                 return "Файл пуст";
             }
             return filename;
        }
    }
}
            
        
  