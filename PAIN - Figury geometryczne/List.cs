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
                {
                    _instance = new List();
                    _instance.InitializeEvents();
                }

                return _instance;
            }
        }
        public List()
        {
            InitializeComponent();
        }

        private void InitializeEvents()
        {
            //Modify.Instance.ModifyEvent += button1_Click;

            Add.Instance.NewFigureAdded += new EventHandler<FigureEventArgs>(FigureAdded);
            Delete.Instance.FigureDeleted += new EventHandler<FigureEventArgs>(FigureDeleted);
            Modify.Instance.FigureModified += new EventHandler<FigureEventArgs>(FigureModified);
        }

        private void FigureAdded(object sender, FigureEventArgs e)
        {
            if(CheckFiltr(e.figure, GetFiltr()))
            {
                View_List.Items.Add(PrepareViewitem(e.figure));
            }
        }

        private void FigureDeleted(object sender, FigureEventArgs e)
        {
            ListViewItem item = SearchFigure(e.figure);
            if (item != null)
                item.Remove();
        }

        private void FigureModified(object sender, FigureEventArgs e)
        {
            ListViewItem item = SearchFigure(e.figure);
            if (item != null)
            {
                item.SubItems.Clear();
                item.Text = e.figure.Label;
                string coords = "(" + e.figure.Coords.X + ", " + e.figure.Coords.Y + ")";
                item.SubItems.Add(coords);
                item.SubItems.Add(e.figure.Area.ToString());
                item.SubItems.Add(e.figure.Color);
                item.SubItems.Add(e.figure.ShapeName());
                item.Tag = e.figure;
            }
        }

        private ListViewItem SearchFigure(Figure fig)
        {
            foreach(ListViewItem item in View_List.Items)
            {
                if (item.Tag == fig)
                    return item;
            }

            return null;
        }

        private short GetFiltr()
        {
            if (Filtr_Greater.Checked)
                return FILTR_GREATER;
            else if (Filtr_Less.Checked)
                return FILTR_LESS;
            else
                return FILTR_ALL;
        }


        private void List_Load(object sender, EventArgs e)
        {
            ShowList(FILTR_ALL);
        }

        private bool CheckFiltr(Figure fig, short filtr = List.FILTR_ALL)
        {
            if (filtr == FILTR_ALL || (filtr == FILTR_LESS && fig.Area < 100) || (filtr == FILTR_GREATER && fig.Area >= 100))
                return true;

            return false;
        }

        private ListViewItem PrepareViewitem(Figure fig)
        {
            ListViewItem item = new ListViewItem(fig.Label);
            string coords = "(" + fig.Coords.X + ", " + fig.Coords.Y + ")";
            item.SubItems.Add(coords);
            item.SubItems.Add(fig.Area.ToString());
            item.SubItems.Add(fig.Color);
            item.SubItems.Add(fig.ShapeName());
            item.Tag = fig;

            return item;
        }


        private void ShowList(short filtr = List.FILTR_ALL)
        {
            View_List.Items.Clear();

            FiguresList figuresList = FiguresList.Instance;
            List<Figure> figures = figuresList.Figures;

            foreach (Figure fig in figures)
            {
                if(CheckFiltr(fig, filtr))
                {

                    View_List.Items.Add(PrepareViewitem(fig));
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                ShowList(GetFiltr());
        }
    }
}
