using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PAIN___Figury_geometryczne
{
    class Circle : Figure
    {

        public Circle() : base()
        {
            Shape = Shapes.CIRCLE;
        }

        public override string ShapeName()
        {
            return "Circle";
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(Color), 5);
            Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml(Color));

            Rectangle rec = new Rectangle(20, 20, 100, 100);
            graphics.FillEllipse(brush, rec);
            graphics.Dispose();
        }
    }
}
