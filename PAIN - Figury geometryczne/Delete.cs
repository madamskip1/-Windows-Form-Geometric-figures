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
    public partial class Delete : Form
    {
        public event EventHandler<FigureEventArgs> FigureDeleted;

        private static Delete _instance;
        private Figure last;

        public static Delete Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Delete();
                    _instance.InitializeEvents();
                }


                return _instance;
            }
        }

        public Delete()
        {
            InitializeComponent();
        }

        private void InitializeEvents()
        {
            Modify.Instance.ModifyEvent += ModifiedEv;
        }


        private void ModifiedEv(object sender, EventArgs e)
        {
            prepare(last.Label);
        }


        private void clearAll()
        {
            last = null;
            Delete_CoordsXInput.Text = "";
            Delete_CoordsYInput.Text = "";
            Delete_AreaInput.Text = "";
            Delete_ColorInput.Text = "";
        }

        private void prepare(string name)
        {
            Figure fig = FiguresList.Instance.byName(name);

            clearAll();

            if (fig == null)
                return;

            last = fig;

            int x = fig.Coords.X;
            int y = fig.Coords.Y;
            int area = fig.Area;
            string label = fig.Label;
            string color = fig.Color;

            Delete_CoordsXInput.Text = x.ToString();
            Delete_CoordsYInput.Text = y.ToString();
            Delete_AreaInput.Text = area.ToString();
            Delete_ColorInput.Text = color;
        }


        private void Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }


        private void Delete_SearchButton_Click(object sender, EventArgs e)
        {
            string name = Delete_SearchInput.Text;
            prepare(name);
        }

        private void Delete_ModifyButton_Click(object sender, EventArgs e)
        {
            if (last == null)
                return;

            FiguresList.Instance.delete(last);
            
            if (FigureDeleted != null)
                FigureDeleted(this, new FigureEventArgs(last));

            clearAll();
            Delete_SearchInput.Text = "";
        }

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
