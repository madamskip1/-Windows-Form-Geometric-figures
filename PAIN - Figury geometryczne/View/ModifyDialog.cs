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
        private Controller.ModifyDialogController controller;

        public string CoordX
        {
            get { return Modify_CoordsXInput.Text; }
            set { Modify_CoordsXInput.Text = value; }
        }

        public string CoordY
        {
            get { return Modify_CoordsYInput.Text; }
            set { Modify_CoordsYInput.Text = value; }
        }

        public string Area
        {
            get { return Modify_AreaInput.Text; }
            set { Modify_AreaInput.Text = value; }
        }

        public string Color
        {
            get { return Modify_ColorInput.Text; }
            set { Modify_ColorInput.Text = value; }
        }

        public string Label
        {
            get { return Modify_NameInput.Text; }
            set { Modify_NameInput.Text = value; }
        }

        public Figure.Shapes Shape
        {
            get
            {
                return Modify_DrawPanel.Shape;
            }
        }

        public ModifyDialog()
        {
            InitializeComponent();
        }

        public ModifyDialog(Figure.Shapes shape)
        {
            InitializeComponent();
            Modify_DrawPanel.Shape = shape;
        }


        public void SetController(Controller.ModifyDialogController ctrl)
        {
            controller = ctrl;
        }


        private void Modify_ModifyButton_Click(object sender, EventArgs e)
        {

            if (controller.ModifyFigure())
                Close();
        }

        /// ////////////////////////////////////////
        ///             VALIDATING           //////
        /// ///////////////////////////////////////

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

        /// ////////////////////////////////////////
        ///             VALIDATING   End     //////
        /// ///////////////////////////////////////


        private void Modify_ColorInput_TextChanged(object sender, EventArgs e)
        {
            if (Figure.ValidateColor(Modify_ColorInput.Text))
            {
                Modify_DrawPanel.Color = Modify_ColorInput.Text;
                Modify_DrawPanel.ReDraw();
            }
        }


        private void Modify_CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
