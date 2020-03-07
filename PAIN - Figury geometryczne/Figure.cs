using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public abstract class Figure
    {
        public Figure()
        {
        }
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


        public static bool ValidateArea(string area)
        {
            int result;
            int.TryParse(area, out result);

            if (result > 0)
                return true;

            return false;
        }

        public static bool ValidateCoord(string coord)
        {
            try
            { int.Parse(coord); }
            catch
            { return false; }

            return true;
        }

        public static bool ValidateColor(string color)
        {
            Regex regex = new Regex("^#(?:[0-9a-fA-F]{6})$");
            return regex.Match(color).Success;
        }

        public static bool ValidateLabel(string label)
        {
            return !String.IsNullOrEmpty(label);
        }
    }
}
