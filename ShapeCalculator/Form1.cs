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
        int rectHeight;
        int rectWidth;

        public Form1()
        {
            InitializeComponent();
            rectHeight = panel_DrawingArea.Height - 5;
            rectWidth = panel_DrawingArea.Width - 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_DrawingArea.Invalidate();            
        }

        private void panel_DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            Graphics g = panel_DrawingArea.CreateGraphics();
            g.DrawRectangle(blackPen, 0, 0, rectWidth, rectHeight);
        }


    }
}
