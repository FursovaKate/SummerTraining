using System;

namespace ShapesHierarchy
{
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double inputLength, double inputWidth)
        {
            length = inputLength;
            width = inputWidth;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (width + length);
        }
    }
}
