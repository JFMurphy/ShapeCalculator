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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxAbout.AppendText("Welcome to Shape Calculator." + Environment.NewLine);
            textBoxAbout.AppendText("This is a simple program that calculates the boundary and area of " +
            "a square, a circle and a triangle." + Environment.NewLine);
            textBoxAbout.AppendText(Environment.NewLine);
            textBoxAbout.AppendText("Group ID: CW1-70" + Environment.NewLine);
            textBoxAbout.AppendText("Student Names: John Francis, Daniel Murtagh" + Environment.NewLine);
            textBoxAbout.AppendText("Student Numbers: B00632566, B00630757");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
