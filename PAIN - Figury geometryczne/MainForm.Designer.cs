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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainButtons_NewView = new System.Windows.Forms.Button();
            this.MainButtons_Delete = new System.Windows.Forms.Button();
            this.MainButtons_Modify = new System.Windows.Forms.Button();
            this.MainButtons_Add = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_StatusBar = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainButtons_NewView);
            this.panel1.Controls.Add(this.MainButtons_Delete);
            this.panel1.Controls.Add(this.MainButtons_Modify);
            this.panel1.Controls.Add(this.MainButtons_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 695);
            this.panel1.TabIndex = 3;
            // 
            // MainButtons_NewView
            // 
            this.MainButtons_NewView.Location = new System.Drawing.Point(23, 13);
            this.MainButtons_NewView.Margin = new System.Windows.Forms.Padding(4);
            this.MainButtons_NewView.Name = "MainButtons_NewView";
            this.MainButtons_NewView.Size = new System.Drawing.Size(200, 62);
            this.MainButtons_NewView.TabIndex = 3;
            this.MainButtons_NewView.TabStop = false;
            this.MainButtons_NewView.Text = "New View";
            this.MainButtons_NewView.UseVisualStyleBackColor = true;
            this.MainButtons_NewView.Click += new System.EventHandler(this.MainButtons_New_View_Click);
            // 
            // MainButtons_Delete
            // 
            this.MainButtons_Delete.Location = new System.Drawing.Point(23, 342);
            this.MainButtons_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.MainButtons_Delete.Name = "MainButtons_Delete";
            this.MainButtons_Delete.Size = new System.Drawing.Size(200, 62);
            this.MainButtons_Delete.TabIndex = 2;
            this.MainButtons_Delete.TabStop = false;
            this.MainButtons_Delete.Text = "Delete";
            this.MainButtons_Delete.UseVisualStyleBackColor = true;
            this.MainButtons_Delete.Click += new System.EventHandler(this.MainButtons_Delete_Click);
            // 
            // MainButtons_Modify
            // 
            this.MainButtons_Modify.Location = new System.Drawing.Point(23, 273);
            this.MainButtons_Modify.Margin = new System.Windows.Forms.Padding(4);
            this.MainButtons_Modify.Name = "MainButtons_Modify";
            this.MainButtons_Modify.Size = new System.Drawing.Size(200, 62);
            this.MainButtons_Modify.TabIndex = 1;
            this.MainButtons_Modify.TabStop = false;
            this.MainButtons_Modify.Text = "Modify";
            this.MainButtons_Modify.UseVisualStyleBackColor = true;
            this.MainButtons_Modify.Click += new System.EventHandler(this.MainButtons_Modify_Click);
            // 
            // MainButtons_Add
            // 
            this.MainButtons_Add.Location = new System.Drawing.Point(23, 204);
            this.MainButtons_Add.Margin = new System.Windows.Forms.Padding(4);
            this.MainButtons_Add.Name = "MainButtons_Add";
            this.MainButtons_Add.Size = new System.Drawing.Size(200, 62);
            this.MainButtons_Add.TabIndex = 0;
            this.MainButtons_Add.TabStop = false;
            this.MainButtons_Add.Text = "Add";
            this.MainButtons_Add.UseVisualStyleBackColor = true;
            this.MainButtons_Add.Click += new System.EventHandler(this.MainButtons_Add_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newViewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 28);
            // 
            // newViewToolStripMenuItem
            // 
            this.newViewToolStripMenuItem.Name = "newViewToolStripMenuItem";
            this.newViewToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.newViewToolStripMenuItem.Text = "New View";
            this.newViewToolStripMenuItem.Click += new System.EventHandler(this.newViewToolStripMenuItem_Click);
            // 
            // MainForm_StatusBar
            // 
            this.MainForm_StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainForm_StatusBar.Location = new System.Drawing.Point(240, 673);
            this.MainForm_StatusBar.Name = "MainForm_StatusBar";
            this.MainForm_StatusBar.Size = new System.Drawing.Size(936, 22);
            this.MainForm_StatusBar.TabIndex = 5;
            this.MainForm_StatusBar.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newViewToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(240, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newViewToolStripMenuItem1
            // 
            this.newViewToolStripMenuItem1.Name = "newViewToolStripMenuItem1";
            this.newViewToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.newViewToolStripMenuItem1.Text = "New View";
            this.newViewToolStripMenuItem1.Click += new System.EventHandler(this.newViewToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 695);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.MainForm_StatusBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainButtons_Add;
        private System.Windows.Forms.Button MainButtons_Modify;
        private System.Windows.Forms.Button MainButtons_Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button MainButtons_NewView;
        private System.Windows.Forms.StatusStrip MainForm_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem newViewToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newViewToolStripMenuItem1;
    }
}

