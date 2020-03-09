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
            InitializeEvents();

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
        

        private void InitializeEvents()
        {

            //DeleteEvent += new EventHandler<FigureEventArgs>(FigureDeleted);
            //ModifyDialog.FigureModified += new EventHandler<FigureEventArgs>(FigureModified);

            //FiguresList
        }
        
        private void AddEvent(object sender, FigureEventArgs args) { AddFigureToView(args.Figure); }
        private void DeleteEvent(object sender, FigureEventArgs args) { DeleteFigureFromView(args.Figure); }

        private void ModifyEvent(object sender, FigureEventArgs args)
        {
            if (args.Figure == args.Previous)
                ModifyFigureInView(args.Figure);
            else
            {
                DeleteFigureFromView(args.Previous);
                AddFigureToView(args.Figure);
            }
        }

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



        /////////////////////////////////////////
        /// OLD
        /// //////////////////////////////////////

        //private void DeleteButtonClicked(object sender, EventArgs e)
        //{
        //    if(MdiParent.ActiveMdiChild != null && MdiParent.ActiveMdiChild == this)
        //    {
        //        if(View_List.SelectedItems.Count > 0)
        //        {
        //            Figures.Instance.Delete((Figure)View_List.SelectedItems[0].Tag);
        //            //View_List.SelectedItems[0].Remove();
        //            //UpdateStatusBar();
        //            if (DeleteEvent != null)
        //                DeleteEvent(this, new FigureEventArgs((Figure)View_List.SelectedItems[0].Tag));
        //        }
        //    }
        //}

        //private void ModifyButtonClicked(object sender, EventArgs e)
        //{
        //    if (MdiParent != null && MdiParent.ActiveMdiChild != null && MdiParent.ActiveMdiChild == this)
        //    {
        //        if (View_List.SelectedItems.Count > 0)
        //        {
        //            new ModifyDialog((Figure)View_List.SelectedItems[0].Tag).ShowDialog();
        //        }
        //    }
        //}

        //private void FigureAdded(object sender, FigureEventArgs e)
        //{
        //    if(CheckFiltr(e.Figure, GetFiltr()))
        //    {
        //        View_List.Items.Add(PrepareViewitem(e.Figure));
        //        UpdateStatusBar();
        //    }
        //}

        //private void FigureDeleted(object sender, FigureEventArgs e)
        //{
        //    ListViewItem item = SearchFigure(e.Figure);
        //    if (item != null)
        //    {
        //        item.Remove();
        //        UpdateStatusBar();
        //    }
        //}

        //private void FigureModified(object sender, FigureEventArgs e)
        //{

        //    ListViewItem item = (e.Previous == null) ? SearchFigure(e.Figure) : SearchFigure(e.Previous);
        //    if (item != null)
        //    {
        //        if (!CheckFiltr(e.Figure, GetFiltr()))
        //        {
        //            item.Remove();
        //            UpdateStatusBar();
        //        }
        //        else
        //        {
        //            item.SubItems.Clear();
        //            item.Text = e.Figure.Label;
        //            string coords = "(" + e.Figure.Coords.X + ", " + e.Figure.Coords.Y + ")";
        //            item.SubItems.Add(coords);
        //            item.SubItems.Add(e.Figure.Area.ToString());
        //            item.SubItems.Add(e.Figure.Color);
        //            item.SubItems.Add(e.Figure.ShapeName());
        //            item.Tag = e.Figure;

        //            if (e.Previous != null)
        //                Figures.Instance.Update(e.Previous, e.Figure);
        //        }
        //    }
        //    else
        //        FigureAdded(sender, e);
        //}

        ////private ListViewItem SearchFigure(Figure fig)
        ////{
        ////    foreach(ListViewItem item in View_List.Items)
        ////    {
        ////        if (item.Tag == fig)
        ////            return item;
        ////    }

        ////    return null;
        ////}

        ////private short GetFiltr()
        ////{
        ////    return (short)ComboBox_Filtr.SelectedIndex;
        ////}


        //private void List_Load(object sender, EventArgs e)
        //{
        //    ShowList(FILTR_ALL);
        //    ComboBox_Filtr.SelectedIndex = 0;
        //}

        ////private void UpdateStatusBar()
        ////{
        ////    StatusBar_Items.Text = View_List.Items.Count.ToString();
        ////}

        ////private bool CheckFiltr(Figure fig, short filtr = ListView.FILTR_ALL)
        ////{
        ////    if (filtr == FILTR_ALL || (filtr == FILTR_LESS && fig.Area < 100) || (filtr == FILTR_GREATER && fig.Area >= 100))
        ////        return true;

        ////    return false;
        ////}

        //private ListViewItem PrepareViewitem(Figure fig)
        //{
        //    ListViewItem item = new ListViewItem(fig.Label);
        //    string coords = "(" + fig.Coords.X + ", " + fig.Coords.Y + ")";
        //    item.SubItems.Add(coords);
        //    item.SubItems.Add(fig.Area.ToString());
        //    item.SubItems.Add(fig.Color);
        //    item.SubItems.Add(fig.ShapeName());
        //    item.Tag = fig;

        //    return item;
        //}


        ////private void ShowList(short filtr = ListView.FILTR_ALL)
        ////{
        ////    View_List.Items.Clear();

        ////    Figures figuresList = Figures.Instance;
        ////    List<Figure> figures = figuresList.Figures;

        ////    foreach (Figure fig in figures)
        ////    {
        ////        if(CheckFiltr(fig, filtr))
        ////        {

        ////            View_List.Items.Add(PrepareViewitem(fig));
        ////        }
        ////    }

        ////    UpdateStatusBar();
        ////}

        //private void List_Activated(object sender, EventArgs e)
        //{
        //    ToolStripManager.RevertMerge("MainForm_StatusBar");
        //    ToolStripManager.Merge(StatusBar, "MainForm_StatusBar");
        //}



        //private void FiltrChanged(object sender, EventArgs e)
        //{
        //    ShowList((short)ComboBox_Filtr.SelectedIndex);
        //}

        //private void ComboBox_Filtr_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    FiltrChanged(sender, e);
        //}

        //private void ComboBox_Filtr_DropDownClosed(object sender, EventArgs e)
        //{
        //    FiltrChanged(sender, e);
        //}



        //private void View_AddButton_Click(object sender, EventArgs e)
        //{
        //    //if (MdiParent.ActiveMdiChild != null)
        //    //    return;

        //    AddDialog addDialog = new AddDialog();
        //    addDialog.Show();
        //}
    }
}
