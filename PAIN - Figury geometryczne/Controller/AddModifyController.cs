using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public class AddModifyController
    {
        private enum DialogTypes { NONE, MODIFY, ADD }
        private DialogTypes dialogType;
        private AddModifyDialog dialog;
        private Figures figures;
        private Figure figureToModify;

        private string Label { get {  return dialog.Label; } }
        private string Color { get { return dialog.Color; } }
        private string XText { get { return dialog.CoordX; } }
        private string YText { get { return dialog.CoordY; } }
        private string AreaText { get { return dialog.Area; } }
        private int XCoord { get { return int.Parse(XText); } }
        private int YCoord { get { return int.Parse(YText); }  }
        private int Area { get { return int.Parse(AreaText); } }
        private Figure.Shapes Shape { get { return dialog.Shape; } }
        

        public void SetFigures(Figures figs)
        {
            figures = figs;
        }

        public void SetFigureToModify(Figure fig)
        {
            figureToModify = fig;
        }



        // Open modal form to Add Figure
        public void RunAddModal()
        {
            dialog = new AddModifyDialog();
            dialogType = DialogTypes.ADD;
            dialog.SetController(this);
            dialog.SetFormTitle("Add figure");
            dialog.ShowDialog();
        }

        // Open modal form to Modify Figure
        public void RunModifyModal()
        {
            dialog = new AddModifyDialog();
            dialogType = DialogTypes.MODIFY;
            dialog.SetController(this);
            dialog.SetFormTitle("Modify figure");

            // Set inputs text property with figure's property
            dialog.Shape = figureToModify.Shape;
            dialog.Label = figureToModify.Label;
            dialog.Color = figureToModify.Color;
            dialog.CoordX = figureToModify.Coords.X.ToString();
            dialog.CoordY = figureToModify.Coords.Y.ToString();
            dialog.Area = figureToModify.Area.ToString();

            dialog.ShowDialog();
        }

        // Ok button clicked in modal form
        public void OkButtonClicked()
        {
            if (dialogType == DialogTypes.ADD)
                AddFigure();
            else if (dialogType == DialogTypes.MODIFY)
                ModifyFigure();
        }

        // Modal form closed 
        public void DialogClosed()
        {
            dialogType = DialogTypes.NONE;
        }

        // Ok button clicked in Add Figure modal
        private void AddFigure()
        {
            if (!CheckInputs())
                return;

            Figure fig = new Figure(Shape);
            fig.Label = Label;
            fig.Color = Color;
            fig.Coords = new Point(XCoord, YCoord);
            fig.Area = Area;

            figures.Add(fig);

            dialog.Close();
        }

        // OK button Clicked in Modify Figure modal
        private void ModifyFigure()
        {
            if (!CheckInputs())
                return;

            figureToModify.Label = Label;
            figureToModify.Color = Color;
            figureToModify.Area = Area;
            figureToModify.Coords.X = XCoord;
            figureToModify.Coords.Y = YCoord;
            figureToModify.Shape = Shape;

            figures.Update(figureToModify);

            dialog.Close();
        }

        // Validate if all inputs aren't empty
        private bool CheckInputs()
        {
            if (String.IsNullOrEmpty(Label))
                return false;

            if (String.IsNullOrEmpty(Color))
                return false;

            if (String.IsNullOrEmpty(XText))
                return false;

            if (String.IsNullOrEmpty(YText))
                return false;

            if (String.IsNullOrEmpty(AreaText))
                return false;

            return true;
        }



    }
}
