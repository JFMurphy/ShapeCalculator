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
        int x = 5;
        int y = 5;

        String shape;

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

        /*
         * This ensures that the the square will be drawn in the drawing area when the form
         * is first opened, as the square is the default selection.
         */
         
        private void radioButtonSquare_Enter(object sender, EventArgs e)
        {
            setSquareDimensions();
            panelDrawingArea.Invalidate();
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            setSquareDimensions();
            panelDrawingArea.Invalidate();
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            setCircleDimensions();
            panelDrawingArea.Invalidate();
        }

        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            setTriangleDimensions();
            panelDrawingArea.Invalidate();
        }

        private void panelDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, penSize);

            

            if (radioButtonSquare.Checked)
            {
                g.DrawRectangle(blackPen, x, y, rectWidth, rectHeight);
            } else if (radioButtonCircle.Checked)
            {
                g.DrawEllipse(blackPen, x, y, circleWidth, circleHeight);
            } else if (radioButtonTriangle.Checked)
            {
                g.DrawPolygon(blackPen, trianglePoints());
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Group Members: John Francis Murphy, Daniel Murtagh" + "\n" + "Student Numbers: B00632566, B00xxxxxx");
        }

        private void sliderDimension_Scroll(object sender, EventArgs e)
        {
            if (radioButtonSquare.Checked)
            {
                setSquareDimensions();
                panelDrawingArea.Invalidate();
            }

            if (radioButtonCircle.Checked)
            {
                setCircleDimensions();
                panelDrawingArea.Invalidate();
            }

            if (radioButtonTriangle.Checked)
            {
                setTriangleDimensions();
            }

        }

        private void setSquareDimensions()
        {
            rectHeight = sliderDimension.Value * 2;
            rectWidth = sliderDimension.Value * 2;
        }

        private void setCircleDimensions()
        {
            circleHeight = sliderDimension.Value * 2;
            circleWidth = sliderDimension.Value * 2;
        }

        private void setTriangleDimensions()
        {
            
        }
        private Point[] trianglePoints()
        {
            Point point1 = new Point(x, y);
            Point point2 = new Point(x, y + rectHeight);
            Point point3 = new Point(x + rectWidth, y + rectHeight);
            Point[] trianglePoints = { point1, point2, point3 };

            return trianglePoints;
        }

    }
}
