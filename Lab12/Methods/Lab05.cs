using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
        public class Lab05
        {
            public static String check()
            {
                if (0 == 3)
                {
                    return "0 == 3";
                }
                else
                {
                    return "0 != 3";
                }
            }
            public static string task5662(double a, double b, double c)
            {
                 //b * b - 4 * a * c;
                if (a == 0)
                {
                   return "Данное уравнение не является квадратным";
                }
                if (b * b - 4 * a * c > 0)
                {
                    return String.Format("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
                }
                if (b * b - 4 * a * c == 0)
                {
                    return String.Format("Уравнение {0}x^2 + {1}x + {2} = 0 имеет один корень", a, b, c);
                }
                if (b * b - 4 * a * c < 0)
                {
                    return String.Format("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);
                }
                return "   ";
            }
            public static double task3770(double x, double y, double z)
            {
                if (x > y && x > z)
                {
                    return x;
                }
                if (y > x && y > z)
                {
                    return y;
                }
                if (z > x && z > y)
                {
                    return z;
                }
                return 0;
            }
            public static long task3669(long A, long B)
            {
                long mult = 1;//произведение
                long C;//разность чисел
                if (A < B)
                {
                    C = B - A + 1;
                    while (C > 0)
                    {
                        mult = mult * A;
                        A = A + 1;
                        C = C - 1;
                    }
                    return mult;
                }
                else
                {
                    C = A - B + 1;
                    while (C > 0)
                    {
                        mult = mult * B;
                        B = B + 1;
                        C = C - 1;
                    }
                    return mult;
                }
                return 0;
            }

            public static bool task4847(int X, int Y, int Z)
            {
                if (X == Y || Y == Z || X == Z)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                //if (a == b)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                //bool r = a == b;
                //return r;
                //return a == b;
            }
            public static bool task4042(double x, double y)
            {
                if (y <= 1.5 && y >= -2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool task6351(double x, double y)
            {
                if (x >= 1 && x <= 2 && y <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool task5382(double x, double y)
            {
                if (x >= 1 && y >= 2 && y <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool task7250(double x, double y)
            {
                if (x >= 2 && y >= 1 || x >= 2 && y <= -1.5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool task9038(double x, double y)
            {
                if (x < 2 && y >= 0.5 && y <= 1.5 || x >= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static StringBuilder task8518(StringBuilder sb, string t)
            {
                if (t == "a")
                {
                    return sb.Append("a+\nb\nc\nd\ne\nf\ng\nh\n");
                }
                if (t == "b")
                {
                    return sb.Append("a\nb+\nc\nd\ne\nf\ng\nh\n");
                }
                if (t == "c")
                {
                    return sb.Append("a\nb\nc+\nd\ne\nf\ng\nh\n");
                }
                if (t == "d")
                {
                    return sb.Append("a\nb\nc\nd+\ne\nf\ng\nh\n");
                }
                if (t == "e")
                {
                    return sb.Append("a\nb\nc\nd\ne+\nf\ng\nh\n");
                }
                if (t == "f")
                {
                    return sb.Append("a\nb\nc\nd\ne\nf+\ng\nh\n");
                }
                if (t == "g")
                {
                    return sb.Append("a\nb\nc\nd\ne\nf\ng+\nh\n");
                }
                if (t == "h")
                {
                    return sb.Append("a\nb\nc\nd\ne\nf\ng\nh+\n");
                }
                return sb.Append("a\nb\nc\nd\ne\nf\ng\nh\n"); 
            }

        }
    }

