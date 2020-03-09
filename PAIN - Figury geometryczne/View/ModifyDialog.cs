using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN___Figury_geometryczne
{
    public partial class ModifyDialog : Form
    {
        public static event EventHandler<FigureEventArgs> FigureModified;

        private Figure cur;
        private Figure drawingFigure;
        private Controller.FiguresListViewController controller;
        public ModifyDialog()
        {
            InitializeComponent();
        }

        public ModifyDialog(Figure fig) : this()
        {
            cur = fig;

            if (cur.Shape == Figure.Shapes.CIRCLE)
                drawingFigure = new Circle();
            else if (cur.Shape == Figure.Shapes.TRIANGLE)
                drawingFigure = new Triangle();
            else if (cur.Shape == Figure.Shapes.SQUARE)
                drawingFigure = new Square();

            drawingFigure.Color = cur.Color;
            
            FillInputs();
        }

        public void SetController(Controller.FiguresListViewController ctrl)
        {
            controller = ctrl;
        }

        private void FillInputs()
        {
            int x = cur.Coords.X;
            int y = cur.Coords.Y;
            int area = cur.Area;
            string label = cur.Label;
            string color = cur.Color;

            Modify_NameInput.Text = label;
            Modify_CoordsXInput.Text = x.ToString();
            Modify_CoordsYInput.Text = y.ToString();
            Modify_AreaInput.Text = area.ToString();
            Modify_ColorInput.Text = color;
        }

        private void Modify_UndoButton_Click(object sender, EventArgs e)
        {
            Modify_NameInput.Text = cur.Label;
            Modify_ColorInput.Text = cur.Color;
            Modify_AreaInput.Text = cur.Area.ToString();
            Modify_CoordsXInput.Text = cur.Coords.X.ToString();
            Modify_CoordsYInput.Text = cur.Coords.Y.ToString();
        }


        private void Modify_ModifyButton_Click(object sender, EventArgs e)
        {
            FigureEventArgs args;
            if(cur.Shape != drawingFigure.Shape)
            {
                drawingFigure.Label = Modify_NameInput.Text;
                drawingFigure.Coords.X = int.Parse(Modify_CoordsXInput.Text);
                drawingFigure.Coords.Y = int.Parse(Modify_CoordsYInput.Text);
                drawingFigure.Area = int.Parse(Modify_AreaInput.Text);
                drawingFigure.Color = Modify_ColorInput.Text;
            }
            else
            {
                cur.Label = Modify_NameInput.Text;
                cur.Coords.X = int.Parse(Modify_CoordsXInput.Text);
                cur.Coords.Y = int.Parse(Modify_CoordsYInput.Text);
                cur.Area = int.Parse(Modify_AreaInput.Text);
                cur.Color = Modify_ColorInput.Text;
                drawingFigure = null;
                //args = new FigureEventArgs(cur);
            }

            controller.FigureModified(cur, drawingFigure);
            //if (FigureModified != null)
            //    FigureModified(this, args);

            Close();
        }

        private void Modify_NameInput_Validated(object sender, EventArgs e)
        {
            Modify_ErrorProvider.SetError(Modify_NameInput, "");
        }

        private void Modify_NameInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateLabel(Modify_NameInput.Text))
            {
                Modify_ErrorProvider.SetError(Modify_NameInput, "Label cannot be empty.");
                e.Cancel = true;
            }
        }

        private void Modify_AreaInput_Validated(object sender, EventArgs e)
        {
            Modify_ErrorProvider.SetError(Modify_AreaInput, "");
        }

        private void Modify_AreaInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateArea(Modify_AreaInput.Text))
            {
                Modify_ErrorProvider.SetError(Modify_AreaInput, "Must be a integer, greater than 0.");
                e.Cancel = true;
            }
        }

        private void Modify_ColorInput_Validated(object sender, EventArgs e)
        {
            Modify_ErrorProvider.SetError(Modify_ColorInput, "");
        }

        private void Modify_ColorInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateColor(Modify_ColorInput.Text))
            {
                Modify_ErrorProvider.SetError(Modify_ColorInput, "Must be a HEX color format.");
                e.Cancel = true;
            }
        }

        private void Modify_CoordsXInput_Validated(object sender, EventArgs e)
        {
            Modify_ErrorProvider.SetError(Modify_CoordsXInput, "");

        }

        private void Modify_CoordsXInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateCoord(Modify_CoordsXInput.Text))
            {
                Modify_ErrorProvider.SetError(Modify_CoordsXInput, "Must be a integer.");
                e.Cancel = true;
            }
        }

        private void Modify_CoordsYInput_Validated(object sender, EventArgs e)
        {
            Modify_ErrorProvider.SetError(Modify_CoordsYInput, "");
        }

        private void Modify_CoordsYInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateCoord(Modify_CoordsYInput.Text))
            {
                Modify_ErrorProvider.SetError(Modify_CoordsYInput, "Must be a integer.");
                e.Cancel = true;
            }
        }

        private void Modify_Draw_Paint(object sender, PaintEventArgs e)
        {

            drawingFigure.Draw(e.Graphics);
        }

        private void Modify_ColorInput_TextChanged(object sender, EventArgs e)
        {
            if (Figure.ValidateColor(Modify_ColorInput.Text))
                drawingFigure.Color = Modify_ColorInput.Text;
            Refresh();
        }

        private void Modify_Draw_Click(object sender, EventArgs e)
        {
            if (drawingFigure.Shape == Figure.Shapes.CIRCLE)
                drawingFigure = new Square();
            else if (drawingFigure.Shape == Figure.Shapes.SQUARE)
                drawingFigure = new Triangle();
            else if (drawingFigure.Shape == Figure.Shapes.TRIANGLE)
                drawingFigure = new Circle();

            drawingFigure.Color = cur.Color;

            Modify_ColorInput_TextChanged(this, null);
        }
    }
}
