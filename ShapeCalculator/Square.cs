using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Square : Shape
    {
        private double boundary;
        private double area;

        public override double calculateBoundary(double d)
        {
            boundary = d * 4;

            return boundary;
        }

        public override double calculateArea(double d)
        {
            area = d * d;

            return area;
        }
    }
}
