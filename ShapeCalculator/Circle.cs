using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Circle : Shape
    {
        private double boundary;
        private double area;

        public override double calculateBoundary(double d)
        {
            boundary = Math.PI * d;

            return boundary;
        }

        public override double calculateArea(double d)
        {
            area = Math.PI * Math.Pow((d / 2), 2);

            return area;
        }
    }
}
