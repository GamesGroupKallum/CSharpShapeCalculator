using System;

namespace CSharpShapeCalculator
{
    class Square
    {
        private double result = 0.0;
        private double length = 0.0;

        public void Run()
        {
            length = InputOutput.CollectDouble("length");

            CalculateArea();
            InputOutput.OutputResult("area", result);

            CalculatePerimeter();
            InputOutput.OutputResult("perimeter", result);
        }

        private void CalculateArea()
        {
            result = Math.Pow(length, 2.0); 
        }

        private void CalculatePerimeter()
        {
            result = length * 4.0;
        }
    }
}
