﻿namespace ShapeCalculator
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
            this.panelShapeRadioButtons = new System.Windows.Forms.Panel();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.labelShapes = new System.Windows.Forms.Label();
            this.panelShapes = new System.Windows.Forms.Panel();
            this.sliderDimension = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemShape = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDecimal = new System.Windows.Forms.Panel();
            this.panelDecimalRadioButtons = new System.Windows.Forms.Panel();
            this.radioButton4Decimal = new System.Windows.Forms.RadioButton();
            this.radioButton3Decimal = new System.Windows.Forms.RadioButton();
            this.radioButton2Decimal = new System.Windows.Forms.RadioButton();
            this.LabelDecimalPlaces = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.panelDimensionSlider = new System.Windows.Forms.Panel();
            this.labelBoundary = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxBoundaryResult = new System.Windows.Forms.TextBox();
            this.textBoxAreaResult = new System.Windows.Forms.TextBox();
            this.panelResults = new System.Windows.Forms.Panel();
            this.panelControlArea = new System.Windows.Forms.Panel();
            this.panelDrawingArea = new System.Windows.Forms.Panel();
            this.panelShapeRadioButtons.SuspendLayout();
            this.panelShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDimension)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelDecimal.SuspendLayout();
            this.panelDecimalRadioButtons.SuspendLayout();
            this.panelDimensionSlider.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelControlArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShapeRadioButtons
            // 
            this.panelShapeRadioButtons.BackColor = System.Drawing.Color.DarkGray;
            this.panelShapeRadioButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShapeRadioButtons.Controls.Add(this.radioButtonTriangle);
            this.panelShapeRadioButtons.Controls.Add(this.radioButtonCircle);
            this.panelShapeRadioButtons.Controls.Add(this.radioButtonSquare);
            this.panelShapeRadioButtons.Location = new System.Drawing.Point(3, 23);
            this.panelShapeRadioButtons.Name = "panelShapeRadioButtons";
            this.panelShapeRadioButtons.Size = new System.Drawing.Size(103, 158);
            this.panelShapeRadioButtons.TabIndex = 0;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(3, 131);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(63, 17);
            this.radioButtonTriangle.TabIndex = 8;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            this.radioButtonTriangle.CheckedChanged += new System.EventHandler(this.radioButtonTriangle_CheckedChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(3, 66);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 7;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Checked = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSquare.TabIndex = 6;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            this.radioButtonSquare.CheckedChanged += new System.EventHandler(this.radioButtonSquare_CheckedChanged);
            this.radioButtonSquare.Enter += new System.EventHandler(this.radioButtonSquare_Enter);
            // 
            // labelShapes
            // 
            this.labelShapes.AutoSize = true;
            this.labelShapes.Location = new System.Drawing.Point(3, 4);
            this.labelShapes.Name = "labelShapes";
            this.labelShapes.Size = new System.Drawing.Size(38, 13);
            this.labelShapes.TabIndex = 1;
            this.labelShapes.Text = "Shape";
            // 
            // panelShapes
            // 
            this.panelShapes.Controls.Add(this.labelShapes);
            this.panelShapes.Controls.Add(this.panelShapeRadioButtons);
            this.panelShapes.Location = new System.Drawing.Point(140, 3);
            this.panelShapes.Name = "panelShapes";
            this.panelShapes.Size = new System.Drawing.Size(109, 184);
            this.panelShapes.TabIndex = 2;
            // 
            // sliderDimension
            // 
            this.sliderDimension.Location = new System.Drawing.Point(7, 26);
            this.sliderDimension.Maximum = 150;
            this.sliderDimension.Minimum = 50;
            this.sliderDimension.Name = "sliderDimension";
            this.sliderDimension.Size = new System.Drawing.Size(220, 45);
            this.sliderDimension.TabIndex = 3;
            this.sliderDimension.TickFrequency = 10;
            this.sliderDimension.Value = 100;
            this.sliderDimension.Scroll += new System.EventHandler(this.sliderDimension_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShape,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemShape
            // 
            this.toolStripMenuItemShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSquare,
            this.toolStripMenuItemCircle,
            this.toolStripMenuItemTriangle});
            this.toolStripMenuItemShape.Name = "toolStripMenuItemShape";
            this.toolStripMenuItemShape.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItemShape.Text = "Shape";
            // 
            // toolStripMenuItemSquare
            // 
            this.toolStripMenuItemSquare.Name = "toolStripMenuItemSquare";
            this.toolStripMenuItemSquare.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemSquare.Text = "Square";
            this.toolStripMenuItemSquare.Click += new System.EventHandler(this.toolStripMenuItemSquare_Click);
            // 
            // toolStripMenuItemCircle
            // 
            this.toolStripMenuItemCircle.Name = "toolStripMenuItemCircle";
            this.toolStripMenuItemCircle.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemCircle.Text = "Circle";
            this.toolStripMenuItemCircle.Click += new System.EventHandler(this.toolStripMenuItemCircle_Click);
            // 
            // toolStripMenuItemTriangle
            // 
            this.toolStripMenuItemTriangle.Name = "toolStripMenuItemTriangle";
            this.toolStripMenuItemTriangle.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemTriangle.Text = "Triangle";
            this.toolStripMenuItemTriangle.Click += new System.EventHandler(this.toolStripMenuItemTriangle_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // panelDecimal
            // 
            this.panelDecimal.Controls.Add(this.panelDecimalRadioButtons);
            this.panelDecimal.Controls.Add(this.LabelDecimalPlaces);
            this.panelDecimal.Location = new System.Drawing.Point(6, 3);
            this.panelDecimal.Name = "panelDecimal";
            this.panelDecimal.Size = new System.Drawing.Size(109, 184);
            this.panelDecimal.TabIndex = 5;
            // 
            // panelDecimalRadioButtons
            // 
            this.panelDecimalRadioButtons.BackColor = System.Drawing.Color.DarkGray;
            this.panelDecimalRadioButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDecimalRadioButtons.Controls.Add(this.radioButton4Decimal);
            this.panelDecimalRadioButtons.Controls.Add(this.radioButton3Decimal);
            this.panelDecimalRadioButtons.Controls.Add(this.radioButton2Decimal);
            this.panelDecimalRadioButtons.Location = new System.Drawing.Point(3, 23);
            this.panelDecimalRadioButtons.Name = "panelDecimalRadioButtons";
            this.panelDecimalRadioButtons.Size = new System.Drawing.Size(103, 158);
            this.panelDecimalRadioButtons.TabIndex = 1;
            // 
            // radioButton4Decimal
            // 
            this.radioButton4Decimal.AutoSize = true;
            this.radioButton4Decimal.Location = new System.Drawing.Point(2, 131);
            this.radioButton4Decimal.Name = "radioButton4Decimal";
            this.radioButton4Decimal.Size = new System.Drawing.Size(66, 17);
            this.radioButton4Decimal.TabIndex = 2;
            this.radioButton4Decimal.Text = "4 Places";
            this.radioButton4Decimal.UseVisualStyleBackColor = true;
            this.radioButton4Decimal.CheckedChanged += new System.EventHandler(this.radioButton4Decimal_CheckedChanged);
            // 
            // radioButton3Decimal
            // 
            this.radioButton3Decimal.AutoSize = true;
            this.radioButton3Decimal.Location = new System.Drawing.Point(2, 66);
            this.radioButton3Decimal.Name = "radioButton3Decimal";
            this.radioButton3Decimal.Size = new System.Drawing.Size(66, 17);
            this.radioButton3Decimal.TabIndex = 1;
            this.radioButton3Decimal.Text = "3 Places";
            this.radioButton3Decimal.UseVisualStyleBackColor = true;
            this.radioButton3Decimal.CheckedChanged += new System.EventHandler(this.radioButton3Decimal_CheckedChanged);
            // 
            // radioButton2Decimal
            // 
            this.radioButton2Decimal.AutoSize = true;
            this.radioButton2Decimal.Checked = true;
            this.radioButton2Decimal.Location = new System.Drawing.Point(2, 3);
            this.radioButton2Decimal.Name = "radioButton2Decimal";
            this.radioButton2Decimal.Size = new System.Drawing.Size(66, 17);
            this.radioButton2Decimal.TabIndex = 0;
            this.radioButton2Decimal.TabStop = true;
            this.radioButton2Decimal.Text = "2 Places";
            this.radioButton2Decimal.UseVisualStyleBackColor = true;
            this.radioButton2Decimal.CheckedChanged += new System.EventHandler(this.radioButton2Decimal_CheckedChanged);
            this.radioButton2Decimal.Enter += new System.EventHandler(this.radioButton2Decimal_Enter);
            // 
            // LabelDecimalPlaces
            // 
            this.LabelDecimalPlaces.AutoSize = true;
            this.LabelDecimalPlaces.Location = new System.Drawing.Point(4, 4);
            this.LabelDecimalPlaces.Name = "LabelDecimalPlaces";
            this.LabelDecimalPlaces.Size = new System.Drawing.Size(45, 13);
            this.LabelDecimalPlaces.TabIndex = 0;
            this.LabelDecimalPlaces.Text = "Decimal";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(4, 10);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(48, 13);
            this.labelMinValue.TabIndex = 6;
            this.labelMinValue.Text = "Min = 50";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(170, 10);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(57, 13);
            this.labelMaxValue.TabIndex = 7;
            this.labelMaxValue.Text = "Max = 150";
            // 
            // panelDimensionSlider
            // 
            this.panelDimensionSlider.Controls.Add(this.labelMaxValue);
            this.panelDimensionSlider.Controls.Add(this.sliderDimension);
            this.panelDimensionSlider.Controls.Add(this.labelMinValue);
            this.panelDimensionSlider.Location = new System.Drawing.Point(6, 193);
            this.panelDimensionSlider.Name = "panelDimensionSlider";
            this.panelDimensionSlider.Size = new System.Drawing.Size(236, 82);
            this.panelDimensionSlider.TabIndex = 8;
            // 
            // labelBoundary
            // 
            this.labelBoundary.AutoSize = true;
            this.labelBoundary.Location = new System.Drawing.Point(3, 0);
            this.labelBoundary.Name = "labelBoundary";
            this.labelBoundary.Size = new System.Drawing.Size(88, 13);
            this.labelBoundary.TabIndex = 9;
            this.labelBoundary.Text = "Boundary Length";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(137, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(29, 13);
            this.labelArea.TabIndex = 10;
            this.labelArea.Text = "Area";
            // 
            // textBoxBoundaryResult
            // 
            this.textBoxBoundaryResult.Location = new System.Drawing.Point(6, 17);
            this.textBoxBoundaryResult.Name = "textBoxBoundaryResult";
            this.textBoxBoundaryResult.ReadOnly = true;
            this.textBoxBoundaryResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxBoundaryResult.TabIndex = 11;
            // 
            // textBoxAreaResult
            // 
            this.textBoxAreaResult.Location = new System.Drawing.Point(140, 16);
            this.textBoxAreaResult.Name = "textBoxAreaResult";
            this.textBoxAreaResult.ReadOnly = true;
            this.textBoxAreaResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxAreaResult.TabIndex = 12;
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.labelArea);
            this.panelResults.Controls.Add(this.textBoxAreaResult);
            this.panelResults.Controls.Add(this.labelBoundary);
            this.panelResults.Controls.Add(this.textBoxBoundaryResult);
            this.panelResults.Location = new System.Drawing.Point(6, 281);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(243, 45);
            this.panelResults.TabIndex = 13;
            // 
            // panelControlArea
            // 
            this.panelControlArea.Controls.Add(this.panelShapes);
            this.panelControlArea.Controls.Add(this.panelResults);
            this.panelControlArea.Controls.Add(this.panelDecimal);
            this.panelControlArea.Controls.Add(this.panelDimensionSlider);
            this.panelControlArea.Location = new System.Drawing.Point(328, 27);
            this.panelControlArea.Name = "panelControlArea";
            this.panelControlArea.Size = new System.Drawing.Size(253, 334);
            this.panelControlArea.TabIndex = 14;
            // 
            // panelDrawingArea
            // 
            this.panelDrawingArea.Location = new System.Drawing.Point(12, 27);
            this.panelDrawingArea.Name = "panelDrawingArea";
            this.panelDrawingArea.Size = new System.Drawing.Size(310, 334);
            this.panelDrawingArea.TabIndex = 15;
            this.panelDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawingArea_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 373);
            this.Controls.Add(this.panelDrawingArea);
            this.Controls.Add(this.panelControlArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shape Calculator";
            this.panelShapeRadioButtons.ResumeLayout(false);
            this.panelShapeRadioButtons.PerformLayout();
            this.panelShapes.ResumeLayout(false);
            this.panelShapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDimension)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDecimal.ResumeLayout(false);
            this.panelDecimal.PerformLayout();
            this.panelDecimalRadioButtons.ResumeLayout(false);
            this.panelDecimalRadioButtons.PerformLayout();
            this.panelDimensionSlider.ResumeLayout(false);
            this.panelDimensionSlider.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelControlArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelShapeRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.Label labelShapes;
        private System.Windows.Forms.Panel panelShapes;
        private System.Windows.Forms.TrackBar sliderDimension;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShape;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSquare;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCircle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTriangle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.Panel panelDecimal;
        private System.Windows.Forms.Panel panelDecimalRadioButtons;
        private System.Windows.Forms.RadioButton radioButton4Decimal;
        private System.Windows.Forms.RadioButton radioButton3Decimal;
        private System.Windows.Forms.RadioButton radioButton2Decimal;
        private System.Windows.Forms.Label LabelDecimalPlaces;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.Panel panelDimensionSlider;
        private System.Windows.Forms.Label labelBoundary;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxBoundaryResult;
        private System.Windows.Forms.TextBox textBoxAreaResult;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelControlArea;
        private System.Windows.Forms.Panel panelDrawingArea;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;


    }
}

