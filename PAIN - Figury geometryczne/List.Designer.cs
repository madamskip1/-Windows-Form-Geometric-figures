namespace PAIN___Figury_geometryczne
{
    partial class List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.View_List = new System.Windows.Forms.ListView();
            this.View_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Coords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // View_List
            // 
            this.View_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.View_Name,
            this.View_Coords,
            this.View_Area,
            this.View_Color});
            this.View_List.HideSelection = false;
            this.View_List.Location = new System.Drawing.Point(30, 99);
            this.View_List.Name = "View_List";
            this.View_List.Size = new System.Drawing.Size(344, 220);
            this.View_List.TabIndex = 0;
            this.View_List.UseCompatibleStateImageBehavior = false;
            this.View_List.View = System.Windows.Forms.View.Details;
            // 
            // View_Name
            // 
            this.View_Name.Text = "Label";
            this.View_Name.Width = 70;
            // 
            // View_Coords
            // 
            this.View_Coords.Text = "Coords";
            this.View_Coords.Width = 70;
            // 
            // View_Color
            // 
            this.View_Color.DisplayIndex = 2;
            this.View_Color.Text = "Color";
            this.View_Color.Width = 70;
            // 
            // View_Area
            // 
            this.View_Area.DisplayIndex = 3;
            this.View_Area.Text = "Area";
            this.View_Area.Width = 70;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 400);
            this.Controls.Add(this.View_List);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView View_List;
        private System.Windows.Forms.ColumnHeader View_Name;
        private System.Windows.Forms.ColumnHeader View_Coords;
        private System.Windows.Forms.ColumnHeader View_Area;
        private System.Windows.Forms.ColumnHeader View_Color;
    }
}