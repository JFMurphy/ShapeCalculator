using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Triangle : Shape
    {
        private double boundary;
        private double area;

        public override double calculateBoundary(double d)
        {
            boundary = (2 * d) + (Math.Sqrt(2 * d * d));

            return boundary;
        }

        public override double calculateArea(double d)
        {
            area = d / 2 * d;

            return area;
        }
    }
}
