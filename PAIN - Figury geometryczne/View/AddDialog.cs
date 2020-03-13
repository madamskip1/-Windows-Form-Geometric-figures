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
        private Controller.AddDialogController controller;


        public string CoordX
        {
            get { return Add_CoordsXInput.Text; }
            set { Add_CoordsXInput.Text = value; }
        }

        public string CoordY
        {
            get { return Add_CoordsYInput.Text; }
            set { Add_CoordsYInput.Text = value; }
        }

        public string Area
        {
            get { return Add_AreaInput.Text; }
            set { Add_AreaInput.Text = value; }
        }

        public string Color
        {
            get { return Add_ColorInput.Text; }
            set { Add_ColorInput.Text = value; }
        }

        public string Label
        {
            get { return Add_NameInput.Text; }
            set { Add_NameInput.Text = value; }
        }
       
        public Figure.Shapes Shape
        {
            get
            {
                return Add_DrawPanel.Shape;
            }
        }



        public AddDialog()
        {
            InitializeComponent();
            Add_ClearButton_Click(this, null);
        }

        public void SetController(Controller.AddDialogController ctrl)
        {
            controller = ctrl;
        }

        private void Add_ClearButton_Click(object sender, EventArgs e)
        {
            Add_DrawPanel.Shape = Figure.Shapes.TRIANGLE;
            Add_CoordsXInput.Clear();
            Add_CoordsYInput.Clear();
            Add_ColorInput.Clear();
            Add_AreaInput.Clear();
            Add_NameInput.Clear();
            Refresh();
        }

        private void Add_AddButton_Click(object sender, EventArgs e)
        {
            if (controller.AddFigure())
                Close();
        }




        /// ////////////////////////////////////////
        ///             VALIDATING           //////
        /// ///////////////////////////////////////


        private void Add_AreaInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Figure.ValidateArea(Add_AreaInput.Text))
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
        
        /// ////////////////////////////////////////
        ///             VALIDATING END       //////
        /// ///////////////////////////////////////




        private void Add_ColorInput_TextChanged(object sender, EventArgs e)
        {
            if (Figure.ValidateColor(Add_ColorInput.Text))
            {
                Add_DrawPanel.Color = Add_ColorInput.Text;
                Add_DrawPanel.ReDraw();
            }
        }
    }
}
