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
    public partial class Modify : Form
    {
        public static event EventHandler<FigureEventArgs> FigureModified;

        private Figure cur;


        public Modify()
        {
            InitializeComponent();
        }

        public Modify(Figure fig) : this()
        {
            cur = fig;
            FillInputs();
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
            cur.Label = Modify_NameInput.Text;
            cur.Coords.X = int.Parse(Modify_CoordsXInput.Text);
            cur.Coords.Y = int.Parse(Modify_CoordsYInput.Text);
            cur.Area = int.Parse(Modify_AreaInput.Text);
            cur.Color = Modify_ColorInput.Text;

            if (FigureModified != null)
                FigureModified(this, new FigureEventArgs(cur));

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
    }
}
