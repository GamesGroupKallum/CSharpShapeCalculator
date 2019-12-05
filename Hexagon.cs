using System;

namespace CSharpShapeCalculator
{
    class Hexagon
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
            result = ((3.0 * Math.Sqrt(3.0)) / 2) * Math.Pow(edge, 2.0);
        }

        private void CalculatePerimeter()
        {
            result = edge * 6.0;
        }
    }
}
