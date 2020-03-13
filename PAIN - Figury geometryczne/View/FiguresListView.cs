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
    public partial class FiguresListView : Form
    {
        public const short FILTR_ALL = 0;
        public const short FILTR_LESS = 1;
        public const short FILTR_GREATER = 2;

        private ListView listView;
        private Controller.FiguresListViewController Controller;
        private Figures figures;

        public FiguresListView()
        {
            InitializeComponent();
            
            listView = View_List;
        }

        public void LoadFiguresList(Figures figs)
        {
            figures = figs;
            figures.NewFigureAddedEvent += new EventHandler<FigureEventArgs>(AddEvent);
            figures.FigureDeletedEvent += new EventHandler<FigureEventArgs>(DeleteEvent);
            figures.FigureModifiedEvent += new EventHandler<FigureEventArgs>(ModifyEvent);
            ShowList();
        }

        public void SetController(Controller.FiguresListViewController ctrl)
        {
            Controller = ctrl;
        }
        
        // Add event - invoked after adding figure
        private void AddEvent(object sender, FigureEventArgs args) { AddFigureToView(args.Figure); }

        // Delete event - invoked after deleting figure
        private void DeleteEvent(object sender, FigureEventArgs args) { DeleteFigureFromView(args.Figure); }

        // Modify event - invoked after modifying figure
        private void ModifyEvent(object sender, FigureEventArgs args) { ModifyFigureInView(args.Figure); }
        

        private void ShowList()
        {
            listView.Items.Clear();

            foreach (Figure fig in figures._Figures)
            {
                if (CheckFiltr(fig, GetFiltr()))
                    AddFigureToView(fig, false);
            }

            UpdateStatusBar();
        }


        private void DeleteFigureFromView(Figure fig)
        {
            ListViewItem item = SearchFigure(fig);
            if (item != null)
                DeleteItemFromView(item);

        }
        

        private void DeleteItemFromView(ListViewItem item)
        {
            item.Remove();
            UpdateStatusBar();
        }

        private void AddFigureToView(Figure fig, bool update = true)
        {
            if(CheckFiltr(fig, GetFiltr()))
            {
                ListViewItem item = new ListViewItem();
                item.Text = fig.Label;
                string coords = "(" + fig.Coords.X + ", " + fig.Coords.Y + ")";
                item.SubItems.Add(coords);
                item.SubItems.Add(fig.Area.ToString());
                item.SubItems.Add(fig.Color);
                item.SubItems.Add(fig.ShapeName());
                item.Tag = fig;

                listView.Items.Add(item);
                if (update == true) UpdateStatusBar();
            }
        }

        private void ModifyFigureInView(Figure fig)
        {
            ListViewItem item = SearchFigure(fig);

            if (item != null)
            {
                if (!CheckFiltr(fig, GetFiltr()))
                    DeleteItemFromView(item);
                else
                {
                    item.Text = fig.Label;
                    string coords = "(" + fig.Coords.X + ", " + fig.Coords.Y + ")";
                    item.SubItems[1].Text = coords;
                    item.SubItems[2].Text = fig.Area.ToString();
                    item.SubItems[3].Text = fig.Color;
                    item.SubItems[4].Text = fig.ShapeName();
                    item.Tag = fig;
                }
            }
            else
                AddFigureToView(fig);
        }

        private ListViewItem SearchFigure(Figure fig)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag == fig)
                    return item;
            }

            return null;
        }


        private void UpdateStatusBar()
        {
            StatusBar_Items.Text = listView.Items.Count.ToString();
        }

        private short GetFiltr()
        {
            if (ComboBox_Filtr == null)
                return FILTR_ALL;

            short filtr = (short)ComboBox_Filtr.SelectedIndex;
            return (filtr > 0 ? filtr : FILTR_ALL);
        }

        private bool CheckFiltr(Figure fig, short filtr = FiguresListView.FILTR_ALL)
        {
            if (filtr == FILTR_ALL || (filtr == FILTR_LESS && fig.Area < 100) || (filtr == FILTR_GREATER && fig.Area >= 100))
                return true;

            return false;
        }

        private void View_AddButton_Click(object sender, EventArgs e)
        {
            Controller.AddClicked();
        }

        private void View_ModifyButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
                Controller.ModifyClicked((Figure)listView.SelectedItems[0].Tag);
        }

        private void View_DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
                Controller.DeleteClicked((Figure)listView.SelectedItems[0].Tag);
        }

        private void FiguresListView_Activated(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge("MainForm_StatusBar");
            ToolStripManager.Merge(StatusBar, "MainForm_StatusBar");
        }

        private void FiguresListView_Load(object sender, EventArgs e)
        {
            ComboBox_Filtr.SelectedIndex = 0;
        }

        private void ComboBox_Filtr_DropDownClosed(object sender, EventArgs e)
        {
            ShowList();
        }

        private void ComboBox_Filtr_TextChanged(object sender, EventArgs e)
        {
            ShowList();
        }

        private void View_List_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (View_List.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_ModifyButton_Click(this, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_DeleteButton_Click(this, null);
        }

        private void FiguresListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent.MdiChildren.Length < 2)
                e.Cancel = true;
        }
    }
}
