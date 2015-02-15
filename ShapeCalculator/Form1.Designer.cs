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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButttonPanel.SuspendLayout();
            this.shapesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSlider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.radioButttonPanel.Size = new System.Drawing.Size(103, 158);
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
            this.shapesPanel.Location = new System.Drawing.Point(140, 3);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(109, 184);
            this.shapesPanel.TabIndex = 2;
            // 
            // dimensionSlider
            // 
            this.dimensionSlider.Location = new System.Drawing.Point(7, 26);
            this.dimensionSlider.Maximum = 150;
            this.dimensionSlider.Minimum = 50;
            this.dimensionSlider.Name = "dimensionSlider";
            this.dimensionSlider.Size = new System.Drawing.Size(220, 45);
            this.dimensionSlider.TabIndex = 3;
            this.dimensionSlider.TickFrequency = 10;
            this.dimensionSlider.Value = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.squareToolStripMenuItem.Text = "Square";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 184);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decimal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 158);
            this.panel2.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2 Places";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(2, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3 Places";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(2, 131);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4 Places";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min = 50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max = 150";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dimensionSlider);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(6, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 82);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Boundary Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Area";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(6, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 45);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.shapesPanel);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(465, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 334);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 334);
            this.panel6.TabIndex = 15;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 373);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shape Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radioButttonPanel.ResumeLayout(false);
            this.radioButttonPanel.PerformLayout();
            this.shapesPanel.ResumeLayout(false);
            this.shapesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSlider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;


    }
}

