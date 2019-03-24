using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesHierarchy;

namespace ShapesHierarchy_test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double radius = 5;
            var circleArea = new Circle(radius);
            double actual = circleArea.CalculateArea();
            double expected = 78.5398163397448;
            Assert.AreEqual(expected, actual, 0.00000001,  "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void CalculatePerimeterTest()
        {
            double radius = 5;
            var circlePerimeter = new Circle(radius);
            double actual = circlePerimeter.CalculatePerimeter();
            double expected = 31.4159265358979;
            Assert.AreEqual(expected, actual, 0.00000001, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class ReactangleAreaTest
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double length = 5;
            double width = 4;
            var rectangleArea = new Rectangle(width, length);
            double actual = rectangleArea.CalculateArea();
            double expected = 20;
            Assert.AreEqual(expected, actual, 0.00000001, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void CalculatePerimeterTest()
        {
            double length = 5;
            double width = 4;
            var rectanglePerimeter = new Rectangle(width, length);
            double actual = rectanglePerimeter.CalculatePerimeter();
            double expected = 18;
            Assert.AreEqual(expected, actual, 0.00000001, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double triangleBase = 4;
            double secondSide = 4;
            double thirdSide = 3;
            double triangleHeight = 5;
            var triangleArea = new Triangle(triangleBase, secondSide, thirdSide, triangleHeight);
            double actual = triangleArea.CalculateArea();
            double expected = 10;
            Assert.AreEqual(expected, actual, 0.00000001, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void CalculatePerimeterTest()
        {
            double triangleBase = 4;
            double secondSide = 4;
            double thirdSide = 3;
            double triangleHeight = 5;
            var trianglePerimeter = new Triangle(triangleBase, secondSide, thirdSide, triangleHeight);
            double actual = trianglePerimeter.CalculatePerimeter();
            double expected = 11;
            Assert.AreEqual(expected, actual, 0.00000001, "{0} != {1}", expected, actual);
        }
    }
}
