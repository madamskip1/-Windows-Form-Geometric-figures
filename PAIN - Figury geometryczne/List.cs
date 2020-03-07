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
        public static event EventHandler<FigureEventArgs> DeleteEvent;

        public const short FILTR_ALL = 0;
        public const short FILTR_LESS = 1;
        public const short FILTR_GREATER = 2;


        public List()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public List(ref EventHandler deleteHandler, ref EventHandler modifyHandler) : this()
        {
            deleteHandler += DeleteButtonClicked;
            modifyHandler += ModifyButtonClicked;
        }
        private void InitializeEvents()
        {

            DeleteEvent += new EventHandler<FigureEventArgs>(FigureDeleted);
            //ModifyEvent += new EventHandler<FigureEventArgs>(FigureModified);

            Add.Instance.NewFigureAdded += new EventHandler<FigureEventArgs>(FigureAdded);
            //Delete.Instance.FigureDeleted += new EventHandler<FigureEventArgs>(FigureDeleted);
            Modify.FigureModified += new EventHandler<FigureEventArgs>(FigureModified);
        }


        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            if(MdiParent.ActiveMdiChild != null && MdiParent.ActiveMdiChild == this)
            {
                if(View_List.SelectedItems.Count > 0)
                {
                    FiguresList.Instance.delete((Figure)View_List.SelectedItems[0].Tag);
                    //View_List.SelectedItems[0].Remove();
                    //UpdateStatusBar();
                    if (DeleteEvent != null)
                        DeleteEvent(this, new FigureEventArgs((Figure)View_List.SelectedItems[0].Tag));
                }
            }
        }

        private void ModifyButtonClicked(object sender, EventArgs e)
        {
            if (MdiParent.ActiveMdiChild != null && MdiParent.ActiveMdiChild == this)
            {
                if (View_List.SelectedItems.Count > 0)
                {
                    new Modify((Figure)View_List.SelectedItems[0].Tag).ShowDialog();
                }
            }
        }

        private void FigureAdded(object sender, FigureEventArgs e)
        {
            if(CheckFiltr(e.figure, GetFiltr()))
            {
                View_List.Items.Add(PrepareViewitem(e.figure));
                UpdateStatusBar();
            }
        }

        private void FigureDeleted(object sender, FigureEventArgs e)
        {
            ListViewItem item = SearchFigure(e.figure);
            if (item != null)
            {
                item.Remove();
                UpdateStatusBar();
            }
        }

        private void FigureModified(object sender, FigureEventArgs e)
        {
            ListViewItem item = SearchFigure(e.figure);
            if (item != null)
            {
                if (!CheckFiltr(e.figure, GetFiltr()))
                {
                    item.Remove();
                    UpdateStatusBar();
                }
                else
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
            else
                FigureAdded(sender, e);
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

        private void UpdateStatusBar()
        {
            StatusBar_Items.Text = View_List.Items.Count.ToString();
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

            UpdateStatusBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                ShowList(GetFiltr());
        }

        private void List_Activated(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge("MainForm_StatusBar");
            ToolStripManager.Merge(StatusBar, "MainForm_StatusBar");
        }
    }
}
