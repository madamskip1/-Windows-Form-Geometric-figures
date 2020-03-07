using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PAIN___Figury_geometryczne
{
    class Triangle : Figure
    {

        public Triangle() : base()
        {
            Shape = Shapes.TRIANGLE;
        }

        public override string ShapeName()
        {
            return "Triangle";
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(Color), 5);
            Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml(Color));

            System.Drawing.Point point1 = new System.Drawing.Point(20, 107);
            System.Drawing.Point point2 = new System.Drawing.Point(107, 107);
            System.Drawing.Point point3 = new System.Drawing.Point(63, 20);

            System.Drawing.Point[] curvePoints = { point1, point2, point3 };
            graphics.FillPolygon(brush, curvePoints);
            graphics.Dispose();
        }
    }
}
