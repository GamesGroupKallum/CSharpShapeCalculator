using System;

namespace CSharpShapeCalculator
{
    class EquilateralTriangle
    {
        private double result = 0.0;       
        private double side = 0.0;

        public void Run()
        {          
            side = InputOutput.CollectDouble("side");

            CalculateArea();
            InputOutput.OutputResult("area", result);

            CalculatePerimeter();
            InputOutput.OutputResult("perimeter", result);
        }

        private void CalculateArea()
        {
            result = (Math.Sqrt(3.0) / 4.0) * Math.Pow(side, 2.0);
        }

        private void CalculatePerimeter()
        {
            result = side * 3.0;
        }
    }
}
