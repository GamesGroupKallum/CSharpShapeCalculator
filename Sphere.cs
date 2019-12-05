using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpShapeCalculator
{
    class Sphere
    {
        private double radius = 0.0;
        private double result = 0.0;

        private void CalculateSurfaceArea()
        {

            result = 4 * Math.PI * Math.Pow(radius, 2);
        }

        private void CalculateVolume()
        {
            result = (4 / 3 * Math.PI) * Math.Pow(radius, 3);
        }


        //alows the private methods to be run by menu running the public method
        public void Run()
        {
            radius = InputOutput.CollectDouble("length");
            CalculateSurfaceArea();
            InputOutput.OutputResult(" surfacearea", result);
            CalculateVolume();
            InputOutput.OutputResult("Circumference", result);
        }
    }
}
