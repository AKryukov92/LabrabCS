using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task6876
{
    public abstract class Shape
    {
        public abstract double area();
        public static string GetHeader()
        {
            return "<svg width=\"150\" height=\"150\">";
        }
        public static string GetFooter()
        {
            return "<\\svg>";
        }
    }
}
