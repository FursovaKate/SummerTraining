using System;

namespace ShapesHierarchy
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double input)
        {
            radius = input;
        }

        public double CalculateArea()
        {
            return  Math.PI * (radius * radius);
           
        }

        public double CalculatePerimeter()
        {
           return ((2 * Math.PI) * radius);
 
        }
    }
}
