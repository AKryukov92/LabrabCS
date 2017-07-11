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
    } 
}
