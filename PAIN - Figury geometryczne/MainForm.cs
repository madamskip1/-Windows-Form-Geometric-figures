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
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if form can be closed
        /// </summary>
        void closingChild(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length < 2)
                e.Cancel = true;
        }

        public void setItemsCounter(int count)
        {
            StatusBar_Items.Text = count.ToString();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainButtons_Add_Click(object sender, EventArgs e)
        {
            Add add = Add.Instance;
            add.MdiParent = this;
            add.FormClosing += closingChild;
            add.Show();
            add.Activate();
        }

        private void MainButtons_Modify_Click(object sender, EventArgs e)
        {
            Modify modify = Modify.Instance;
            modify.MdiParent = this;
            modify.FormClosing += closingChild;
            modify.Show();
            modify.Activate();
        }

        private void MainButtons_Delete_Click(object sender, EventArgs e)
        {
            Delete delete = Delete.Instance;
            delete.MdiParent = this;
            delete.FormClosing += closingChild; 
            delete.Show();
            delete.Activate();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainButtons_Add_Click(sender, e);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainButtons_Modify_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainButtons_Delete_Click(sender, e);
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

        private void MainButtons_List_Click(object sender, EventArgs e)
        {
            List list = List.Instance;
            list.MdiParent = this;
            list.FormClosing += closingChild;
            list.Show();
            list.Activate();
        }
    }
}
