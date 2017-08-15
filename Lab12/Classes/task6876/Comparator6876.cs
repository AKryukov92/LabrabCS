using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task6876
{
    public class Comparator6876 : Comparer<Shape>
    {
        public override int Compare(Shape s1, Shape s2)
        {
            if (s1.area() > s2.area())
            {
                return -1;
            }
            else 
            {
                return 1;
            }
        }
    }
}
