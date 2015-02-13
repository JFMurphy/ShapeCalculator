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
            this.radioButttonPanel = new System.Windows.Forms.Panel();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.shapesLabel = new System.Windows.Forms.Label();
            this.shapesPanel = new System.Windows.Forms.Panel();
            this.dimensionSlider = new System.Windows.Forms.TrackBar();
            this.radioButttonPanel.SuspendLayout();
            this.shapesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButttonPanel
            // 
            this.radioButttonPanel.BackColor = System.Drawing.Color.DarkGray;
            this.radioButttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.radioButttonPanel.Controls.Add(this.triangleRadioButton);
            this.radioButttonPanel.Controls.Add(this.circleRadioButton);
            this.radioButttonPanel.Controls.Add(this.squareRadioButton);
            this.radioButttonPanel.Location = new System.Drawing.Point(3, 23);
            this.radioButttonPanel.Name = "radioButttonPanel";
            this.radioButttonPanel.Size = new System.Drawing.Size(100, 155);
            this.radioButttonPanel.TabIndex = 0;
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.Location = new System.Drawing.Point(3, 131);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.triangleRadioButton.TabIndex = 8;
            this.triangleRadioButton.TabStop = true;
            this.triangleRadioButton.Text = "Triangle";
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Location = new System.Drawing.Point(3, 66);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.circleRadioButton.TabIndex = 7;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "Circle";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(3, 3);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(59, 17);
            this.squareRadioButton.TabIndex = 6;
            this.squareRadioButton.TabStop = true;
            this.squareRadioButton.Text = "Square";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            // 
            // shapesLabel
            // 
            this.shapesLabel.AutoSize = true;
            this.shapesLabel.Location = new System.Drawing.Point(3, 4);
            this.shapesLabel.Name = "shapesLabel";
            this.shapesLabel.Size = new System.Drawing.Size(38, 13);
            this.shapesLabel.TabIndex = 1;
            this.shapesLabel.Text = "Shape";
            // 
            // shapesPanel
            // 
            this.shapesPanel.Controls.Add(this.shapesLabel);
            this.shapesPanel.Controls.Add(this.radioButttonPanel);
            this.shapesPanel.Location = new System.Drawing.Point(12, 58);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(109, 184);
            this.shapesPanel.TabIndex = 2;
            // 
            // dimensionSlider
            // 
            this.dimensionSlider.Location = new System.Drawing.Point(12, 296);
            this.dimensionSlider.Name = "dimensionSlider";
            this.dimensionSlider.Size = new System.Drawing.Size(220, 45);
            this.dimensionSlider.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 432);
            this.Controls.Add(this.dimensionSlider);
            this.Controls.Add(this.shapesPanel);
            this.Name = "Form1";
            this.Text = "Shape Calculator";
            this.radioButttonPanel.ResumeLayout(false);
            this.radioButttonPanel.PerformLayout();
            this.shapesPanel.ResumeLayout(false);
            this.shapesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel radioButttonPanel;
        private System.Windows.Forms.RadioButton triangleRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.Label shapesLabel;
        private System.Windows.Forms.Panel shapesPanel;
        private System.Windows.Forms.TrackBar dimensionSlider;


    }
}

