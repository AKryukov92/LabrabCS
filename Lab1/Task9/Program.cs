using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            msg = Console.ReadLine();
            Console.WriteLine("SELECT first_name, last_name, group \n" +
                "FROM students WHERE student_id =\"{0}\"", msg);
        }
    }
}
