using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PAIN___Figury_geometryczne
{
    class Square : Figure
    {

        public Square() : base()
        {
            Shape = Shapes.SQUARE;
        }

        public override string ShapeName()
        {
            return "Square";
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(Color), 5);
            Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml(Color));

            Rectangle rec = new Rectangle(20, 20, 100, 100);
            graphics.FillRectangle(brush, rec);
            graphics.Dispose();
        }
    }
}
