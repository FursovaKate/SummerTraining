using System;

namespace ShapesHierarchy
{
    public class Triangle : IShape
    {
        private double triangleBase;
        private double secondSide;
        private double thirdSide;
        private double triangleHeight;

        public Triangle(double triangleBaseInput, double secondSideInput, double thirdSideInput, double triangleHeightInput)
        {
            triangleBase = triangleBaseInput;
            secondSide = secondSideInput;
            thirdSide = thirdSideInput;
            triangleHeight = triangleHeightInput;
        }

        public double CalculateArea()
        {
            return 0.5 * triangleBase * triangleHeight;
        }

        public double CalculatePerimeter()
        {
            return triangleBase + secondSide + thirdSide;
        }
    }
}
