using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpShapeCalculator
{
    class Cylinder
    {
        private double radius = 0.0;
        private double height = 0.0;
        private double result = 0.0;

        private void CalculateSurfaceArea()
        {

            result = (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
        }

        private void CalculateVolume()
        {
            result = Math.PI * Math.Pow(radius, 2) * height;
        }


        //alows the private methods to be run by menu running the public method
        public void Run()
        {
            radius = InputOutput.CollectDouble("length");
            height = InputOutput.CollectDouble("height");
            CalculateSurfaceArea();
            InputOutput.OutputResult("surface area", result);
            CalculateVolume();
            InputOutput.OutputResult("Volume", result);
        }
    }
}
