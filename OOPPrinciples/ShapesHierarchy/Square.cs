using System;

namespace ShapesHierarchy
{
    class Square : IShape
    {
        private double side;

        public Square(double inputSide)
        {
            side = inputSide;
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public double CalculatePerimeter()
        {
            return side * 4;
        }


    }
}
