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
        public static string task7937(int in7937w, int in7937h, int in7937c, int in7937d)
        {
            if (in7937w <= 0)
            {
                Exception error = new Exception("Значение W должно быть положительным");
                throw error;
            }
            if (in7937h <= 0)
            {
                Exception error = new Exception("Значение H должно быть положительным");
                throw error;
            }
            if (in7937c <= 0)
            {
                Exception error = new Exception("Значение C должно быть положительным");
                throw error;
            }
            if (in7937d <= 0)
            {
                Exception error = new Exception("Значение D должно быть положительным");
                throw error;
            }
            if (in7937c <= in7937d)
            {
                Exception error = new Exception("Значение C должно быть больше D");
                throw error;
            }
            double S1 = (in7937h / in7937c) * (in7937w / in7937d);//Сколько прямоугольников поместится, если разместить стороной C вдоль стороны H
            double S2 = (in7937w / in7937c) * (in7937h / in7937d);//Сколько прямоугольников поместится, если разместить стороной C вдоль стороны W
            if (S1 > S2)
            {
                return String.Format("{0} при С вдоль Н", S1);
            }
            else
            {
                return String.Format("{0} при С вдоль W", S2);
            }
        }
        public static bool task4257(double in4257l, double in4257p)
        {
            if (in4257l < 0)
            {
                Exception error = new Exception("Значение L должно быть неотрицательным");
                throw error;
            }
            if (in4257p < 0)
            {
                Exception error = new Exception("Значение P должно быть неотрицательным");
                throw error;
            }
            if (in4257l * 1000 < in4257p * 0.305)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string task2291(double in2291v1, double in2291v2)
        {
            if (in2291v1 < 0)
            {
                Exception error = new Exception("Значение V1 должно быть неотрицательным");
                throw error;
            }
            if (in2291v2 < 0)
            {
                Exception error = new Exception("Значение V2 должно быть неотрицательным");
                throw error;
            }
            if (in2291v1 * 1000 / 3600 > in2291v2)
            {
                return String.Format("{0} (км/ч) меньше {1} (м/с)", in2291v2, in2291v1);
            }
            else
            {
                return String.Format("{0} (км/ч) меньше {1} (м/с)", in2291v1, in2291v2);
            }
        }
        public static string task1763(int in1763r, int in1763a)
        {
            if (in1763a <= 0)
            {
                Exception error = new Exception("Сторона квадрата должна быть положительна");
                throw error;
            }
            if (in1763r <= 0)
            {
                Exception error = new Exception("Радиус должен быть положительным");
                throw error;
            }
            if (in1763a * in1763a > Math.PI * in1763r * in1763r)
            {
                return String.Format("Площадь квадрата {0:F4} больше площади круга {1:F4}", in1763a * in1763a, Math.PI * in1763r * in1763r);
            }
            else
            {
                return String.Format("Площадь круга {0:F4} больше площади квадрата {1:F4}", Math.PI * in1763r * in1763r, in1763a * in1763a);
            }
        }
        public static bool task1945(int in1945sc, int in1945ss)
        {
            double d = 2 * Math.Sqrt(in1945sc / Math.PI);// диаметр круга
            double a = Math.Sqrt(in1945ss);// сторона квадрата
            if (in1945sc <= 0)
            {
                Exception error = new Exception("Площадь круга должна быть положительной");
                throw error;
            }
            if (in1945ss <= 0)
            {
                Exception error = new Exception("Площадь квадрата должна быть положительной");
                throw error;
            }
            if (d <= a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool task6291(int in6291a, int in6291b, int in6291c)
        {
            if (in6291a <= 0)
            {
                Exception error = new Exception("Значение A должно быть неотрицательным");
                throw error;
            }
            if (in6291b <= 0)
            {
                Exception error = new Exception("Значение B должно быть неотрицательным");
                throw error;
            }
            if (in6291c <= 0)
            {
                Exception error = new Exception("Значение C должно быть неотрицательным");
                throw error;
            }
            if (in6291a == in6291b || in6291b == in6291c || in6291a == in6291c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool task3883(int in3883)
        {
            if (in3883 < 1000 || in3883 > 9999)
            {
                Exception error=new Exception("Значение A должно быть в интервале [1000, 9999]");
                throw error;
            }
            if ((in3883 % 1000 - (in3883 % 1000) % 100) / 100 == in3883 % 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string task4527(int in4527)
        {
            int b = in4527 % 10;
            if (in4527 > 100 || in4527 < -10)
            {
                Exception error = new Exception("Значение A должно быть в интервале [-10, 100]");
                throw error;
            }
            if (in4527 == 40)
            {
                return String.Format("{0}'ой", in4527);
            }
            if (b == 1 || b == 4 || b == 5 || b == 9 || b == 0)
            {
                return String.Format("{0}'ый", in4527);
            }
            if (b == 2 || b == 6 || b == 7 || b == 8)
            {
                return String.Format("{0}'ой", in4527);
            }
            if (b == 3)
            {
                return String.Format("{0}'ий", in4527);
            }
            return "";
        }
        public static bool task6556(int in6556a, int in6556b, int in6556c, int in6556d)
        {
            if (in6556a <= 0)
            {
                Exception error=new Exception("Значение A должно быть неотрицательным");
                throw error;
            }
            if (in6556b <= 0)
            {
                Exception error = new Exception("Значение B должно быть неотрицательным");
                throw error;
            }
            if (in6556c <= 0)
            {
                Exception error = new Exception("Значение C должно быть неотрицательным");
                throw error;
            }
            if (in6556d <= 0)
            {
                Exception error = new Exception("Значение D должно быть неотрицательным");
                throw error;
            }
            if (in6556a <= in6556c && in6556b <= in6556d)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool task2153(int in2153t)
        {
            if (in2153t <= 0 || in2153t > 60)
            {
                Exception error=new Exception ("Значение T должно быть в интервале [0, 59]");
                throw error;
            }
            if (in2153t % 5 == 0 || in2153t % 5 == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

