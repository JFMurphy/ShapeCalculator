using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCalculator
{
    public partial class Form1 : Form
    {
        int shapeDimension;
        int drawDimension;

        int decimalPlaces;

        int penSize = 5;
        int xOrigin = 5;
        int yOrigin = 5;

        Shape myShape = null;

        public Form1()
        {
            InitializeComponent();
            shapeDimension = sliderDimension.Value;
            drawDimension = sliderDimension.Value * 2;
        }


        // This ensures that the the square will be drawn in the drawing area when the form
        // is first opened, as the square is the default selection.
        private void radioButtonSquare_Enter(object sender, EventArgs e)
        {
            myShape = new Square();
            decimalPlaces = 1;
            setShapeDimensions();
            setDrawDimensions();
            panelDrawingArea.Invalidate();
            setTextBoxValues();
        }

        // Redraws the drawing area when the square radio button is changed.
        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            myShape = new Square();
            setShapeDimensions();
            setDrawDimensions();
            setTextBoxValues();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the circle radio button is changed.
        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            myShape = new Circle();
            setShapeDimensions();
            setDrawDimensions();
            setTextBoxValues();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the triangle radio button is changed.
        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            myShape = new Triangle();
            setShapeDimensions();
            setDrawDimensions();
            setTextBoxValues();
            panelDrawingArea.Invalidate();
        }

        private void radioButton2Decimal_CheckedChanged(object sender, EventArgs e)
        {
            decimalPlaces = 1;
            setTextBoxValues();
        }

        private void radioButton3Decimal_CheckedChanged(object sender, EventArgs e)
        {
            decimalPlaces = 2;
            setTextBoxValues();
        }

        private void radioButton4Decimal_CheckedChanged(object sender, EventArgs e)
        {
            decimalPlaces = 3;
            setTextBoxValues();
        }

        // Redraws the drawing area when the square menu option is clicked, it also checks the
        // square radio button.
        private void toolStripMenuItemSquare_Click(object sender, EventArgs e)
        {
            radioButtonSquare.Checked = true;
            setShapeDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the circle menu option is clicked, it also checks the
        // circle radio button.
        private void toolStripMenuItemCircle_Click(object sender, EventArgs e)
        {
            radioButtonCircle.Checked = true;
            setShapeDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the triangle menu option is clicked, it also checks the
        // triangle radio button.
        private void toolStripMenuItemTriangle_Click(object sender, EventArgs e)
        {
            radioButtonTriangle.Checked = true;
            setShapeDimensions();
            panelDrawingArea.Invalidate();
        }

        // Based on which shape radio button is selected this changes the size of the
        // size of the shape and displays the dimension in a text box.
        private void sliderDimension_Scroll(object sender, EventArgs e)
        {
            if (radioButtonSquare.Checked)
            {
                setShapeDimensions();
                setDrawDimensions();
                setTextBoxValues();
                panelDrawingArea.Invalidate();
            }

            if (radioButtonCircle.Checked)
            {
                setShapeDimensions();
                setDrawDimensions();
                setTextBoxValues();
                panelDrawingArea.Invalidate();
            }

            if (radioButtonTriangle.Checked)
            {
                setShapeDimensions();
                setDrawDimensions();
                setTextBoxValues();
                panelDrawingArea.Invalidate();
            }

        }

        // Enables the panel to be drawn on and creates a shape based on what radio button
        // is selected.
        private void panelDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, penSize);


            if (radioButtonSquare.Checked)
            {
                g.DrawRectangle(blackPen, xOrigin, yOrigin, drawDimension, drawDimension);
            }
            else if (radioButtonCircle.Checked)
            {
                g.DrawEllipse(blackPen, xOrigin, yOrigin, drawDimension, drawDimension);
            }
            else if (radioButtonTriangle.Checked)
            {
                g.DrawPolygon(blackPen, trianglePoints());
            }
        }

        // Closes the application.
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Displays a message box.
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            Form aboutForm = new Form2();
            aboutForm.Show();
        }

        // Sets the shape size variables to 2 times the current value of the slider value
        // so that the shape being drawn be will be able to fill the drawing area when at the
        // maximum slider value.
        private void setShapeDimensions()
        {
            shapeDimension = sliderDimension.Value;
        }

        private void setDrawDimensions()
        {
            drawDimension = sliderDimension.Value * 2;
        }
        
        // Creates points that will be used in order to create the triangle shape.
        private Point[] trianglePoints()
        {
            Point point1 = new Point(xOrigin, yOrigin);
            Point point2 = new Point(xOrigin, yOrigin + drawDimension);
            Point point3 = new Point(xOrigin + drawDimension, yOrigin + drawDimension);
            Point[] trianglePoints = { point1, point2, point3 };

            return trianglePoints;
        }

        // Updates the contents of the boundary and area text boxes based on the string passed in
        // through the parameter list.
        private void setTextBoxValues()
        {
            setBoundaryResult();
            setAreaResult();
            /*
            textBoxBoundaryResult.Text = myShape.calculateBoundary(shapeDimension).ToString() + "cm";
            textBoxAreaResult.Text = myShape.calculateArea(shapeDimension).ToString() + "cm^2";
            */
            textBoxSliderValue.Text = sliderDimension.Value.ToString() + "cm";
        }

        public void setBoundaryResult()
        {
            switch (decimalPlaces)
            {
                case 1:
                    textBoxBoundaryResult.Text = myShape.calculateBoundary(shapeDimension).ToString("#.##") + "cm";
                    break;
                case 2:
                    textBoxBoundaryResult.Text = myShape.calculateBoundary(shapeDimension).ToString("#.###") + "cm";
                    break;
                case 3:
                    textBoxBoundaryResult.Text = myShape.calculateBoundary(shapeDimension).ToString("#.####") + "cm";
                    break;
            }
        }

        public void setAreaResult()
        {
            switch (decimalPlaces)
            {
                case 1:
                    textBoxAreaResult.Text = myShape.calculateArea(shapeDimension).ToString("#.##") + "cm^2";
                    break;
                case 2:
                    textBoxAreaResult.Text = myShape.calculateArea(shapeDimension).ToString("#.###") + "cm^2";
                    break;
                case 3:
                    textBoxAreaResult.Text = myShape.calculateArea(shapeDimension).ToString("#.####") + "cm^2";
                    break;
            }
        }
    }
}
