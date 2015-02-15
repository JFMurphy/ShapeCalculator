namespace ShapeCalculator
{
    partial class Form1
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
            this.panel_ShapeRadioButtons = new System.Windows.Forms.Panel();
            this.radioButton_Triangle = new System.Windows.Forms.RadioButton();
            this.radioButton_Circle = new System.Windows.Forms.RadioButton();
            this.radioButton_Square = new System.Windows.Forms.RadioButton();
            this.label_Shapes = new System.Windows.Forms.Label();
            this.panel_Shapes = new System.Windows.Forms.Panel();
            this.slider_Dimension = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Shape = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Square = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Decimal = new System.Windows.Forms.Panel();
            this.panel_DecimalRadioButtons = new System.Windows.Forms.Panel();
            this.radioButton_4Decimal = new System.Windows.Forms.RadioButton();
            this.radioButton_3Decimal = new System.Windows.Forms.RadioButton();
            this.radioButton_2Decimal = new System.Windows.Forms.RadioButton();
            this.Label_DecimalPlaces = new System.Windows.Forms.Label();
            this.label_MinValue = new System.Windows.Forms.Label();
            this.label_MaxValue = new System.Windows.Forms.Label();
            this.panel_DimensionSlider = new System.Windows.Forms.Panel();
            this.label_Boundary = new System.Windows.Forms.Label();
            this.label_Area = new System.Windows.Forms.Label();
            this.textBox_BoundaryResult = new System.Windows.Forms.TextBox();
            this.textBox_AreaResult = new System.Windows.Forms.TextBox();
            this.panel_Results = new System.Windows.Forms.Panel();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.panel_DrawingArea = new System.Windows.Forms.Panel();
            this.panel_ShapeRadioButtons.SuspendLayout();
            this.panel_Shapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Dimension)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel_Decimal.SuspendLayout();
            this.panel_DecimalRadioButtons.SuspendLayout();
            this.panel_DimensionSlider.SuspendLayout();
            this.panel_Results.SuspendLayout();
            this.panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ShapeRadioButtons
            // 
            this.panel_ShapeRadioButtons.BackColor = System.Drawing.Color.DarkGray;
            this.panel_ShapeRadioButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ShapeRadioButtons.Controls.Add(this.radioButton_Triangle);
            this.panel_ShapeRadioButtons.Controls.Add(this.radioButton_Circle);
            this.panel_ShapeRadioButtons.Controls.Add(this.radioButton_Square);
            this.panel_ShapeRadioButtons.Location = new System.Drawing.Point(3, 23);
            this.panel_ShapeRadioButtons.Name = "panel_ShapeRadioButtons";
            this.panel_ShapeRadioButtons.Size = new System.Drawing.Size(103, 158);
            this.panel_ShapeRadioButtons.TabIndex = 0;
            // 
            // radioButton_Triangle
            // 
            this.radioButton_Triangle.AutoSize = true;
            this.radioButton_Triangle.Location = new System.Drawing.Point(3, 131);
            this.radioButton_Triangle.Name = "radioButton_Triangle";
            this.radioButton_Triangle.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Triangle.TabIndex = 8;
            this.radioButton_Triangle.Text = "Triangle";
            this.radioButton_Triangle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Circle
            // 
            this.radioButton_Circle.AutoSize = true;
            this.radioButton_Circle.Location = new System.Drawing.Point(3, 66);
            this.radioButton_Circle.Name = "radioButton_Circle";
            this.radioButton_Circle.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Circle.TabIndex = 7;
            this.radioButton_Circle.Text = "Circle";
            this.radioButton_Circle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Square
            // 
            this.radioButton_Square.AutoSize = true;
            this.radioButton_Square.Checked = true;
            this.radioButton_Square.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Square.Name = "radioButton_Square";
            this.radioButton_Square.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Square.TabIndex = 6;
            this.radioButton_Square.TabStop = true;
            this.radioButton_Square.Text = "Square";
            this.radioButton_Square.UseVisualStyleBackColor = true;
            // 
            // label_Shapes
            // 
            this.label_Shapes.AutoSize = true;
            this.label_Shapes.Location = new System.Drawing.Point(3, 4);
            this.label_Shapes.Name = "label_Shapes";
            this.label_Shapes.Size = new System.Drawing.Size(38, 13);
            this.label_Shapes.TabIndex = 1;
            this.label_Shapes.Text = "Shape";
            // 
            // panel_Shapes
            // 
            this.panel_Shapes.Controls.Add(this.label_Shapes);
            this.panel_Shapes.Controls.Add(this.panel_ShapeRadioButtons);
            this.panel_Shapes.Location = new System.Drawing.Point(140, 3);
            this.panel_Shapes.Name = "panel_Shapes";
            this.panel_Shapes.Size = new System.Drawing.Size(109, 184);
            this.panel_Shapes.TabIndex = 2;
            // 
            // slider_Dimension
            // 
            this.slider_Dimension.Location = new System.Drawing.Point(7, 26);
            this.slider_Dimension.Maximum = 150;
            this.slider_Dimension.Minimum = 50;
            this.slider_Dimension.Name = "slider_Dimension";
            this.slider_Dimension.Size = new System.Drawing.Size(220, 45);
            this.slider_Dimension.TabIndex = 3;
            this.slider_Dimension.TickFrequency = 10;
            this.slider_Dimension.Value = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Shape,
            this.toolStripMenuItem_About,
            this.toolStripMenuItem_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Shape
            // 
            this.toolStripMenuItem_Shape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Square,
            this.toolStripMenuItem_Circle,
            this.toolStripMenuItem_Triangle});
            this.toolStripMenuItem_Shape.Name = "toolStripMenuItem_Shape";
            this.toolStripMenuItem_Shape.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem_Shape.Text = "Shape";
            // 
            // toolStripMenuItem_Square
            // 
            this.toolStripMenuItem_Square.Name = "toolStripMenuItem_Square";
            this.toolStripMenuItem_Square.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Square.Text = "Square";
            // 
            // toolStripMenuItem_Circle
            // 
            this.toolStripMenuItem_Circle.Name = "toolStripMenuItem_Circle";
            this.toolStripMenuItem_Circle.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Circle.Text = "Circle";
            // 
            // toolStripMenuItem_Triangle
            // 
            this.toolStripMenuItem_Triangle.Name = "toolStripMenuItem_Triangle";
            this.toolStripMenuItem_Triangle.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Triangle.Text = "Triangle";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem_About.Text = "About";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem_Exit.Text = "Exit";
            // 
            // panel_Decimal
            // 
            this.panel_Decimal.Controls.Add(this.panel_DecimalRadioButtons);
            this.panel_Decimal.Controls.Add(this.Label_DecimalPlaces);
            this.panel_Decimal.Location = new System.Drawing.Point(6, 3);
            this.panel_Decimal.Name = "panel_Decimal";
            this.panel_Decimal.Size = new System.Drawing.Size(109, 184);
            this.panel_Decimal.TabIndex = 5;
            // 
            // panel_DecimalRadioButtons
            // 
            this.panel_DecimalRadioButtons.BackColor = System.Drawing.Color.DarkGray;
            this.panel_DecimalRadioButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_DecimalRadioButtons.Controls.Add(this.radioButton_4Decimal);
            this.panel_DecimalRadioButtons.Controls.Add(this.radioButton_3Decimal);
            this.panel_DecimalRadioButtons.Controls.Add(this.radioButton_2Decimal);
            this.panel_DecimalRadioButtons.Location = new System.Drawing.Point(3, 23);
            this.panel_DecimalRadioButtons.Name = "panel_DecimalRadioButtons";
            this.panel_DecimalRadioButtons.Size = new System.Drawing.Size(103, 158);
            this.panel_DecimalRadioButtons.TabIndex = 1;
            // 
            // radioButton_4Decimal
            // 
            this.radioButton_4Decimal.AutoSize = true;
            this.radioButton_4Decimal.Location = new System.Drawing.Point(2, 131);
            this.radioButton_4Decimal.Name = "radioButton_4Decimal";
            this.radioButton_4Decimal.Size = new System.Drawing.Size(66, 17);
            this.radioButton_4Decimal.TabIndex = 2;
            this.radioButton_4Decimal.Text = "4 Places";
            this.radioButton_4Decimal.UseVisualStyleBackColor = true;
            // 
            // radioButton_3Decimal
            // 
            this.radioButton_3Decimal.AutoSize = true;
            this.radioButton_3Decimal.Location = new System.Drawing.Point(2, 66);
            this.radioButton_3Decimal.Name = "radioButton_3Decimal";
            this.radioButton_3Decimal.Size = new System.Drawing.Size(66, 17);
            this.radioButton_3Decimal.TabIndex = 1;
            this.radioButton_3Decimal.Text = "3 Places";
            this.radioButton_3Decimal.UseVisualStyleBackColor = true;
            // 
            // radioButton_2Decimal
            // 
            this.radioButton_2Decimal.AutoSize = true;
            this.radioButton_2Decimal.Checked = true;
            this.radioButton_2Decimal.Location = new System.Drawing.Point(2, 3);
            this.radioButton_2Decimal.Name = "radioButton_2Decimal";
            this.radioButton_2Decimal.Size = new System.Drawing.Size(66, 17);
            this.radioButton_2Decimal.TabIndex = 0;
            this.radioButton_2Decimal.TabStop = true;
            this.radioButton_2Decimal.Text = "2 Places";
            this.radioButton_2Decimal.UseVisualStyleBackColor = true;
            // 
            // Label_DecimalPlaces
            // 
            this.Label_DecimalPlaces.AutoSize = true;
            this.Label_DecimalPlaces.Location = new System.Drawing.Point(4, 4);
            this.Label_DecimalPlaces.Name = "Label_DecimalPlaces";
            this.Label_DecimalPlaces.Size = new System.Drawing.Size(45, 13);
            this.Label_DecimalPlaces.TabIndex = 0;
            this.Label_DecimalPlaces.Text = "Decimal";
            // 
            // label_MinValue
            // 
            this.label_MinValue.AutoSize = true;
            this.label_MinValue.Location = new System.Drawing.Point(4, 10);
            this.label_MinValue.Name = "label_MinValue";
            this.label_MinValue.Size = new System.Drawing.Size(48, 13);
            this.label_MinValue.TabIndex = 6;
            this.label_MinValue.Text = "Min = 50";
            // 
            // label_MaxValue
            // 
            this.label_MaxValue.AutoSize = true;
            this.label_MaxValue.Location = new System.Drawing.Point(170, 10);
            this.label_MaxValue.Name = "label_MaxValue";
            this.label_MaxValue.Size = new System.Drawing.Size(57, 13);
            this.label_MaxValue.TabIndex = 7;
            this.label_MaxValue.Text = "Max = 150";
            // 
            // panel_DimensionSlider
            // 
            this.panel_DimensionSlider.Controls.Add(this.label_MaxValue);
            this.panel_DimensionSlider.Controls.Add(this.slider_Dimension);
            this.panel_DimensionSlider.Controls.Add(this.label_MinValue);
            this.panel_DimensionSlider.Location = new System.Drawing.Point(6, 193);
            this.panel_DimensionSlider.Name = "panel_DimensionSlider";
            this.panel_DimensionSlider.Size = new System.Drawing.Size(236, 82);
            this.panel_DimensionSlider.TabIndex = 8;
            // 
            // label_Boundary
            // 
            this.label_Boundary.AutoSize = true;
            this.label_Boundary.Location = new System.Drawing.Point(3, 0);
            this.label_Boundary.Name = "label_Boundary";
            this.label_Boundary.Size = new System.Drawing.Size(88, 13);
            this.label_Boundary.TabIndex = 9;
            this.label_Boundary.Text = "Boundary Length";
            // 
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.Location = new System.Drawing.Point(137, 0);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(29, 13);
            this.label_Area.TabIndex = 10;
            this.label_Area.Text = "Area";
            // 
            // textBox_BoundaryResult
            // 
            this.textBox_BoundaryResult.Location = new System.Drawing.Point(6, 17);
            this.textBox_BoundaryResult.Name = "textBox_BoundaryResult";
            this.textBox_BoundaryResult.ReadOnly = true;
            this.textBox_BoundaryResult.Size = new System.Drawing.Size(100, 20);
            this.textBox_BoundaryResult.TabIndex = 11;
            // 
            // textBox_AreaResult
            // 
            this.textBox_AreaResult.Location = new System.Drawing.Point(140, 16);
            this.textBox_AreaResult.Name = "textBox_AreaResult";
            this.textBox_AreaResult.ReadOnly = true;
            this.textBox_AreaResult.Size = new System.Drawing.Size(100, 20);
            this.textBox_AreaResult.TabIndex = 12;
            // 
            // panel_Results
            // 
            this.panel_Results.Controls.Add(this.label_Area);
            this.panel_Results.Controls.Add(this.textBox_AreaResult);
            this.panel_Results.Controls.Add(this.label_Boundary);
            this.panel_Results.Controls.Add(this.textBox_BoundaryResult);
            this.panel_Results.Location = new System.Drawing.Point(6, 281);
            this.panel_Results.Name = "panel_Results";
            this.panel_Results.Size = new System.Drawing.Size(243, 45);
            this.panel_Results.TabIndex = 13;
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.panel_Shapes);
            this.panel_Control.Controls.Add(this.panel_Results);
            this.panel_Control.Controls.Add(this.panel_Decimal);
            this.panel_Control.Controls.Add(this.panel_DimensionSlider);
            this.panel_Control.Location = new System.Drawing.Point(465, 27);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(253, 334);
            this.panel_Control.TabIndex = 14;
            // 
            // panel_DrawingArea
            // 
            this.panel_DrawingArea.Location = new System.Drawing.Point(12, 27);
            this.panel_DrawingArea.Name = "panel_DrawingArea";
            this.panel_DrawingArea.Size = new System.Drawing.Size(447, 334);
            this.panel_DrawingArea.TabIndex = 15;
            this.panel_DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DrawingArea_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 373);
            this.Controls.Add(this.panel_DrawingArea);
            this.Controls.Add(this.panel_Control);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shape Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_ShapeRadioButtons.ResumeLayout(false);
            this.panel_ShapeRadioButtons.PerformLayout();
            this.panel_Shapes.ResumeLayout(false);
            this.panel_Shapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Dimension)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Decimal.ResumeLayout(false);
            this.panel_Decimal.PerformLayout();
            this.panel_DecimalRadioButtons.ResumeLayout(false);
            this.panel_DecimalRadioButtons.PerformLayout();
            this.panel_DimensionSlider.ResumeLayout(false);
            this.panel_DimensionSlider.PerformLayout();
            this.panel_Results.ResumeLayout(false);
            this.panel_Results.PerformLayout();
            this.panel_Control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ShapeRadioButtons;
        private System.Windows.Forms.RadioButton radioButton_Triangle;
        private System.Windows.Forms.RadioButton radioButton_Circle;
        private System.Windows.Forms.RadioButton radioButton_Square;
        private System.Windows.Forms.Label label_Shapes;
        private System.Windows.Forms.Panel panel_Shapes;
        private System.Windows.Forms.TrackBar slider_Dimension;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Shape;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Square;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Circle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Triangle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.Panel panel_Decimal;
        private System.Windows.Forms.Panel panel_DecimalRadioButtons;
        private System.Windows.Forms.RadioButton radioButton_4Decimal;
        private System.Windows.Forms.RadioButton radioButton_3Decimal;
        private System.Windows.Forms.RadioButton radioButton_2Decimal;
        private System.Windows.Forms.Label Label_DecimalPlaces;
        private System.Windows.Forms.Label label_MinValue;
        private System.Windows.Forms.Label label_MaxValue;
        private System.Windows.Forms.Panel panel_DimensionSlider;
        private System.Windows.Forms.Label label_Boundary;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.TextBox textBox_BoundaryResult;
        private System.Windows.Forms.TextBox textBox_AreaResult;
        private System.Windows.Forms.Panel panel_Results;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_DrawingArea;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;


    }
}

