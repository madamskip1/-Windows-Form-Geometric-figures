using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;

namespace PAIN___Figury_geometryczne.View
{
    class FigureEditor : System.Drawing.Design.UITypeEditor
    {
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            Figure.Shapes shape = (Figure.Shapes)e.Value;
            switch (shape)
            {
                case Figure.Shapes.CIRCLE:
                    DrawCircle(e);
                    break;
                case Figure.Shapes.SQUARE:
                    DrawSquare(e);
                    break;
                case Figure.Shapes.TRIANGLE:
                    DrawTriangle(e);
                    break;
            }
            
            //Graphics graphic = e.Graphics;
            //Pen pen = new Pen(Brushes.Aqua, 5);
            //Brush brush = new SolidBrush(Color.FromName("Aqua"));

            //Rectangle rec = new Rectangle(20, 20, 100, 100);
            //graphic.FillEllipse(brush, rec);
            //graphic.Dispose();
            //e.Graphics.FillRectangle(new SolidBrush(Color.DarkBlue), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            base.PaintValue(e);
        }

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {

            System.Windows.Forms.Design.IWindowsFormsEditorService edSvc = (System.Windows.Forms.Design.IWindowsFormsEditorService)provider.GetService(typeof(System.Windows.Forms.Design.IWindowsFormsEditorService));
            if (edSvc != null)
            {
                DrawFigure drawFigure = new DrawFigure();
                drawFigure.Shape = (Figure.Shapes)value;
                edSvc.DropDownControl(drawFigure);


                return drawFigure.Shape;
            }

            return value;
        }

        private void DrawTriangle(System.Drawing.Design.PaintValueEventArgs e)
        {
            int padding = e.Bounds.Width / 8;
            Pen pen = new Pen(Brushes.Aqua, 5);
            Brush brush = new SolidBrush(Color.FromName("Aqua"));
            System.Drawing.Point point1 = new System.Drawing.Point(e.Bounds.Width / 2, padding);
            System.Drawing.Point point2 = new System.Drawing.Point(padding, e.Bounds.Height - padding);
            System.Drawing.Point point3 = new System.Drawing.Point(e.Bounds.Width - padding, e.Bounds.Height - padding);

            System.Drawing.Point[] curvePoints = { point1, point2, point3 };
            e.Graphics.FillPolygon(brush, curvePoints);
        }
        private void DrawCircle(System.Drawing.Design.PaintValueEventArgs e)
        {
            int padding = e.Bounds.Width / 8;
            Pen pen = new Pen(Brushes.Aqua, 5);
            Brush brush = new SolidBrush(Color.FromName("Aqua"));
            Rectangle rec = new Rectangle(e.Bounds.X+padding, e.Bounds.Y+padding, e.Bounds.Height- 2*padding, e.Bounds.Height - 2*padding);
            e.Graphics.FillEllipse(brush, rec);
        }

        private void DrawSquare(System.Drawing.Design.PaintValueEventArgs e)
        {
            int padding = e.Bounds.Width / 8;
            Pen pen = new Pen(Brushes.Aqua, 5);
            Brush brush = new SolidBrush(Color.FromName("Aqua"));
            Rectangle rec = new Rectangle(e.Bounds.X + padding, e.Bounds.Y + padding, e.Bounds.Height - 2 * padding, e.Bounds.Height - 2 * padding);
            e.Graphics.FillRectangle(brush, rec);
        }
    }
}
