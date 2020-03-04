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
    public partial class List : Form
    {
        private static List _instance;

        public static List Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new List();

                return _instance;
            }
        }
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            // View_List
            FiguresList figuresList = FiguresList.Instance;
            List<Figure> figures = figuresList.Figures;

            foreach(Figure fig in figures)
            {
                ListViewItem item = new ListViewItem(fig.Label);
                string coords = "(" + fig.Coords.x + ", " + fig.Coords.y + ")";
                item.SubItems.Add(coords);
                item.SubItems.Add(fig.Area.ToString());
                item.SubItems.Add(fig.Color);

                View_List.Items.Add(item);

            }
        }
    }
}
