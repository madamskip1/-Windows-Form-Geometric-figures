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
    public partial class AddDialog : Form
    {
        private Figure drawingFigure;

        private Figure newFigure;

        private Controller.FiguresListViewController controller;


        public AddDialog()
        {
            InitializeComponent();
            Add_ClearButton_Click(this, null);
        }

        public void SetController(Controller.FiguresListViewController ctrl)
        {
            controller = ctrl;
        }

        private void Add_ClearButton_Click(object sender, EventArgs e)
        {
            drawingFigure = new Triangle();
            Add_CoordsXInput.Clear();
            Add_CoordsYInput.Clear();
            Add_ColorInput.Clear();
            Add_AreaInput.Clear();
            Add_NameInput.Clear();
            Refresh();
        }

        private void Add_AddButton_Click(object sender, EventArgs e)
        {
            string name = Add_NameInput.Text;
            if (String.IsNullOrEmpty(name))
                return;

            string color = Add_ColorInput.Text;
            if (String.IsNullOrEmpty(color))
                return;

            string xText = Add_CoordsXInput.Text;
            if (String.IsNullOrEmpty(xText))
                return;

            string yText = Add_CoordsYInput.Text;
            if (String.IsNullOrEmpty(yText))
                return;

            string areaText = Add_AreaInput.Text;
            if (String.IsNullOrEmpty(areaText))
                return;


            int x = int.Parse(xText);
            int y = int.Parse(yText);
            int area = int.Parse(areaText);

            drawingFigure.Area = area;
            drawingFigure.Coords = new Point(x, y);
            drawingFigure.Color = color;
            drawingFigure.Label = name;

            controller.AddFigure(drawingFigure);


            Close();
        }

        private void Add_Activated(object sender, EventArgs e)
        {
        }

        private void Add_AreaInput_Validating(object sender, CancelEventArgs e)
        {
            if(!Figure.ValidateArea(Add_AreaInput.Text))
            {
                Add_ErrorProvider.SetError(Add_AreaInput, "Must be a integer, greater than 0.");
                e.Cancel = true;
            }
        }

        private void Add_AreaInput_Validated(object sender, EventArgs e)
        {
            Add_ErrorProvider.SetError(Add_AreaInput, "");
        }


        private void Add_CoordsXInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateCoord(Add_CoordsXInput.Text))
            {
                Add_ErrorProvider.SetError(Add_CoordsXInput, "Must be a integer.");
                e.Cancel = true;
            }
        }

        private void Add_CoordsXInput_Validated(object sender, EventArgs e)
        {
            Add_ErrorProvider.SetError(Add_CoordsXInput, "");
        }

        private void Add_CoordsYInput_Validated(object sender, EventArgs e)
        {
            Add_ErrorProvider.SetError(Add_CoordsYInput, "");
        }

        private void Add_CoordsYInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateCoord(Add_CoordsYInput.Text))
            {
                Add_ErrorProvider.SetError(Add_CoordsYInput, "Must be a integer.");
                e.Cancel = true;
            }
        }

        private void Add_ColorInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateColor(Add_ColorInput.Text))
            {
                Add_ErrorProvider.SetError(Add_ColorInput, "Must be a HEX color format.");
                e.Cancel = true;
            }
        }

        private void Add_ColorInput_Validated(object sender, EventArgs e)
        {
            Add_ErrorProvider.SetError(Add_ColorInput, "");
        }

        private void Add_NameInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateLabel(Add_NameInput.Text))
            {
                Add_ErrorProvider.SetError(Add_NameInput, "Label cannot be empty.");
                e.Cancel = true;
            }
        }

        private void Add_NameInput_Validated(object sender, EventArgs e)
        {
            Add_ErrorProvider.SetError(Add_NameInput, "");
        }


        private void Add_Draw_Paint(object sender, PaintEventArgs e)
        {
            drawingFigure.Draw(e.Graphics);
        }
        


        private void Add_Draw_Click(object sender, EventArgs e)
        {
            string color = drawingFigure.Color;
            if (drawingFigure.Shape == Figure.Shapes.CIRCLE)
                drawingFigure = new Square();
            else if (drawingFigure.Shape == Figure.Shapes.SQUARE)
                drawingFigure = new Triangle();
            else if (drawingFigure.Shape == Figure.Shapes.TRIANGLE)
                drawingFigure = new Circle();


            drawingFigure.Color = color;

            Add_ColorInput_TextChanged(this, null);
        }



        private void Add_ColorInput_TextChanged(object sender, EventArgs e)
        {
            if (Figure.ValidateColor(Add_ColorInput.Text))
                drawingFigure.Color = Add_ColorInput.Text;
            Refresh();
        }
    }
}
