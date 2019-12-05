using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpShapeCalculator
{
    class Dodecahedron
    {
        private double length = 0.0;
        private double result = 0.0;

        private void CalculateSurfaceArea()
        {

            result = 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Math.Pow(length, 2);
        }

        private void CalculateVolume()
        {
            result = ((15 + 7 * Math.Sqrt(5)) / 4) * Math.Pow(length, 3);
        }


        //alows the private methods to be run by menu running the public method
        public void Run()
        {
            length = InputOutput.CollectDouble("length");

            CalculateSurfaceArea();
            InputOutput.OutputResult("length", result);
            CalculateVolume();
            InputOutput.OutputResult("Volume", result);
        }
    }
}
