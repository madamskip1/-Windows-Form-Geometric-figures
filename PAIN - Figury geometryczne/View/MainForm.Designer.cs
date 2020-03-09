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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainForm_MenuBar = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainButtons_NewView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 695);
            this.panel1.TabIndex = 3;
            // 
            // MainButtons_NewView
            // 
            this.MainButtons_NewView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtons_NewView.Image = global::PAIN___Figury_geometryczne.Properties.Resources.show;
            this.MainButtons_NewView.Location = new System.Drawing.Point(23, 14);
            this.MainButtons_NewView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainButtons_NewView.Name = "MainButtons_NewView";
            this.MainButtons_NewView.Size = new System.Drawing.Size(200, 85);
            this.MainButtons_NewView.TabIndex = 3;
            this.MainButtons_NewView.TabStop = false;
            this.MainButtons_NewView.Text = "New View";
            this.MainButtons_NewView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainButtons_NewView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MainButtons_NewView.UseVisualStyleBackColor = true;
            this.MainButtons_NewView.Click += new System.EventHandler(this.MainButtons_New_View_Click);
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
            this.MainForm_StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.MainForm_StatusBar.Size = new System.Drawing.Size(936, 22);
            this.MainForm_StatusBar.TabIndex = 5;
            this.MainForm_StatusBar.Text = "statusStrip1";
            // 
            // MainForm_MenuBar
            // 
            this.MainForm_MenuBar.AutoSize = false;
            this.MainForm_MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainForm_MenuBar.Location = new System.Drawing.Point(240, 0);
            this.MainForm_MenuBar.Name = "MainForm_MenuBar";
            this.MainForm_MenuBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainForm_MenuBar.Size = new System.Drawing.Size(936, 60);
            this.MainForm_MenuBar.TabIndex = 7;
            this.MainForm_MenuBar.Text = "menuStrip1";
            this.MainForm_MenuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 695);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.MainForm_StatusBar);
            this.Controls.Add(this.MainForm_MenuBar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainForm_MenuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button MainButtons_NewView;
        private System.Windows.Forms.StatusStrip MainForm_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem newViewToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainForm_MenuBar;
    }
}

