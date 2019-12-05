using System;

namespace CSharpShapeCalculator
{
    class Pentagon
    {
        private double result = 0.0;
        private double edge = 0.0;

        public void Run()
        {
            edge = InputOutput.CollectDouble("edge");

            CalculateArea();
            InputOutput.OutputResult("area", result);

            CalculatePerimeter();
            InputOutput.OutputResult("perimeter", result);
        }

        private void CalculateArea()
        {
            result = Math.Sqrt(5.0 * (5.0 + 2.0 * Math.Sqrt(5.0))) * 0.25 * Math.Pow(edge, 2.0);
        }

        private void CalculatePerimeter()
        {
            result = edge * 5.0;
        }
    }
}
