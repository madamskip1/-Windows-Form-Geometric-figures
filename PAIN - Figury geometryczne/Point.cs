using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point()
        {
            this._x = 0;
            this._y = 0;
        }

        public Point(int _x, int _y)
        {
            this._x = _x;
            this._y = _y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }
    }
}
