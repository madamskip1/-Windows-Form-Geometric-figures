using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PAIN___Figury_geometryczne.View
{
    public partial class DrawFigure : UserControl
    {

        private Color DrawingColor
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml(Color);
            }
        }

        public Figure.Shapes Shape { get; private set; }
        public string Color { get; set; }

        public DrawFigure()
        {
            InitializeComponent();
            Color = "#000000";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void Draw(Graphics graphic)
        {
            switch(Shape)
            {
                case Figure.Shapes.CIRCLE:
                    DrawCircle(graphic);
                    break;
                case Figure.Shapes.SQUARE:
                    DrawSquare(graphic);
                    break;
                case Figure.Shapes.TRIANGLE:
                    DrawTriangle(graphic);
                    break;
            }
        }

        private void DrawTriangle(Graphics graphic)
        {
            Pen pen = new Pen(DrawingColor, 5);
            Brush brush = new SolidBrush(DrawingColor);

            System.Drawing.Point point1 = new System.Drawing.Point(20, 107);
            System.Drawing.Point point2 = new System.Drawing.Point(107, 107);
            System.Drawing.Point point3 = new System.Drawing.Point(63, 20);

            System.Drawing.Point[] curvePoints = { point1, point2, point3 };
            graphic.FillPolygon(brush, curvePoints);
            graphic.Dispose();
        }

        private void DrawCircle(Graphics graphic)
        {
            Pen pen = new Pen(DrawingColor, 5);
            Brush brush = new SolidBrush(DrawingColor);

            Rectangle rec = new Rectangle(20, 20, 100, 100);
            graphic.FillEllipse(brush, rec);
            graphic.Dispose();

        }

        private void DrawSquare(Graphics graphic)
        {
            Pen pen = new Pen(DrawingColor, 5);
            Brush brush = new SolidBrush(DrawingColor);

            Rectangle rec = new Rectangle(20, 20, 100, 100);
            graphic.FillRectangle(brush, rec);
            graphic.Dispose();
        }
    }
}
