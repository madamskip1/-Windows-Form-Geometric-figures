using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne.Controller
{
    public class AddDialogController
    {
        private Figures figures;
        private AddDialog AddDialog;

        public AddDialogController() { }

        public void SetFigures(Figures figs)
        {
            figures = figs;
        }

        public void RunModal()
        {
            AddDialog = new AddDialog();
            AddDialog.SetController(this);
            AddDialog.ShowDialog();
        }

        public bool AddFigure()
        {
            string label = AddDialog.Label;
            if (String.IsNullOrEmpty(label))
                return false;

            string color = AddDialog.Color;
            if (String.IsNullOrEmpty(color))
                return false;

            string xText = AddDialog.CoordX;
            if (String.IsNullOrEmpty(xText))
                return false;

            string yText = AddDialog.CoordY;
            if (String.IsNullOrEmpty(yText))
                return false;

            string areaText = AddDialog.Area;
            if (String.IsNullOrEmpty(areaText))
                return false;

            int x = int.Parse(xText);
            int y = int.Parse(yText);
            int area = int.Parse(areaText);

            Figure figure = new Triangle();  // TODO: GET SHAPE

            figure.Label = label;
            figure.Color = color;
            figure.Coords = new Point(x, y);
            figure.Area = area;

            figures.Add(figure);

            return true;
        }
    }
}
