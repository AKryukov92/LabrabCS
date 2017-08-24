using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task2000
{
    public class Interval
    {
        public int a;
        public int b;
        public int Length
        {
            get
            {
                if (a > b)
                {
                    ArgumentException error = new ArgumentException("Некорректный интервал");
                    throw error;
                }
                return b - a;
            }
        }
        public Interval(int a, int b)
        {
            if (a > b)
            {
                ArgumentException error = new ArgumentException("Некорректный интервал");
                throw error;
            }
            this.a = a;
            this.b = b;
        }
        public int slide(int x)
        {
            a = a + x;
            b = b + x;
            return a;
            return b;
        }
        public int squeeze(int x)
        {
            if (a > b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            if (x >= b - a)
            {
                ArgumentException error = new ArgumentException("Невозможно уменьшить интервал на указанную длину");
                throw error;
            }
            b = b - x;
            return b;
        }
        public int length()
        {
            if (a>b)
            {
                ArgumentException error = new ArgumentException("Некорректный интервал");
                throw error;
            }
            return b - a;
        }
        public String print()
        {
            if (a > b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            return "(" + a + ";" + b + ")";
        }
    }
}
