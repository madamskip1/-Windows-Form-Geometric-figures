namespace PAIN___Figury_geometryczne
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formularzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainButtons_List = new System.Windows.Forms.Button();
            this.MainButtons_Delete = new System.Windows.Forms.Button();
            this.MainButtons_Modify = new System.Windows.Forms.Button();
            this.MainButtons_Add = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar_Items = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formularzeToolStripMenuItem
            // 
            this.formularzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.formularzeToolStripMenuItem.Name = "formularzeToolStripMenuItem";
            this.formularzeToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.formularzeToolStripMenuItem.Text = "Forms";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainButtons_List);
            this.panel1.Controls.Add(this.MainButtons_Delete);
            this.panel1.Controls.Add(this.MainButtons_Modify);
            this.panel1.Controls.Add(this.MainButtons_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 541);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainButtons_List
            // 
            this.MainButtons_List.Location = new System.Drawing.Point(12, 182);
            this.MainButtons_List.Name = "MainButtons_List";
            this.MainButtons_List.Size = new System.Drawing.Size(150, 50);
            this.MainButtons_List.TabIndex = 3;
            this.MainButtons_List.TabStop = false;
            this.MainButtons_List.Text = "List";
            this.MainButtons_List.UseVisualStyleBackColor = true;
            this.MainButtons_List.Click += new System.EventHandler(this.MainButtons_List_Click);
            // 
            // MainButtons_Delete
            // 
            this.MainButtons_Delete.Location = new System.Drawing.Point(12, 126);
            this.MainButtons_Delete.Name = "MainButtons_Delete";
            this.MainButtons_Delete.Size = new System.Drawing.Size(150, 50);
            this.MainButtons_Delete.TabIndex = 2;
            this.MainButtons_Delete.TabStop = false;
            this.MainButtons_Delete.Text = "Delete";
            this.MainButtons_Delete.UseVisualStyleBackColor = true;
            this.MainButtons_Delete.Click += new System.EventHandler(this.MainButtons_Delete_Click);
            // 
            // MainButtons_Modify
            // 
            this.MainButtons_Modify.Location = new System.Drawing.Point(12, 70);
            this.MainButtons_Modify.Name = "MainButtons_Modify";
            this.MainButtons_Modify.Size = new System.Drawing.Size(150, 50);
            this.MainButtons_Modify.TabIndex = 1;
            this.MainButtons_Modify.TabStop = false;
            this.MainButtons_Modify.Text = "Modify";
            this.MainButtons_Modify.UseVisualStyleBackColor = true;
            this.MainButtons_Modify.Click += new System.EventHandler(this.MainButtons_Modify_Click);
            // 
            // MainButtons_Add
            // 
            this.MainButtons_Add.Location = new System.Drawing.Point(12, 14);
            this.MainButtons_Add.Name = "MainButtons_Add";
            this.MainButtons_Add.Size = new System.Drawing.Size(150, 50);
            this.MainButtons_Add.TabIndex = 0;
            this.MainButtons_Add.TabStop = false;
            this.MainButtons_Add.Text = "Add";
            this.MainButtons_Add.UseVisualStyleBackColor = true;
            this.MainButtons_Add.Click += new System.EventHandler(this.MainButtons_Add_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar_Items,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(180, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar_Items
            // 
            this.StatusBar_Items.Name = "StatusBar_Items";
            this.StatusBar_Items.Size = new System.Drawing.Size(13, 17);
            this.StatusBar_Items.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = ":Items";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.modifyToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.modifyToolStripMenuItem1.Text = "Modify";
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularzeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainButtons_Add;
        private System.Windows.Forms.Button MainButtons_Modify;
        private System.Windows.Forms.Button MainButtons_Delete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_Items;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button MainButtons_List;
    }
}

