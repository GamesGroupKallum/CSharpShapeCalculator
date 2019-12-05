using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpShapeCalculator
{
    class Cuboid
    {
        private double length = 0.0;
        private double width = 0.0;
        private double depth = 0.0;
        private double result = 0.0;

        private void CalculateCuboidSurfArea()
        {

            result = 2 * (length * width) + (length * depth) + (width * depth);
        }

        private void CalculateCuboidVolume()
        {
            result = length * width * depth;
        }


        //alows the private methods to be run by menu running the public method
        public void Run()
        {
            length = InputOutput.CollectDouble("length");
            width = InputOutput.CollectDouble("width");
            depth = InputOutput.CollectDouble("depth");
            CalculateCuboidSurfArea();
            InputOutput.OutputResult("surface area", result);
            CalculateCuboidVolume();
            InputOutput.OutputResult("Volume", result);
        }
    }
}
