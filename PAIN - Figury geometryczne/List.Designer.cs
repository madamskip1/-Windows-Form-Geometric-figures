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
            this.View_Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filtr_Button = new System.Windows.Forms.Button();
            this.Filtr_Greater = new System.Windows.Forms.RadioButton();
            this.Filtr_Less = new System.Windows.Forms.RadioButton();
            this.Filtr_All = new System.Windows.Forms.RadioButton();
            this.View_Shape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_List
            // 
            this.View_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.View_Name,
            this.View_Coords,
            this.View_Area,
            this.View_Color,
            this.View_Shape});
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
            // View_Area
            // 
            this.View_Area.DisplayIndex = 3;
            this.View_Area.Text = "Area";
            this.View_Area.Width = 70;
            // 
            // View_Color
            // 
            this.View_Color.DisplayIndex = 2;
            this.View_Color.Text = "Color";
            this.View_Color.Width = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Filtr_Button);
            this.panel1.Controls.Add(this.Filtr_Greater);
            this.panel1.Controls.Add(this.Filtr_Less);
            this.panel1.Controls.Add(this.Filtr_All);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 59);
            this.panel1.TabIndex = 1;
            // 
            // Filtr_Button
            // 
            this.Filtr_Button.Location = new System.Drawing.Point(222, 15);
            this.Filtr_Button.Name = "Filtr_Button";
            this.Filtr_Button.Size = new System.Drawing.Size(103, 23);
            this.Filtr_Button.TabIndex = 3;
            this.Filtr_Button.Text = "Filtr";
            this.Filtr_Button.UseVisualStyleBackColor = true;
            this.Filtr_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filtr_Greater
            // 
            this.Filtr_Greater.AutoSize = true;
            this.Filtr_Greater.Location = new System.Drawing.Point(136, 18);
            this.Filtr_Greater.Name = "Filtr_Greater";
            this.Filtr_Greater.Size = new System.Drawing.Size(80, 17);
            this.Filtr_Greater.TabIndex = 2;
            this.Filtr_Greater.TabStop = true;
            this.Filtr_Greater.Text = "Area >=100";
            this.Filtr_Greater.UseVisualStyleBackColor = true;
            // 
            // Filtr_Less
            // 
            this.Filtr_Less.AutoSize = true;
            this.Filtr_Less.Location = new System.Drawing.Point(56, 18);
            this.Filtr_Less.Name = "Filtr_Less";
            this.Filtr_Less.Size = new System.Drawing.Size(74, 17);
            this.Filtr_Less.TabIndex = 1;
            this.Filtr_Less.TabStop = true;
            this.Filtr_Less.Text = "Area <100";
            this.Filtr_Less.UseVisualStyleBackColor = true;
            this.Filtr_Less.CheckedChanged += new System.EventHandler(this.Filtr_Less_CheckedChanged);
            // 
            // Filtr_All
            // 
            this.Filtr_All.AutoSize = true;
            this.Filtr_All.Location = new System.Drawing.Point(14, 18);
            this.Filtr_All.Name = "Filtr_All";
            this.Filtr_All.Size = new System.Drawing.Size(36, 17);
            this.Filtr_All.TabIndex = 0;
            this.Filtr_All.TabStop = true;
            this.Filtr_All.Text = "All";
            this.Filtr_All.UseVisualStyleBackColor = true;
            // 
            // View_Shape
            // 
            this.View_Shape.Text = "Shape";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.View_List);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView View_List;
        private System.Windows.Forms.ColumnHeader View_Name;
        private System.Windows.Forms.ColumnHeader View_Coords;
        private System.Windows.Forms.ColumnHeader View_Area;
        private System.Windows.Forms.ColumnHeader View_Color;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Filtr_Greater;
        private System.Windows.Forms.RadioButton Filtr_Less;
        private System.Windows.Forms.RadioButton Filtr_All;
        private System.Windows.Forms.Button Filtr_Button;
        private System.Windows.Forms.ColumnHeader View_Shape;
    }
}