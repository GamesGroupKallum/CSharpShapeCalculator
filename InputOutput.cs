namespace CSharpShapeCalculator
{
    class InputOutput
    {
        public static double CollectDouble(string attribute)
        {
            while (true)
            {
                Console.WriteLine($"Please enter the {attribute}:");
                if (!double.TryParse(Console.ReadLine(), out double value) || value < 0) Console.WriteLine("Invalid input, use a valid mumber!");
                else return value;
            }
        }

        public static void OutputResult(string attribute, double result)
        {
            Console.WriteLine($"The {attribute} is {result}");
        }
    }
}
