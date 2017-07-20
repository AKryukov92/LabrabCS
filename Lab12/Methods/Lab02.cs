using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab02
    {
        public static double task4411(double a)
        {
            return a + 7;
        }
        public static double task8428(double a)
        {
            return a * Math.PI / 180;
        }
        public static double task1262(double a)
        {
            return 5 * Math.Cos(a * Math.PI / 180);
        }
        public static double task2790(double a)
        {
            return Math.Sqrt(1 - Math.Sin(a * Math.PI / 180) * Math.Sin(a * Math.PI / 180));
        }
        public static double task9164(double a, double b)
        {
            return Math.Sin(a * Math.PI / 180) * Math.Cos(b * Math.PI / 180) + Math.Cos(a * Math.PI / 180) * Math.Sin(b * Math.PI / 180);
        }
        public static double task5789(double xa, double ya, double xb, double yb)
        {
            return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
        }

        public static double task9020(double a)
        {
            double b;
            if (61 - a < 0)
            {
                //Создание экземпляра исключения
                Exception error = new Exception("Подкоренное выражение должно быть неотрицательным");
                //выбрасывание исключения
                throw error;
            }
            b = 3 * Math.Sqrt(61 - a);
            return b;
        }
        public static double task7237(double a)
        {
            double b;
            if (a < -273.15)
            {
                Exception error = new Exception("Значение T должно быть выше абсолютного нуля");
                throw error;
            }
            b = 1.8 * a + 32;
            return b;
        }
        public static double task3943(double x, double y)
        {
            double c;
            if (y < 0)
            {
                Exception error = new Exception("Значение y должно быть неотрицательным");
                throw error;
            }
            if (x + Math.Sqrt(y) < 0)
            {
                Exception error = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw error;
            }
            c = -5 * Math.Sqrt(x + Math.Sqrt(y));
            return c;
        }
        public static double task8873(double R1, double R2)
        {
            double R;
            if (R1 == 0)
            {
                Exception error = new Exception("Значение R1 должно быть не равно нулю");
                throw error;
            }
            if (R2 == 0)
            {
                Exception error = new Exception("Значение R2 должно быть не равно нулю");
                throw error;
            }
            R = 1 / R1 + 1 / R2;
            return R;
        }
        public static double task2624(double a, double b, double c, double x)
        {
            double R;
            if (a * x * x + b * x + c < 0)
            {
                Exception error = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw error;
            }
            if (Math.Sqrt(a * x * x + b * x + c) == 0)
            {
                Exception error = new Exception("Знаменатель не может быть равен нулю");
                throw error;
            }
            R = 1 / Math.Sqrt(a * x * x + b * x + c);
            return R;
        }
        public static double task5871(double x)
        {
            double R;
            if (x+5 < 0)
            {
                Exception error = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw error;
            }
            if (x - 5 < 0)
            {
                Exception error = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw error;
            }
            if (x==0)
            {
                Exception error = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw error;
            }
            R = (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));
            return R;
        }
        public static double task3591(double h)
        {
            double S;
            double r = 6350;
            if (h < 0)
            {
                Exception error = new Exception("Высота над уровнем Земли должна быть неотрицательна");
                throw error;
            }
            S = Math.Sqrt((r + h) * (r + h) - r * r);
            return S;
        }
        public static int task9298(int a)
        {
            int c;
            if (a <= 0)
            {
                Exception error = new Exception("Значение A должно быть положительным");
                throw error;
            }
            c = 6 * a * a;
            return c;
        }
        public static int task3354(int a)
        {
            int c;
            if (a <= 0)
            {
                Exception error = new Exception("Значение A должно быть положительным");
                throw error;
            }
            c = a * a * a;
            return c;
        }
        public static double task5201(double r)
        {
            double c;
            if (r <= 0)
            {
                Exception error = new Exception("Значение R должно быть положительным");
                throw error;
            }
            c = 2 * Math.PI * r;
            return c;
        }
        public static double task2981(double r)
        {
            double v;
            if (r <= 0)
            {
                Exception error = new Exception("Значение r должно быть положительным");
                throw error;
            }
            v = 4 * Math.PI * r * r * r / 3;
            return v;
        }
        public static double task4312(double a, double h)
        {
            double s;
            if (a <= 0)
            {
                Exception error = new Exception("Значение а должно быть положительным");
                throw error;
            }
            if (h <= 0)
            {
                Exception error = new Exception("Значение h должно быть положительным");
                throw error;
            }
            s = a * h / 2;
            return s;
        }
        public static double task8833(double x)
        {
            double r;
            if (x < 0)
            {
                Exception error = new Exception("Значение x должно быть неотрицательным");
                throw error;
            }
            r = Math.Sqrt(x);
            return r;
        }
        public static double task1934(double a, double b)
        {
            double c;
            if (b > 0)
            {
                Exception error = new Exception("Значение b должно быть неположительным");
                throw error;
            }
            c = a * Math.Sqrt(-7 * b);
            return c;
        }
        public static double task7619(double V1, double V2, double S)
        {
            double T;
            if (V1 < 0)
            {
                Exception error = new Exception("Значение V1 должно быть неотрицательным");
                throw error;
            }
            if (V2 < 0)
            {
                Exception error = new Exception("Значение V2 должно быть неотрицательным");
                throw error;
            }
            T = S / (V1 + V2);
            return T;
        }
        public static double task9130(double m1, double m2, double r)
        {
            double C;
            double g=9.8067;
            if (r == 0)
            {
                Exception error = new Exception("Значение r должно быть не равно нулю");
                throw error;
            }
            C = g * m1 * m2 / (r * r);
            return C;
        }
        public static double task2461(double a, double b, double c, double d)
        {
            double R;
            if (a == 0)
            {
                Exception error = new Exception("Значение a должно быть не равно нулю");
                throw error;
            }
            if (d == 0)
            {
                Exception error = new Exception("Значение d должно быть не равно нулю");
                throw error;
            }
            R = (a * d + b * c) / (a * d);
            return R;
        }
        public static double task7799(int in7799mass, int in7799a)
        {
            double b;
            if (in7799mass<=0)
            {
                Exception error = new Exception("Масса должна быть положительной");
                throw error;
            }
            b = in7799a * Math.PI / 180;//Угол в радианах
            double g = 9.8067;
            double R;
            R = in7799mass * g * Math.Cos(b);
            return R;
        }
    }
}
