using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task7186
{
    public class Comparator7186 : Comparer<int>
    {
        public int z;
        public Comparator7186 (int z)
        {
            this.z = z;
        }
        public override int Compare(int x, int y)
        {
            if (Math.Abs(x - z) == Math.Abs(y - z))
            {
                return 0;
            }
            if (Math.Abs(x - z) < Math.Abs(y - z))
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
