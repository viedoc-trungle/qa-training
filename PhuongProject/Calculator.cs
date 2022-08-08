namespace PhuongProject
{
    public class Calculator
    {
        /// <summary>
        /// List of available operators
        /// </summary>
        public enum Operator
        {
            sum,
            subtract,
            multiply,
            divide
        }
        
        /// <summary>
        /// Calculate 2 numbers
        /// </summary>
        /// <param name="calculator">operator</param>
        /// <param name="num1">number 1</param>
        /// <param name="num2">number 2</param>
        /// <returns>result</returns>
        public double Calculate(Operator calculator, double num1, double num2)
        {
            switch (calculator)
            {
                case Operator.sum:
                    return num1 + num2;
                case Operator.subtract:
                    return num1 - num2;
                case Operator.multiply:
                    return num1 * num2;
                case Operator.divide:
                    return num1 / num2;
                default:
                    Console.WriteLine("Error: Invalid Operator.");
                    return 0;
            }
        }
    }
}
