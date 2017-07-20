using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab07
    {
        public static string task4265(string t)
        {
            string t1 = t.Substring(0, 1);
            if (t1 == "s")
            {
                return t.ToLower();
            }
            if (t1 == "U")
            {
                return t.ToUpper();
            }
            else
            {
                return t;
            }
        }
        public static bool task7491(string in7491)
        {
            string t = "abcdefwxyz";
            if (t.Contains(in7491))
            {
                 return true;
            }
            else
            {
                 return false;
            }
        }
        public static int task9631(string in9631)
        {
            string t = "abcdefwxyz";
            int index = t.IndexOf(in9631);//позиция символа в строке
            if (index == -1)
            {
                Exception error=new Exception("Значение S отсутствует в строке");
                throw error;
            }
            int l = t.Length;//длина строки
            int m = l - index - 1;//сколько символов после введенного символа
            return m;
        }
        public static int task9812(string in9812a, string in9812b)
        {
            string t = "abcdefwxyz";
            int indexCA = t.IndexOf(in9812a);
            int indexCB = t.IndexOf(in9812b);
            if (indexCA == -1)
            {
                Exception error = new Exception("Значение A отсутствует в строке");
                throw error;
            }
            if (indexCB == -1)
            {
                Exception error = new Exception("Значение B отсутствует в строке");
                throw error;
            }
            int r = indexCA - indexCB;
            if (r < 0)
            {
                r = -1 * (r + 1);
                return r;
            }
            else
            {
                r = r - 1;
                return r;
            }
        }   
        public static string task5728(string in5728a, string in5728b)
        {
            string t = "abcdefwxyz";
            string z;
            int indexCA = t.IndexOf(in5728a);
            int indexCB = t.IndexOf(in5728b);
            int r;//количество выводимых символов
            int m;//индекс первого символа в выводимой строке
            if (t.Contains(in5728a) == false)
            {
                Exception error=new Exception("Значение A отсутствует в строке");
                throw error;
            }
            if (t.Contains(in5728b) == false)
            {
                Exception error = new Exception("Значение B отсутствует в строке");
                throw error;
            }
            if (indexCA < indexCB)
            {
                r = indexCB - indexCA - 1;
                m = indexCA + 1;
                z=t.Substring(m, r);
                return z;
            }
            else
            {
                r = indexCA - indexCB - 1;
                m = indexCB + 1;
                z=t.Substring(m, r);
                return z;
            }
        }
        public static string task5923(int in5923a, int in5923b)
        {
            string t = "abcdefwxyz";
            string x;
            int l = t.Length;
            if (in5923a >= l || in5923a<0)
            {
                return String.Format("Значение A должно быть в интервале [0, {0})", l);
            }
            if (in5923b < 0)
            {
                return String.Format("Значение B должно быть неотрицательно");
            }
            if (in5923a + in5923b >= l)
            {
                Exception error = new Exception("Сумма значений A и B должна быть меньше длины строки");
                throw error;
            }
            x = t.Remove(in5923a, in5923b);
            return x;
        }
        public static string task9116(string in9116)
        {
            int l = in9116.Length;
            string t1 = in9116.Substring(0, 1);
            string t2 = in9116.Substring(l - 1, 1);
            if (t1.Contains("\"") && t2.Contains("\""))
            {
                string t3 = in9116.Remove(0, 1);
                int l1 = t3.Length;
                int p1 = l1 - 1;
                string t4 = t3.Remove(p1, 1);
                string t5 = t4.Trim();
                return t5;
            }
            else
            {
                Exception error = new Exception("Строка должна начинаться и заканчиваться кавычкой");
                throw error;
            }
        }
        public static string task1618(string in1618)
        {
            int i = 0;
            int v = 0;
            string t1;
            string x;
            StringBuilder sb=new StringBuilder();
            while (i < in1618.Length)
            {
                t1= in1618.Substring(i,1);
                if (t1.Contains("{"))
                {
                    v = v + 1;
                    sb.Append(v);
                }
                else
                {
                    if (v > 0)
                    {
                        v = v - 1;
                        sb.Append(v);
                    }
                    else
                    {
                        v = v - 1;
                    }
                }
                i++;
            }
            x = sb.ToString();
            if (v >= 1)
            {
                Exception error = new Exception(x + "Неожиданный конец строки");
                throw error;
            }
            if (v < 0)
            {
                Exception error = new Exception(x + "Неожиданный символ '}'");
                throw error;
            }
            return x;
        }
        public static string task4845(int in4845a, int in4845b)
        {
            string t = "abcdefwxyz";
            int l = t.Length;
            if (in4845a > l || in4845a < 0)
            {
                return String.Format("Значение A должно быть в интервале [0,{0})", l);
            }
            if (in4845b > l || in4845b < 0)
            {
                return String.Format("Значение B должно быть в интервале [0,{0})", l);
            }
            if (in4845a < in4845b)
            {
                int r = in4845b - in4845a + 1;
                return String.Format(t.Substring(in4845a, r));
            }
            else
            {
                int r = in4845a - in4845b + 1;
                return String.Format(t.Substring(in4845b, r));
            }
        }
        public static string task7222(string in7222)
        {
            StringBuilder sb = new StringBuilder();
            if (in7222.Length != 13)
            {
                Exception error=new Exception("Некорректная длина штрих-кода");
                throw error;
            }
                sb.Append("Код страны: " + in7222.Substring(0, 2)+"\n");
                sb.Append("Код изготовителя: " + in7222.Substring(3, 3)+"\n");
                sb.Append("Код товара: " + in7222.Substring(7, 4)+"\n");
                sb.Append("Контрольное число: " + in7222.Substring(in7222.Length-1, 1));
                return sb.ToString();
        }

        public static string task2166(string in2166)
        {
            string t = "abcdacadbacdaabaadc";
            int l = in2166.Length;
            string t2 = " ";
            if (l != 2)
            {
                Exception error=new Exception("Вводимая строка должна содержать ровно 2 символа");
                throw error;
            }
            else
            {
                return String.Format(t.Replace(in2166, t2));
            }
        }

    }
}

