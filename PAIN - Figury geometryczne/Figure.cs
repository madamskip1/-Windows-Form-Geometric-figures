using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    abstract class Figure
    {
        protected string _color;
        protected Point _coords;
        protected int _area;
        protected string _label;

        public abstract string ShapeName();

        public string Color
        {
            get;
            set;
        }

        public Point Coords
        {
            get;
            set;
        }

        public int Area
        {
            get;
            set;
        }

        public string Label
        {
            get;
            set;
        }
    }
}
