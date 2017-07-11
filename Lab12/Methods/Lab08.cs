using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab08
    {
        public static double task3946(string in3946)
        {
            double c;
            double sum=0;
            double SA;//среднее арифметическое
            int i=0;
            string[] sarr = new string[in3946.Length];
            sarr = in3946.Split(' ');
            if (in3946 == "")
            {
                return 0;
            }
            while (i < sarr.Length)
            {
                c = double.Parse(sarr[i]);
                sum = sum + c;
                i++;
            }
            SA = sum / in3946.Length;
            return SA;
        }
        public static int task7035(string in7035)
        {
            int i = 0;
            string[] sarr = new string[in7035.Length];
            sarr = in7035.Split(' ');
            int[] arr = new int[sarr.Length];
            while (i < sarr.Length)
            {
                arr[i] = int.Parse(sarr[i]);
                i++;
            }
            i = 0;
            int C = arr[0];
            while (i < sarr.Length)
            {
                if (arr[i] < C)
                {
                    C = arr[i];
                }
                i++;
            }
            return C;
        }
        public static int task4283(int in4283k, string in4283s)
        {
            string[] sarr = new string[in4283s.Length];
            sarr = in4283s.Split(' ');
            int i = 0;
            int count = 0;
            int[] arr = new int[sarr.Length];
            while (i < sarr.Length)
            {
                arr[i] = int.Parse(sarr[i]);
                i++;
            }
            i = 0;
            while (i < sarr.Length)//сколько раз число встречается в массиве
            {
                if (arr[i] == in4283k)
                {
                    count = count + 1;
                }
                i++;
            }
            return count;
        }
        public static int task9182(string in9182)
        {
            string[] sarr = new string[in9182.Length];
            sarr = in9182.Split(' ');
            int L = sarr.Length;
            int[] arr = new int[sarr.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (k < L)
            {
                arr[k] = int.Parse(sarr[k]);//преобразование строкового массива в числовой
                k++;
            }
            i = 0;
            j = 0;
            int q = 0;//Количество повторений
            while (j < L)
            {
                i = j + 1;
                while (i < L)
                {
                    if (arr[j] == arr[i] && i != j)
                    {
                        q = q + 1;
                        break;
                    }
                    i++;
                }
                j++;
            }
            return (L - q);
        }
        public static bool task4515(string in4515)
        {
            string[] arr = new string[in4515.Length];
            arr = in4515.Split(' ');
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
                return true;
            }
            else
            {
                return false;
            }
        }
        public static StringBuilder task5694(StringBuilder sb5694, string in5694)
        {
            string[] sarr;
            string raw = "a b c d e f g h";
            sarr = raw.Split(' ');
            int i = 0;
            while (i < sarr.Length)
            {
                if (sarr[i] == in5694)
                {
                    sb5694.Append(sarr[i] + "+" + "\n");
                }
                else
                {
                    sb5694.Append(sarr[i]+ "\n");
                }
                i++;
            }
            return sb5694;
        }
        public static StringBuilder task6806(StringBuilder sb6806, int in6806)
        {
            int[] arr = new int[] { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 };
            int i = 0;
            int l = arr.Length;
            while (i < l)
            {
                if (arr[i] == in6806)
                {
                    sb6806.Append(arr[i] + "+" + "\n");
                }
                else
                {
                    sb6806.Append(arr[i] + "\n");
                }
                i++;
            }
            return sb6806;
        }
    }
}
