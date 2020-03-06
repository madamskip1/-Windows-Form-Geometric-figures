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
    public partial class Add : Form
    {
        public event EventHandler<FigureEventArgs> NewFigureAdded;

        private static Add _instance;

        public static Add Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Add();
                return _instance;
            }
        }

        public Add()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void Add_ClearButton_Click(object sender, EventArgs e)
        {
            Add_CoordsXInput.Clear();
            Add_CoordsYInput.Clear();
            Add_ColorInput.Clear();
            Add_AreaInput.Clear();
            Add_NameInput.Clear();
        }

        private void Add_AddButton_Click(object sender, EventArgs e)
        {
            string name = Add_NameInput.Text;
            string color = Add_ColorInput.Text;
            int x = int.Parse(Add_CoordsXInput.Text);
            int y = int.Parse(Add_CoordsYInput.Text);
            int area = int.Parse(Add_AreaInput.Text);

            FiguresList figures = FiguresList.Instance;
            Figure figure = figures.byName(name);
            if (figure != null)
                return;

            figure = new Triangle();
            figure.Area = area;
            figure.Coords = new Point(x, y);
            figure.Color = color;
            figure.Label = name;

            figures.add(figure);

            if (NewFigureAdded != null)
                NewFigureAdded(this, new FigureEventArgs(figure));
        }

        private void Add_Activated(object sender, EventArgs e)
        {
        }
    }
}
