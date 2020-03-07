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

        public event EventHandler DeleteClicked;
        public event EventHandler ModifyClicked;

        public MainForm()
        {
            InitializeComponent();
            InitalizeEvents();
        }


        private void InitalizeEvents()
        {

        }


        /// <summary>
        /// Check if form can be closed
        /// </summary>
        void closingChild(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length < 2)
                e.Cancel = true;
        }


        private void MainButtons_Add_Click(object sender, EventArgs e)
        {
            Add add = Add.Instance;
            add.ShowDialog();
        }

        private void MainButtons_Modify_Click(object sender, EventArgs e)
        {
            if (ModifyClicked != null)
                ModifyClicked(this, null);
        }

        private void MainButtons_Delete_Click(object sender, EventArgs e)
        {
            if (DeleteClicked != null)
                DeleteClicked(this, null);

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainButtons_Add_Click(sender, e);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainButtons_Delete_Click(sender, e);
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainButtons_Modify_Click(sender, e);
        }

        private void MainButtons_New_View_Click(object sender, EventArgs e)
        {
            List list = new List(ref DeleteClicked, ref ModifyClicked);
            list.MdiParent = this;
            list.FormClosing += closingChild;
            list.Show();
            list.Activate();
        }

        private void newViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainButtons_New_View_Click(sender, e);
        }

        private void newViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainButtons_New_View_Click(sender, e);
        }
    }
}
