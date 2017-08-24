using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6981_1
{
    public class Circle : Shape
    {
        public string Id;
        public int cx;
        public int cy;
        public int r;
        public Circle(string Id, int cx, int cy, int r)
        {
            this.Id = Id;
            this.cx = cx;
            this.cy = cy;
            this.r = r;
        }
        public override String ToString()
        {
            return String.Format("{{\"cx\":{0}, \"cy\":{1}, \"r\":{2}}}", cx, cy, r);
        }
        public override void shiftX(int dx)
        {
            if (cx + dx < r)
            {
                Exception error = new Exception("Левая точка круга должна иметь неотрицательные координаты");
                throw error;
            }
            cx = cx + dx;
        }
        public override void shiftY(int dy)
        {
            if (cy + dy < r)
            {
                Exception error = new Exception("Верхняя точка круга должна иметь неотрицательные координаты");
                throw error;
            }
            cy = cy + dy;
        }
        public override void stretchX(int dw)
        {
            if (r + dw / 2 < 0)
            {
                Exception error = new Exception("Ширина должна быть положительной");
                throw error;
            }
            cx = cx + dw / 2;
            cy = cy + dw / 2;
            r = r + dw / 2;
        }
        public override void stretchY(int dw)
        {
            if (r + dw / 2 < 0)
            {
                Exception error = new Exception("Высота должна быть положительной");
                throw error;
            }
            cx = cx + dw / 2;
            cy = cy + dw / 2;
            r = r + dw / 2;
        }
    }
}
