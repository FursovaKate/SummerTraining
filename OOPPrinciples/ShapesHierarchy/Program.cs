using System;

namespace ShapesHierarchy
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Choose shape: 1 - circle; 2 - triangle; 3 - rectangle; 4 - square\n");
            bool successParse;
            int input;
            do
            {
                successParse = int.TryParse(Console.ReadLine(), out input);
                if (!successParse)
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (!successParse);


            if (input == 1)
            {
                Console.WriteLine("Write the radius of your circle: ");
                var radiusInput = ShapeHelper.ParseInput();
                var circle = new Circle(radiusInput);
                var area = circle.CalculateArea();
                var perimeter = circle.CalculatePerimeter();

                ShapeHelper.PrintResult(area, perimeter);
            }

            if (input == 2)
            {
                Console.WriteLine("Enter your base length: ");
                var triangleBaseInput = ShapeHelper.ParseInput();

                Console.WriteLine("Enter 2ndSide: ");
                var secondSideInput = ShapeHelper.ParseInput();

                Console.WriteLine("Enter 3rdSide: ");
                var thirdSideInput = ShapeHelper.ParseInput();

                Console.WriteLine("Enter the height: ");
                var triangleHeightInput = ShapeHelper.ParseInput();

                var triangle = new Triangle(triangleBaseInput, secondSideInput, thirdSideInput, triangleHeightInput);
                var area = triangle.CalculateArea();
                var perimeter = triangle.CalculatePerimeter();
                ShapeHelper.PrintResult(area, perimeter);
            }

            if (input == 3)
            {
                Console.WriteLine("Enter the width: ");
                var widthInput = ShapeHelper.ParseInput();
                Console.WriteLine("Enter the height: ");
                var heightInput = ShapeHelper.ParseInput();

                var rectangle = new Rectangle(widthInput, heightInput);
                var area = rectangle.CalculateArea();
                var perimeter = rectangle.CalculatePerimeter();
                ShapeHelper.PrintResult(area, perimeter);

            }

            if (input == 4)
            {
                Console.WriteLine("Enter the side of square: ");
                var sideInput = ShapeHelper.ParseInput();
                var square = new Square(sideInput);
                var area = square.CalculateArea();
                var perimeter = square.CalculatePerimeter();
                ShapeHelper.PrintResult(area, perimeter);
            }
        }
    }
}
