using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task3956
{
    public abstract class Shape
    {
        public abstract Point getCenter();
        public abstract void slide(int dx, int dy);
        public abstract double area();
    }
}
