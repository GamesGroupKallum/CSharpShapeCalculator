using System;

namespace CSharpShapeCalculator
{
    class Rectangle
    {
        private double result = 0.0;
        private double length = 0.0;
        private double width = 0.0;

        public void Run()
        {
            length = InputOutput.CollectDouble("length");
            width = InputOutput.CollectDouble("width");

            CalculateArea();
            InputOutput.OutputResult("area", result);

            CalculatePerimeter();
            InputOutput.OutputResult("perimeter", result);
        }

        private void CalculateArea()
        {
            result = length * width;
        }

        private void CalculatePerimeter()
        {
            result = (length * 2) + (width * 2);
        }
    }
}
