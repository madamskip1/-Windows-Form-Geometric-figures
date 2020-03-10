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
            ModifyDialog modifyDialog = new ModifyDialog();
            modifyDialog.SetController(this);
            modifyDialog.Label = figure.Label;
            modifyDialog.Color = figure.Color;
            modifyDialog.CoordX = figure.Coords.X.ToString();
            modifyDialog.CoordY = figure.Coords.Y.ToString();
            modifyDialog.Area = figure.Area.ToString();
            modifyDialog.Shape = figure.Shape;
            modifyDialog.ShowDialog();
        }

        public void FigureModified(Figure figCur, Figure newFig)
        {
            if (newFig == null)
                newFig = figCur;

            figures.Update(figCur, newFig);
        }
    }
}
