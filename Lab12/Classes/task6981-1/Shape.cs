using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6981_1
{
    public abstract class Shape
    {
        public abstract void shiftX(int dx);
        public abstract void shiftY(int dy);
        public abstract void stretchX(int dw);
        public abstract void stretchY(int dh);
    }
}
