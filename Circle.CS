using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpShapeCalculator
{
    class Circle
    {
        private double radius = 0.0;
        private double result = 0.0;

        private void CalculateArea()
        {

            result = Math.PI * Math.Pow(radius, 2);
        }

        private void CalculateCircumference()
        {
            result = 2 * Math.PI * radius;
        }


        //alows the private methods to be run by menu running the public method
        public void Run()
        {
            radius = InputOutput.CollectDouble("length");
            CalculateArea();
            InputOutput.OutputResult("area", result);
            CalculateCircumference();
            InputOutput.OutputResult("Circumference", result);
        }
    }
}
