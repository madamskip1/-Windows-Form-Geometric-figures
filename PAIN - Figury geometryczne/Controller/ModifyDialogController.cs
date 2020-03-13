using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne.Controller
{
    public class ModifyDialogController
    {
        private Figures figures;
        private Figure figure;
        private ModifyDialog modifyDialog;

        public ModifyDialogController()
        {

        }

        public void SetFigures(Figures figs)
        {
            figures = figs;
        }

        public void SetFigure(Figure fig)
        {
            figure = fig;
        }

        public void RunModal()
        {
            modifyDialog = new ModifyDialog(figure.Shape);
            modifyDialog.SetController(this);
            modifyDialog.Label = figure.Label;
            modifyDialog.Color = figure.Color;
            modifyDialog.CoordX = figure.Coords.X.ToString();
            modifyDialog.CoordY = figure.Coords.Y.ToString();
            modifyDialog.Area = figure.Area.ToString();
            modifyDialog.ShowDialog();
        }


        public bool ModifyFigure() 
        {
            string label = modifyDialog.Label;
            if (String.IsNullOrEmpty(label))
                return false;

            string color = modifyDialog.Color;
            if (String.IsNullOrEmpty(color))
                return false;

            string xText = modifyDialog.CoordX;
            if (String.IsNullOrEmpty(xText))
                return false;

            string yText = modifyDialog.CoordY;
            if (String.IsNullOrEmpty(yText))
                return false;

            string areaText = modifyDialog.Area;
            if (String.IsNullOrEmpty(areaText))
                return false;

            figure.Label = label;
            figure.Color = color;
            figure.Area = int.Parse(areaText);
            figure.Shape = modifyDialog.Shape;
            figure.Coords.X = int.Parse(xText);
            figure.Coords.Y = int.Parse(yText);

            figures.Update(figure);
            return true;
        }
    }
}
