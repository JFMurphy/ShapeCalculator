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
        int rectWidth;
        int rectHeight;
        int circleWidth;
        int circleHeight;
        int triangleWidth;
        int triangleHeight;

        int penSize = 5;
        int xOrigin = 5;
        int yOrigin = 5;


        public Form1()
        {
            InitializeComponent();
            rectHeight = sliderDimension.Value * 2;
            rectWidth = sliderDimension.Value * 2;
            circleHeight = sliderDimension.Value * 2;
            circleWidth = sliderDimension.Value * 2;
            triangleHeight = sliderDimension.Value * 2;
            triangleWidth = sliderDimension.Value * 2;
        }

        
        // This ensures that the the square will be drawn in the drawing area when the form
        // is first opened, as the square is the default selection.
        private void radioButtonSquare_Enter(object sender, EventArgs e)
        {
            setSquareDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the square radio button is changed.
        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            setSquareDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the circle radio button is changed.
        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            setCircleDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the triangle radio button is changed.
        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            setTriangleDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the square menu option is clicked, it also checks the
        // square radio button.
        private void toolStripMenuItemSquare_Click(object sender, EventArgs e)
        {
            radioButtonSquare.Checked = true;
            setSquareDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the circle menu option is clicked, it also checks the
        // circle radio button.
        private void toolStripMenuItemCircle_Click(object sender, EventArgs e)
        {
            radioButtonCircle.Checked = true;
            setCircleDimensions();
            panelDrawingArea.Invalidate();
        }

        // Redraws the drawing area when the triangle menu option is clicked, it also checks the
        // triangle radio button.
        private void toolStripMenuItemTriangle_Click(object sender, EventArgs e)
        {
            radioButtonTriangle.Checked = true;
            setTriangleDimensions();
            panelDrawingArea.Invalidate();
        }

        // Enables the panel to be drawn on and creates a shape based on what radio button
        // is selected.
        private void panelDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, penSize);


            if (radioButtonSquare.Checked)
            {
                g.DrawRectangle(blackPen, xOrigin, yOrigin, rectWidth, rectHeight);
            } else if (radioButtonCircle.Checked)
            {
                g.DrawEllipse(blackPen, xOrigin, yOrigin, circleWidth, circleHeight);
            } else if (radioButtonTriangle.Checked)
            {
                g.DrawPolygon(blackPen, trianglePoints());
            }
        }

        // Closes the application.
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Displays a message box.
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Group Members: John Francis Murphy, Daniel Murtagh" + "\n" + "Student Numbers: B00632566, B00630757");
        }

        // Based on which shape radio button is selected this changes the size of the
        // size of the shape and displays the dimension in a text box.
        private void sliderDimension_Scroll(object sender, EventArgs e)
        {
            if (radioButtonSquare.Checked)
            {
                setSquareDimensions();
                panelDrawingArea.Invalidate();
                textBoxBoundaryResult.Text = squareBoundaryResult();
                textBoxAreaResult.Text = squareAreaResult();
            }

            if (radioButtonCircle.Checked)
            {
                setCircleDimensions();
                panelDrawingArea.Invalidate();
                textBoxBoundaryResult.Text = circleBoundaryResult();
            }

            if (radioButtonTriangle.Checked)
            {
                setTriangleDimensions();
                panelDrawingArea.Invalidate();
            }

        }

        // Sets the square size variables to 2 times the current value of the slider value.
        private void setSquareDimensions()
        {
            rectHeight = sliderDimension.Value * 2;
            rectWidth = sliderDimension.Value * 2;
        }

        // Sets the square size variables to 2 times the current value of the slider value.
        private void setCircleDimensions()
        {
            circleHeight = sliderDimension.Value * 2;
            circleWidth = sliderDimension.Value * 2;
        }

        // Sets the square size variables to 2 times the current value of the slider value.
        private void setTriangleDimensions()
        {
            triangleHeight = sliderDimension.Value * 2;
            triangleWidth = sliderDimension.Value * 2;
        }

        // Creates points that will be used in order to create the triangle shape.
        private Point[] trianglePoints()
        {
            Point point1 = new Point(xOrigin, yOrigin);
            Point point2 = new Point(xOrigin, yOrigin + triangleHeight);
            Point point3 = new Point(xOrigin + triangleWidth, yOrigin + triangleHeight);
            Point[] trianglePoints = { point1, point2, point3 };

            return trianglePoints;
        }

        // 
        private string squareBoundaryResult()
        {
            float boundary;
            String stringValue;
            boundary = rectWidth * 2;
            stringValue = boundary.ToString();

            return stringValue;
        }

        private string squareAreaResult()
        {
            float area;
            String stringValue;
            area = rectHeight * rectWidth;
            stringValue = area.ToString();

            return stringValue;
        }

        private string circleBoundaryResult()
        {
            double boundary;
            String stringValue;
            boundary = Math.PI * circleWidth;
            stringValue = boundary.ToString();

            return stringValue;
        }

        private string circleAreaResult()
        {
            String stringValue;
            return stringValue;
        }

        private string triangleBoundaryResult()
        {
            String stringValue;
            return stringValue;
        }

        private string triangleAreaResult()
        {
            String stringValue;
            return stringValue;
        }



        private void setTextBoxValues(String s)
        {
            if (s == "Square")
            {
                textBoxBoundaryResult.Text = squareBoundaryResult();
                textBoxAreaResult.Text = squareAreaResult();
            } else if (s == "Circle")
            {
                textBoxBoundaryResult.Text = circleBoundaryResult();
                textBoxAreaResult.Text = circleAreaResult();
            } else if (s == "Triangle")
            {
                textBoxBoundaryResult.Text = triangleBoundaryResult();
                textBoxAreaResult.Text = triangleAreaResult();
            }
        }

    }
}
