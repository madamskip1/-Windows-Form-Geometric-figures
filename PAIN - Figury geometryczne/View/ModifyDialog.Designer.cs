namespace PAIN___Figury_geometryczne
{
    partial class ModifyDialog
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
            this.Modify_SearchLabel = new System.Windows.Forms.Label();
            this.Modify_NameInput = new System.Windows.Forms.TextBox();
            this.Modify_AreaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_AreaLabel = new System.Windows.Forms.Label();
            this.Modify_AreaInput = new System.Windows.Forms.TextBox();
            this.Modify_ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_UndoButton = new System.Windows.Forms.Button();
            this.Modify_ModifyButton = new System.Windows.Forms.Button();
            this.Modify_ColorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_ColorLabel = new System.Windows.Forms.Label();
            this.Modify_ColorInput = new System.Windows.Forms.TextBox();
            this.Modify_CoordsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_CoordsLabel = new System.Windows.Forms.Label();
            this.Modify_CoordsLayoutInput = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_CoordsYLabel = new System.Windows.Forms.Label();
            this.Modify_CoordsYInput = new System.Windows.Forms.TextBox();
            this.Modify_CoordsXInput = new System.Windows.Forms.TextBox();
            this.Modify_CoordsXLabel = new System.Windows.Forms.Label();
            this.Modify_SearchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Modify_Draw = new System.Windows.Forms.Panel();
            this.Modify_AreaLayout.SuspendLayout();
            this.Modify_ButtonsLayout.SuspendLayout();
            this.Modify_ColorLayout.SuspendLayout();
            this.Modify_CoordsLayout.SuspendLayout();
            this.Modify_CoordsLayoutInput.SuspendLayout();
            this.Modify_SearchLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Modify_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Modify_SearchLabel
            // 
            this.Modify_SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_SearchLabel.AutoSize = true;
            this.Modify_SearchLabel.Location = new System.Drawing.Point(10, 10);
            this.Modify_SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modify_SearchLabel.Name = "Modify_SearchLabel";
            this.Modify_SearchLabel.Size = new System.Drawing.Size(47, 17);
            this.Modify_SearchLabel.TabIndex = 0;
            this.Modify_SearchLabel.Text = "Label:";
            // 
            // Modify_NameInput
            // 
            this.Modify_NameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_NameInput.Location = new System.Drawing.Point(101, 7);
            this.Modify_NameInput.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_NameInput.Name = "Modify_NameInput";
            this.Modify_NameInput.Size = new System.Drawing.Size(132, 22);
            this.Modify_NameInput.TabIndex = 1;
            this.Modify_NameInput.Validating += new System.ComponentModel.CancelEventHandler(this.Modify_NameInput_Validating);
            this.Modify_NameInput.Validated += new System.EventHandler(this.Modify_NameInput_Validated);
            // 
            // Modify_AreaLayout
            // 
            this.Modify_AreaLayout.ColumnCount = 2;
            this.Modify_AreaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.Modify_AreaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Modify_AreaLayout.Controls.Add(this.Modify_AreaLabel, 0, 0);
            this.Modify_AreaLayout.Controls.Add(this.Modify_AreaInput, 1, 0);
            this.Modify_AreaLayout.Location = new System.Drawing.Point(26, 58);
            this.Modify_AreaLayout.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_AreaLayout.Name = "Modify_AreaLayout";
            this.Modify_AreaLayout.RowCount = 1;
            this.Modify_AreaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modify_AreaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.Modify_AreaLayout.Size = new System.Drawing.Size(267, 37);
            this.Modify_AreaLayout.TabIndex = 1;
            // 
            // Modify_AreaLabel
            // 
            this.Modify_AreaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_AreaLabel.AutoSize = true;
            this.Modify_AreaLabel.Location = new System.Drawing.Point(12, 10);
            this.Modify_AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modify_AreaLabel.Name = "Modify_AreaLabel";
            this.Modify_AreaLabel.Size = new System.Drawing.Size(42, 17);
            this.Modify_AreaLabel.TabIndex = 0;
            this.Modify_AreaLabel.Text = "Area:";
            // 
            // Modify_AreaInput
            // 
            this.Modify_AreaInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_AreaInput.Location = new System.Drawing.Point(101, 7);
            this.Modify_AreaInput.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_AreaInput.Name = "Modify_AreaInput";
            this.Modify_AreaInput.Size = new System.Drawing.Size(132, 22);
            this.Modify_AreaInput.TabIndex = 1;
            this.Modify_AreaInput.Validating += new System.ComponentModel.CancelEventHandler(this.Modify_AreaInput_Validating);
            this.Modify_AreaInput.Validated += new System.EventHandler(this.Modify_AreaInput_Validated);
            // 
            // Modify_ButtonsLayout
            // 
            this.Modify_ButtonsLayout.ColumnCount = 2;
            this.Modify_ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modify_ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modify_ButtonsLayout.Controls.Add(this.Modify_UndoButton, 1, 0);
            this.Modify_ButtonsLayout.Controls.Add(this.Modify_ModifyButton, 0, 0);
            this.Modify_ButtonsLayout.Location = new System.Drawing.Point(26, 277);
            this.Modify_ButtonsLayout.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_ButtonsLayout.Name = "Modify_ButtonsLayout";
            this.Modify_ButtonsLayout.RowCount = 1;
            this.Modify_ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modify_ButtonsLayout.Size = new System.Drawing.Size(267, 44);
            this.Modify_ButtonsLayout.TabIndex = 4;
            // 
            // Modify_UndoButton
            // 
            this.Modify_UndoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_UndoButton.Location = new System.Drawing.Point(150, 4);
            this.Modify_UndoButton.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_UndoButton.Name = "Modify_UndoButton";
            this.Modify_UndoButton.Size = new System.Drawing.Size(100, 36);
            this.Modify_UndoButton.TabIndex = 1;
            this.Modify_UndoButton.Text = "Undo";
            this.Modify_UndoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modify_UndoButton.UseVisualStyleBackColor = true;
            this.Modify_UndoButton.Click += new System.EventHandler(this.Modify_UndoButton_Click);
            // 
            // Modify_ModifyButton
            // 
            this.Modify_ModifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_ModifyButton.Location = new System.Drawing.Point(16, 4);
            this.Modify_ModifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_ModifyButton.Name = "Modify_ModifyButton";
            this.Modify_ModifyButton.Size = new System.Drawing.Size(100, 36);
            this.Modify_ModifyButton.TabIndex = 0;
            this.Modify_ModifyButton.Text = "Modify";
            this.Modify_ModifyButton.UseVisualStyleBackColor = true;
            this.Modify_ModifyButton.Click += new System.EventHandler(this.Modify_ModifyButton_Click);
            // 
            // Modify_ColorLayout
            // 
            this.Modify_ColorLayout.ColumnCount = 2;
            this.Modify_ColorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.Modify_ColorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modify_ColorLayout.Controls.Add(this.Modify_ColorLabel, 0, 0);
            this.Modify_ColorLayout.Controls.Add(this.Modify_ColorInput, 1, 0);
            this.Modify_ColorLayout.Location = new System.Drawing.Point(26, 103);
            this.Modify_ColorLayout.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_ColorLayout.Name = "Modify_ColorLayout";
            this.Modify_ColorLayout.RowCount = 1;
            this.Modify_ColorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modify_ColorLayout.Size = new System.Drawing.Size(267, 37);
            this.Modify_ColorLayout.TabIndex = 2;
            // 
            // Modify_ColorLabel
            // 
            this.Modify_ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_ColorLabel.AutoSize = true;
            this.Modify_ColorLabel.Location = new System.Drawing.Point(11, 10);
            this.Modify_ColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modify_ColorLabel.Name = "Modify_ColorLabel";
            this.Modify_ColorLabel.Size = new System.Drawing.Size(45, 17);
            this.Modify_ColorLabel.TabIndex = 0;
            this.Modify_ColorLabel.Text = "Color:";
            // 
            // Modify_ColorInput
            // 
            this.Modify_ColorInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_ColorInput.Location = new System.Drawing.Point(101, 7);
            this.Modify_ColorInput.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_ColorInput.Name = "Modify_ColorInput";
            this.Modify_ColorInput.Size = new System.Drawing.Size(132, 22);
            this.Modify_ColorInput.TabIndex = 1;
            this.Modify_ColorInput.TextChanged += new System.EventHandler(this.Modify_ColorInput_TextChanged);
            this.Modify_ColorInput.Validating += new System.ComponentModel.CancelEventHandler(this.Modify_ColorInput_Validating);
            this.Modify_ColorInput.Validated += new System.EventHandler(this.Modify_ColorInput_Validated);
            // 
            // Modify_CoordsLayout
            // 
            this.Modify_CoordsLayout.ColumnCount = 1;
            this.Modify_CoordsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.Modify_CoordsLayout.Controls.Add(this.Modify_CoordsLabel, 0, 0);
            this.Modify_CoordsLayout.Controls.Add(this.Modify_CoordsLayoutInput, 0, 1);
            this.Modify_CoordsLayout.Location = new System.Drawing.Point(26, 147);
            this.Modify_CoordsLayout.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_CoordsLayout.Name = "Modify_CoordsLayout";
            this.Modify_CoordsLayout.RowCount = 2;
            this.Modify_CoordsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.Modify_CoordsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modify_CoordsLayout.Size = new System.Drawing.Size(267, 123);
            this.Modify_CoordsLayout.TabIndex = 3;
            // 
            // Modify_CoordsLabel
            // 
            this.Modify_CoordsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_CoordsLabel.AutoSize = true;
            this.Modify_CoordsLabel.Location = new System.Drawing.Point(105, 10);
            this.Modify_CoordsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modify_CoordsLabel.Name = "Modify_CoordsLabel";
            this.Modify_CoordsLabel.Size = new System.Drawing.Size(57, 17);
            this.Modify_CoordsLabel.TabIndex = 1;
            this.Modify_CoordsLabel.Text = "Coords:";
            // 
            // Modify_CoordsLayoutInput
            // 
            this.Modify_CoordsLayoutInput.ColumnCount = 4;
            this.Modify_CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Modify_CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modify_CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Modify_CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Modify_CoordsLayoutInput.Controls.Add(this.Modify_CoordsYLabel, 2, 0);
            this.Modify_CoordsLayoutInput.Controls.Add(this.Modify_CoordsYInput, 3, 0);
            this.Modify_CoordsLayoutInput.Controls.Add(this.Modify_CoordsXInput, 1, 0);
            this.Modify_CoordsLayoutInput.Controls.Add(this.Modify_CoordsXLabel, 0, 0);
            this.Modify_CoordsLayoutInput.Location = new System.Drawing.Point(4, 41);
            this.Modify_CoordsLayoutInput.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_CoordsLayoutInput.Name = "Modify_CoordsLayoutInput";
            this.Modify_CoordsLayoutInput.RowCount = 1;
            this.Modify_CoordsLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modify_CoordsLayoutInput.Size = new System.Drawing.Size(259, 76);
            this.Modify_CoordsLayoutInput.TabIndex = 2;
            // 
            // Modify_CoordsYLabel
            // 
            this.Modify_CoordsYLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_CoordsYLabel.AutoSize = true;
            this.Modify_CoordsYLabel.Location = new System.Drawing.Point(135, 29);
            this.Modify_CoordsYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modify_CoordsYLabel.Name = "Modify_CoordsYLabel";
            this.Modify_CoordsYLabel.Size = new System.Drawing.Size(21, 17);
            this.Modify_CoordsYLabel.TabIndex = 3;
            this.Modify_CoordsYLabel.Text = "Y:";
            // 
            // Modify_CoordsYInput
            // 
            this.Modify_CoordsYInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_CoordsYInput.Location = new System.Drawing.Point(167, 27);
            this.Modify_CoordsYInput.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_CoordsYInput.Name = "Modify_CoordsYInput";
            this.Modify_CoordsYInput.Size = new System.Drawing.Size(87, 22);
            this.Modify_CoordsYInput.TabIndex = 1;
            this.Modify_CoordsYInput.Validating += new System.ComponentModel.CancelEventHandler(this.Modify_CoordsYInput_Validating);
            this.Modify_CoordsYInput.Validated += new System.EventHandler(this.Modify_CoordsYInput_Validated);
            // 
            // Modify_CoordsXInput
            // 
            this.Modify_CoordsXInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_CoordsXInput.Location = new System.Drawing.Point(37, 27);
            this.Modify_CoordsXInput.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_CoordsXInput.Name = "Modify_CoordsXInput";
            this.Modify_CoordsXInput.Size = new System.Drawing.Size(87, 22);
            this.Modify_CoordsXInput.TabIndex = 0;
            this.Modify_CoordsXInput.Validating += new System.ComponentModel.CancelEventHandler(this.Modify_CoordsXInput_Validating);
            this.Modify_CoordsXInput.Validated += new System.EventHandler(this.Modify_CoordsXInput_Validated);
            // 
            // Modify_CoordsXLabel
            // 
            this.Modify_CoordsXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modify_CoordsXLabel.AutoSize = true;
            this.Modify_CoordsXLabel.Location = new System.Drawing.Point(6, 29);
            this.Modify_CoordsXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modify_CoordsXLabel.Name = "Modify_CoordsXLabel";
            this.Modify_CoordsXLabel.Size = new System.Drawing.Size(21, 17);
            this.Modify_CoordsXLabel.TabIndex = 2;
            this.Modify_CoordsXLabel.Text = "X:";
            // 
            // Modify_SearchLayout
            // 
            this.Modify_SearchLayout.ColumnCount = 2;
            this.Modify_SearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.Modify_SearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Modify_SearchLayout.Controls.Add(this.Modify_SearchLabel, 0, 0);
            this.Modify_SearchLayout.Controls.Add(this.Modify_NameInput, 1, 0);
            this.Modify_SearchLayout.Location = new System.Drawing.Point(26, 13);
            this.Modify_SearchLayout.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_SearchLayout.Name = "Modify_SearchLayout";
            this.Modify_SearchLayout.RowCount = 1;
            this.Modify_SearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Modify_SearchLayout.Size = new System.Drawing.Size(267, 37);
            this.Modify_SearchLayout.TabIndex = 0;
            // 
            // Modify_ErrorProvider
            // 
            this.Modify_ErrorProvider.ContainerControl = this;
            // 
            // Modify_Draw
            // 
            this.Modify_Draw.Location = new System.Drawing.Point(359, 64);
            this.Modify_Draw.Name = "Modify_Draw";
            this.Modify_Draw.Size = new System.Drawing.Size(200, 200);
            this.Modify_Draw.TabIndex = 5;
            this.Modify_Draw.Click += new System.EventHandler(this.Modify_Draw_Click);
            this.Modify_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.Modify_Draw_Paint);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 330);
            this.Controls.Add(this.Modify_Draw);
            this.Controls.Add(this.Modify_SearchLayout);
            this.Controls.Add(this.Modify_AreaLayout);
            this.Controls.Add(this.Modify_ButtonsLayout);
            this.Controls.Add(this.Modify_ColorLayout);
            this.Controls.Add(this.Modify_CoordsLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modify";
            this.Text = "Modify";
            this.Modify_AreaLayout.ResumeLayout(false);
            this.Modify_AreaLayout.PerformLayout();
            this.Modify_ButtonsLayout.ResumeLayout(false);
            this.Modify_ColorLayout.ResumeLayout(false);
            this.Modify_ColorLayout.PerformLayout();
            this.Modify_CoordsLayout.ResumeLayout(false);
            this.Modify_CoordsLayout.PerformLayout();
            this.Modify_CoordsLayoutInput.ResumeLayout(false);
            this.Modify_CoordsLayoutInput.PerformLayout();
            this.Modify_SearchLayout.ResumeLayout(false);
            this.Modify_SearchLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Modify_ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Modify_SearchLabel;
        private System.Windows.Forms.TextBox Modify_NameInput;
        private System.Windows.Forms.TableLayoutPanel Modify_AreaLayout;
        private System.Windows.Forms.Label Modify_AreaLabel;
        private System.Windows.Forms.TextBox Modify_AreaInput;
        private System.Windows.Forms.TableLayoutPanel Modify_ButtonsLayout;
        private System.Windows.Forms.Button Modify_UndoButton;
        private System.Windows.Forms.Button Modify_ModifyButton;
        private System.Windows.Forms.TableLayoutPanel Modify_ColorLayout;
        private System.Windows.Forms.Label Modify_ColorLabel;
        private System.Windows.Forms.TextBox Modify_ColorInput;
        private System.Windows.Forms.TableLayoutPanel Modify_CoordsLayout;
        private System.Windows.Forms.Label Modify_CoordsLabel;
        private System.Windows.Forms.TableLayoutPanel Modify_CoordsLayoutInput;
        private System.Windows.Forms.Label Modify_CoordsYLabel;
        private System.Windows.Forms.TextBox Modify_CoordsYInput;
        private System.Windows.Forms.TextBox Modify_CoordsXInput;
        private System.Windows.Forms.Label Modify_CoordsXLabel;
        private System.Windows.Forms.TableLayoutPanel Modify_SearchLayout;
        private System.Windows.Forms.ErrorProvider Modify_ErrorProvider;
        private System.Windows.Forms.Panel Modify_Draw;
    }
}