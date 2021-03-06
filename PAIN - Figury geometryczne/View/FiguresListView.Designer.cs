﻿namespace PAIN___Figury_geometryczne
{
    partial class FiguresListView
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
            this.components = new System.ComponentModel.Container();
            this.View_List = new System.Windows.Forms.ListView();
            this.View_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Coords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.View_Shape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar_Items = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.View_AddButton = new System.Windows.Forms.ToolStripMenuItem();
            this.View_ModifyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.View_DeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBox_Filtr = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.View_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View_List.FullRowSelect = true;
            this.View_List.HideSelection = false;
            this.View_List.Location = new System.Drawing.Point(0, 0);
            this.View_List.MultiSelect = false;
            this.View_List.Name = "View_List";
            this.View_List.Size = new System.Drawing.Size(408, 323);
            this.View_List.TabIndex = 0;
            this.View_List.UseCompatibleStateImageBehavior = false;
            this.View_List.View = System.Windows.Forms.View.Details;
            this.View_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.View_List_MouseClick);
            // 
            // View_Name
            // 
            this.View_Name.Text = "Label";
            this.View_Name.Width = 80;
            // 
            // View_Coords
            // 
            this.View_Coords.Text = "Coords";
            this.View_Coords.Width = 80;
            // 
            // View_Area
            // 
            this.View_Area.DisplayIndex = 3;
            this.View_Area.Text = "Area";
            this.View_Area.Width = 80;
            // 
            // View_Color
            // 
            this.View_Color.DisplayIndex = 2;
            this.View_Color.Text = "Color";
            this.View_Color.Width = 80;
            // 
            // View_Shape
            // 
            this.View_Shape.Text = "Shape";
            this.View_Shape.Width = 80;
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusBar_Items});
            this.StatusBar.Location = new System.Drawing.Point(0, 513);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusBar.Size = new System.Drawing.Size(669, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            this.StatusBar.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Items:";
            // 
            // StatusBar_Items
            // 
            this.StatusBar_Items.Name = "StatusBar_Items";
            this.StatusBar_Items.Size = new System.Drawing.Size(13, 17);
            this.StatusBar_Items.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_AddButton,
            this.View_ModifyButton,
            this.View_DeleteButton,
            this.ComboBox_Filtr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(408, 49);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // View_AddButton
            // 
            this.View_AddButton.Image = global::PAIN___Figury_geometryczne.Properties.Resources.plus;
            this.View_AddButton.Name = "View_AddButton";
            this.View_AddButton.Size = new System.Drawing.Size(41, 45);
            this.View_AddButton.Text = "Add";
            this.View_AddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.View_AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.View_AddButton.Click += new System.EventHandler(this.View_AddButton_Click);
            // 
            // View_ModifyButton
            // 
            this.View_ModifyButton.Image = global::PAIN___Figury_geometryczne.Properties.Resources.edit;
            this.View_ModifyButton.Name = "View_ModifyButton";
            this.View_ModifyButton.Size = new System.Drawing.Size(57, 45);
            this.View_ModifyButton.Text = "Modify";
            this.View_ModifyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.View_ModifyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.View_ModifyButton.Click += new System.EventHandler(this.View_ModifyButton_Click);
            // 
            // View_DeleteButton
            // 
            this.View_DeleteButton.Image = global::PAIN___Figury_geometryczne.Properties.Resources.delete;
            this.View_DeleteButton.Name = "View_DeleteButton";
            this.View_DeleteButton.Size = new System.Drawing.Size(52, 45);
            this.View_DeleteButton.Text = "Delete";
            this.View_DeleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.View_DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.View_DeleteButton.Click += new System.EventHandler(this.View_DeleteButton_Click);
            // 
            // ComboBox_Filtr
            // 
            this.ComboBox_Filtr.Items.AddRange(new object[] {
            "All",
            "Area < 100",
            "Area >= 100"});
            this.ComboBox_Filtr.Name = "ComboBox_Filtr";
            this.ComboBox_Filtr.Size = new System.Drawing.Size(121, 45);
            this.ComboBox_Filtr.DropDownClosed += new System.EventHandler(this.ComboBox_Filtr_DropDownClosed);
            this.ComboBox_Filtr.TextChanged += new System.EventHandler(this.ComboBox_Filtr_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
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
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FiguresListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 323);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.View_List);
            this.Name = "FiguresListView";
            this.Text = "List";
            this.Activated += new System.EventHandler(this.FiguresListView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiguresListView_FormClosing);
            this.Load += new System.EventHandler(this.FiguresListView_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader View_Name;
        private System.Windows.Forms.ColumnHeader View_Coords;
        private System.Windows.Forms.ColumnHeader View_Area;
        private System.Windows.Forms.ColumnHeader View_Color;
        private System.Windows.Forms.ColumnHeader View_Shape;
        private System.Windows.Forms.ListView View_List;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_Items;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem View_AddButton;
        private System.Windows.Forms.ToolStripMenuItem View_ModifyButton;
        private System.Windows.Forms.ToolStripMenuItem View_DeleteButton;
        private System.Windows.Forms.ToolStripComboBox ComboBox_Filtr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}