using System;

namespace CSharpShapeCalculator
{
    class ScaleneTriangle
    {
        private double result = 0.0;
        private double triangleBase = 0.0;
        private double height = 0.0;
        private double side = 0.0;

        public void Run()
        {
            triangleBase = InputOutput.CollectDouble("base");
            height = InputOutput.CollectDouble("height");
            side = InputOutput.CollectDouble("side");

            CalculateArea();
            InputOutput.OutputResult(result, "area");

            CalculatePerimeter();
            InputOutput.OutputResult(result, "perimeter");
        }

        private void CalculateArea()
        {
            result = (triangleBase * height) / 2.0;
        }

        private void CalculatePerimeter()
        {
            result = triangleBase + height + side;
        }
    }
}
