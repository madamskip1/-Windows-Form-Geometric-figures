namespace PAIN___Figury_geometryczne
{
    partial class AddModifyDialog
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
            this.NameLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.AreaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AreaInput = new System.Windows.Forms.TextBox();
            this.Add_ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ColorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorInput = new System.Windows.Forms.TextBox();
            this.CoordsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CoordsLabel = new System.Windows.Forms.Label();
            this.CoordsLayoutInput = new System.Windows.Forms.TableLayoutPanel();
            this.CoordsYLabel = new System.Windows.Forms.Label();
            this.CoordsYInput = new System.Windows.Forms.TextBox();
            this.CoordsXInput = new System.Windows.Forms.TextBox();
            this.CoordsXLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DrawPanel = new PAIN___Figury_geometryczne.DrawFigure();
            this.NameLayout.SuspendLayout();
            this.AreaLayout.SuspendLayout();
            this.Add_ButtonsLayout.SuspendLayout();
            this.ColorLayout.SuspendLayout();
            this.CoordsLayout.SuspendLayout();
            this.CoordsLayoutInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLayout
            // 
            this.NameLayout.ColumnCount = 2;
            this.NameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.NameLayout.Controls.Add(this.NameLabel, 0, 0);
            this.NameLayout.Controls.Add(this.NameInput, 1, 0);
            this.NameLayout.Location = new System.Drawing.Point(12, 12);
            this.NameLayout.Name = "NameLayout";
            this.NameLayout.RowCount = 1;
            this.NameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NameLayout.Size = new System.Drawing.Size(200, 30);
            this.NameLayout.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(36, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Label:";
            // 
            // NameInput
            // 
            this.NameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameInput.Location = new System.Drawing.Point(75, 5);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 0;
            this.NameInput.Validating += new System.ComponentModel.CancelEventHandler(this.NameInput_Validated);
            this.NameInput.Validated += new System.EventHandler(this.NameInput_Validated);
            // 
            // AreaLayout
            // 
            this.AreaLayout.ColumnCount = 2;
            this.AreaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AreaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.AreaLayout.Controls.Add(this.AreaLabel, 0, 0);
            this.AreaLayout.Controls.Add(this.AreaInput, 1, 0);
            this.AreaLayout.Location = new System.Drawing.Point(12, 48);
            this.AreaLayout.Name = "AreaLayout";
            this.AreaLayout.RowCount = 1;
            this.AreaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AreaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.AreaLayout.Size = new System.Drawing.Size(200, 30);
            this.AreaLayout.TabIndex = 7;
            // 
            // AreaLabel
            // 
            this.AreaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(9, 8);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(32, 13);
            this.AreaLabel.TabIndex = 1;
            this.AreaLabel.Text = "Area:";
            // 
            // AreaInput
            // 
            this.AreaInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AreaInput.Location = new System.Drawing.Point(75, 5);
            this.AreaInput.Name = "AreaInput";
            this.AreaInput.Size = new System.Drawing.Size(100, 20);
            this.AreaInput.TabIndex = 0;
            this.AreaInput.Validating += new System.ComponentModel.CancelEventHandler(this.AreaInput_Validating);
            this.AreaInput.Validated += new System.EventHandler(this.AreaInput_Validated);
            // 
            // Add_ButtonsLayout
            // 
            this.Add_ButtonsLayout.ColumnCount = 2;
            this.Add_ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Add_ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Add_ButtonsLayout.Controls.Add(this.CancelButton, 1, 0);
            this.Add_ButtonsLayout.Controls.Add(this.OkButton, 0, 0);
            this.Add_ButtonsLayout.Location = new System.Drawing.Point(12, 226);
            this.Add_ButtonsLayout.Name = "Add_ButtonsLayout";
            this.Add_ButtonsLayout.RowCount = 1;
            this.Add_ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Add_ButtonsLayout.Size = new System.Drawing.Size(200, 36);
            this.Add_ButtonsLayout.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(112, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 29);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.Location = new System.Drawing.Point(12, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 29);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ColorLayout
            // 
            this.ColorLayout.ColumnCount = 2;
            this.ColorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ColorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColorLayout.Controls.Add(this.ColorLabel, 0, 0);
            this.ColorLayout.Controls.Add(this.ColorInput, 1, 0);
            this.ColorLayout.Location = new System.Drawing.Point(12, 84);
            this.ColorLayout.Name = "ColorLayout";
            this.ColorLayout.RowCount = 1;
            this.ColorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColorLayout.Size = new System.Drawing.Size(200, 30);
            this.ColorLayout.TabIndex = 8;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(8, 8);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorInput
            // 
            this.ColorInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorInput.Location = new System.Drawing.Point(75, 5);
            this.ColorInput.Name = "ColorInput";
            this.ColorInput.Size = new System.Drawing.Size(100, 20);
            this.ColorInput.TabIndex = 0;
            this.ColorInput.TextChanged += new System.EventHandler(this.ColorInput_TextChanged);
            this.ColorInput.Validating += new System.ComponentModel.CancelEventHandler(this.ColorInput_Validating);
            this.ColorInput.Validated += new System.EventHandler(this.ColorInput_Validated);
            // 
            // CoordsLayout
            // 
            this.CoordsLayout.ColumnCount = 1;
            this.CoordsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CoordsLayout.Controls.Add(this.CoordsLabel, 0, 0);
            this.CoordsLayout.Controls.Add(this.CoordsLayoutInput, 0, 1);
            this.CoordsLayout.Location = new System.Drawing.Point(12, 120);
            this.CoordsLayout.Name = "CoordsLayout";
            this.CoordsLayout.RowCount = 2;
            this.CoordsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CoordsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CoordsLayout.Size = new System.Drawing.Size(200, 100);
            this.CoordsLayout.TabIndex = 9;
            // 
            // CoordsLabel
            // 
            this.CoordsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoordsLabel.AutoSize = true;
            this.CoordsLabel.Location = new System.Drawing.Point(78, 8);
            this.CoordsLabel.Name = "CoordsLabel";
            this.CoordsLabel.Size = new System.Drawing.Size(43, 13);
            this.CoordsLabel.TabIndex = 1;
            this.CoordsLabel.Text = "Coords:";
            // 
            // CoordsLayoutInput
            // 
            this.CoordsLayoutInput.ColumnCount = 4;
            this.CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CoordsLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoordsLayoutInput.Controls.Add(this.CoordsYLabel, 2, 0);
            this.CoordsLayoutInput.Controls.Add(this.CoordsYInput, 3, 0);
            this.CoordsLayoutInput.Controls.Add(this.CoordsXInput, 1, 0);
            this.CoordsLayoutInput.Controls.Add(this.CoordsXLabel, 0, 0);
            this.CoordsLayoutInput.Location = new System.Drawing.Point(3, 33);
            this.CoordsLayoutInput.Name = "CoordsLayoutInput";
            this.CoordsLayoutInput.RowCount = 1;
            this.CoordsLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CoordsLayoutInput.Size = new System.Drawing.Size(194, 62);
            this.CoordsLayoutInput.TabIndex = 1;
            // 
            // CoordsYLabel
            // 
            this.CoordsYLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoordsYLabel.AutoSize = true;
            this.CoordsYLabel.Location = new System.Drawing.Point(101, 24);
            this.CoordsYLabel.Name = "CoordsYLabel";
            this.CoordsYLabel.Size = new System.Drawing.Size(17, 13);
            this.CoordsYLabel.TabIndex = 1;
            this.CoordsYLabel.Text = "Y:";
            // 
            // CoordsYInput
            // 
            this.CoordsYInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoordsYInput.Location = new System.Drawing.Point(125, 21);
            this.CoordsYInput.Name = "CoordsYInput";
            this.CoordsYInput.Size = new System.Drawing.Size(66, 20);
            this.CoordsYInput.TabIndex = 1;
            this.CoordsYInput.Validating += new System.ComponentModel.CancelEventHandler(this.CoordsYInput_Validating);
            this.CoordsYInput.Validated += new System.EventHandler(this.CoordsYInput_Validated);
            // 
            // CoordsXInput
            // 
            this.CoordsXInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoordsXInput.Location = new System.Drawing.Point(28, 21);
            this.CoordsXInput.Name = "CoordsXInput";
            this.CoordsXInput.Size = new System.Drawing.Size(66, 20);
            this.CoordsXInput.TabIndex = 0;
            this.CoordsXInput.Validating += new System.ComponentModel.CancelEventHandler(this.CoordsXInput_Validating);
            this.CoordsXInput.Validated += new System.EventHandler(this.CoordsXInput_Validated);
            // 
            // CoordsXLabel
            // 
            this.CoordsXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoordsXLabel.AutoSize = true;
            this.CoordsXLabel.Location = new System.Drawing.Point(4, 24);
            this.CoordsXLabel.Name = "CoordsXLabel";
            this.CoordsXLabel.Size = new System.Drawing.Size(17, 13);
            this.CoordsXLabel.TabIndex = 0;
            this.CoordsXLabel.Text = "X:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DrawPanel
            // 
            this.DrawPanel.Color = "#000000";
            this.DrawPanel.Location = new System.Drawing.Point(258, 48);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(1);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Shape = PAIN___Figury_geometryczne.Figure.Shapes.CIRCLE;
            this.DrawPanel.Size = new System.Drawing.Size(124, 142);
            this.DrawPanel.TabIndex = 11;
            // 
            // AddModifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 275);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.NameLayout);
            this.Controls.Add(this.AreaLayout);
            this.Controls.Add(this.Add_ButtonsLayout);
            this.Controls.Add(this.ColorLayout);
            this.Controls.Add(this.CoordsLayout);
            this.Name = "AddModifyDialog";
            this.Text = "AddModifyDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddModifyDialog_FormClosed);
            this.NameLayout.ResumeLayout(false);
            this.NameLayout.PerformLayout();
            this.AreaLayout.ResumeLayout(false);
            this.AreaLayout.PerformLayout();
            this.Add_ButtonsLayout.ResumeLayout(false);
            this.ColorLayout.ResumeLayout(false);
            this.ColorLayout.PerformLayout();
            this.CoordsLayout.ResumeLayout(false);
            this.CoordsLayout.PerformLayout();
            this.CoordsLayoutInput.ResumeLayout(false);
            this.CoordsLayoutInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DrawFigure DrawPanel;
        private System.Windows.Forms.TableLayoutPanel NameLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TableLayoutPanel AreaLayout;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox AreaInput;
        private System.Windows.Forms.TableLayoutPanel Add_ButtonsLayout;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TableLayoutPanel ColorLayout;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorInput;
        private System.Windows.Forms.TableLayoutPanel CoordsLayout;
        private System.Windows.Forms.Label CoordsLabel;
        private System.Windows.Forms.TableLayoutPanel CoordsLayoutInput;
        private System.Windows.Forms.Label CoordsYLabel;
        private System.Windows.Forms.TextBox CoordsYInput;
        private System.Windows.Forms.TextBox CoordsXInput;
        private System.Windows.Forms.Label CoordsXLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}