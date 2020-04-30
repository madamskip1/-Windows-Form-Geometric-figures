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
    public partial class AddModifyDialog : Form
    {
        public string CoordX
        {
            get { return CoordsXInput.Text; }
            set { CoordsXInput.Text = value; }
        }
        public string CoordY
        {
            get { return CoordsYInput.Text; }
            set { CoordsYInput.Text = value; }
        }
        public string Area
        {
            get { return AreaInput.Text; }
            set { AreaInput.Text = value; }
        }
        public string Color
        {
            get { return ColorInput.Text; }
            set { ColorInput.Text = value; }
        }
        public string Label
        {
            get { return NameInput.Text; }
            set { NameInput.Text = value; }
        }
        public Figure.Shapes Shape
        {
            get { return DrawPanel.Shape; }
            set { DrawPanel.Shape = value; }
        }


        private AddModifyController controller;

        public AddModifyDialog()
        {
            InitializeComponent();
        }

        public void SetFormTitle(string title)
        {
            this.Text = title; 
        }


        public void SetController(AddModifyController ctrl)
        {
            controller = ctrl;
        }







        private void ColorInput_TextChanged(object sender, EventArgs e)
        {
            if (Figure.ValidateColor(ColorInput.Text))
            {
                DrawPanel.Color = ColorInput.Text;
                DrawPanel.ReDraw();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            controller.OkButtonClicked();
        }

        private void AddModifyDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.DialogClosed();
        }







        /// ////////////////////////////////////////
        ///             VALIDATING           //////
        /// ///////////////////////////////////////


        private void AreaInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateArea(AreaInput.Text))
            {
                errorProvider.SetError(AreaInput, "Must be a integer, greater than 0.");
                e.Cancel = true;
            }
        }

        private void AreaInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(AreaInput, "");
        }
        
        private void CoordsXInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateCoord(CoordsXInput.Text))
            {
                errorProvider.SetError(CoordsXInput, "Must be a integer.");
                e.Cancel = true;
            }
        }

        private void CoordsXInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(CoordsXInput, "");
        }

        private void CoordsYInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(CoordsYInput, "");
        }

        private void CoordsYInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateCoord(CoordsYInput.Text))
            {
                errorProvider.SetError(CoordsYInput, "Must be a integer.");
                e.Cancel = true;
            }
        }

        private void ColorInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateColor(ColorInput.Text))
            {
                errorProvider.SetError(ColorInput, "Must be a HEX color format.");
                e.Cancel = true;
            }
        }

        private void ColorInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(ColorInput, "");
        }

        private void NameInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateLabel(NameInput.Text))
            {
                errorProvider.SetError(NameInput, "Label cannot be empty.");
                e.Cancel = true;
            }
        }

        private void NameInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(NameInput, "");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// ////////////////////////////////////////
        ///             VALIDATING END       //////
        /// ///////////////////////////////////////

    }
}
