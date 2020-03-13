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
    public partial class MainForm : Form
    {


        private Controller.FiguresListViewController FiguresListViewController;
        private Figures figures;

        public MainForm()
        {
            InitializeComponent();

            figures = new Figures();
            FiguresListViewController = new Controller.FiguresListViewController();
            FiguresListViewController.SetFigures(figures);
            TestValues();
        }


        // Check if form can be closed (at least one form alive)
        void closingChild(object sender, FormClosingEventArgs e)
        {
           // if (this.MdiChildren.Length < 2)
            //    e.Cancel = true;
        }




        private void MainButtons_New_View_Click(object sender, EventArgs e)
        {
            FiguresListView list = new FiguresListView();

            //controller.SetListView(list);
            list.SetController(FiguresListViewController);

            list.LoadFiguresList(figures);

            list.MdiParent = this;
            //list.FormClosing += closingChild;
            list.Show();
            list.Activate();
        }




        // Add test values to list 
        // Just for tests
        private void TestValues()
        {
            Figure fig1 = new Figure(Figure.Shapes.TRIANGLE);
            Figure fig2 = new Figure(Figure.Shapes.SQUARE);
            Figure fig3 = new Figure(Figure.Shapes.CIRCLE);

            fig1.Label = "Test1";
            fig1.Color = "#111111";
            fig1.Coords = new Point(1, 2);
            fig1.Area = 10;

            fig2.Label = "Test2";
            fig2.Color = "#222222";
            fig2.Coords = new Point(3, 4);
            fig2.Area = 20;

            fig3.Label = "Test3";
            fig3.Color = "#333333";
            fig3.Coords = new Point(5, 6);
            fig3.Area = 30;

            figures.Add(fig1);
            figures.Add(fig2);
            figures.Add(fig3);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
