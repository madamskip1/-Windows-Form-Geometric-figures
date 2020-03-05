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
        public const short FILTR_ALL = 0;
        public const short FILTR_LESS = 1;
        public const short FILTR_GREATER = 2;


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
            Add.Instance.AddEvent += button1_Click;
            Delete.Instance.DeleteEvent += button1_Click;
            Modify.Instance.ModifyEvent += button1_Click;
        }

        private void List_Load(object sender, EventArgs e)
        {
            showList(FILTR_ALL);
        }

        private void showList(short filtr = List.FILTR_ALL)
        {
            View_List.Items.Clear();

            FiguresList figuresList = FiguresList.Instance;
            List<Figure> figures = figuresList.Figures;

            foreach (Figure fig in figures)
            {
                if (filtr == FILTR_ALL || (filtr == FILTR_LESS && fig.Area < 100) || (filtr == FILTR_GREATER && fig.Area >= 100))
                    {
                    ListViewItem item = new ListViewItem(fig.Label);
                    string coords = "(" + fig.Coords.X + ", " + fig.Coords.Y + ")";
                    item.SubItems.Add(coords);
                    item.SubItems.Add(fig.Area.ToString());
                    item.SubItems.Add(fig.Color);
                    item.SubItems.Add(fig.ShapeName());
                    View_List.Items.Add(item);
                }
            }
        }

        private void Filtr_Less_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Filtr_Greater.Checked)
                showList(FILTR_GREATER);
            else if (Filtr_Less.Checked)
                showList(FILTR_LESS);
            else
                showList(FILTR_ALL);
        }
    }
}
