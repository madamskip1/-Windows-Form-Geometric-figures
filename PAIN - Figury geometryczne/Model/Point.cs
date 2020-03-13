using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public class Point
    {

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
