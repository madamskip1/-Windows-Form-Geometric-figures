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
        
        private string previousColor;
        private int? previousArea;
        private Point previousPoint;

        public static Modify _instance;

        public static Modify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Modify();
                return _instance;
            }
        }

        public Modify()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            previousArea = null;
            previousColor = null;
            previousPoint = null;


            Modify_CoordsXInput.Text = "";
            Modify_CoordsYInput.Text = "";
            Modify_AreaInput.Text = "";
            Modify_ColorInput.Text = "";
        }

        private void Add_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Add_AreaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modify_UndoButton_Click(object sender, EventArgs e)
        {
            if (previousArea == null)
                return;

            Modify_ColorInput.Text = previousColor;
            Modify_AreaInput.Text = previousArea.ToString();
            Modify_CoordsXInput.Text = previousPoint.x.ToString();
            Modify_CoordsYInput.Text = previousPoint.y.ToString();
        }

        private void Modify_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void Modify_SearchButton_Click(object sender, EventArgs e)
        {
            string name = Modify_SearchInput.Text;
            Figure fig = FiguresList.Instance.byName(name);

            clearAll();
            if (fig == null)
                return;

            int x = fig.Coords.x;
            int y = fig.Coords.y;
            int area = fig.Area;
            string label = fig.Label;
            string color = fig.Color;

            Modify_CoordsXInput.Text = x.ToString();
            Modify_CoordsYInput.Text = y.ToString();
            Modify_AreaInput.Text = area.ToString();
            Modify_ColorInput.Text = color;

            previousColor = color;
            previousPoint = new Point(x, y);
            previousArea = area;
        }
    }
}
