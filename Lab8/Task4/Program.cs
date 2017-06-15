using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] arr;
            arr=t.Split(' ');
            double c;
            double sum=0;
            double SA;//среднее арифметическое
            double l=arr.Length;
            int i=0;
            if (t=="")
            {
                Console.WriteLine("0");
                return;
            }
            while (i < l)
            {
                c = double.Parse(arr[i]);
                sum = sum + c;
                i++;
            }
            SA = sum / l;
            Console.WriteLine(SA);
        }
    }
}
