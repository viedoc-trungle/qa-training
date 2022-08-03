namespace PhuongProject
{
    public class Calculator
    {
        public enum Operator
        {
            sum,
            subtract,
            multiply,
            divide
        }
        /// <summary>
        /// User input and validate number
        /// </summary>
        /// <param name="numberName">Name of the number</param>
        /// <returns>The input number</returns>
        public double InputNumber(string numberName)
        {
            Console.Write($"Input {numberName}: ");
            var inputNumber = Console.ReadLine();
            double number;
            while (!double.TryParse(inputNumber, out number))
            {
                Console.Write($"Invalid number. Input {numberName} again: ");
                inputNumber = Console.ReadLine();
            }

            return number;
        }
        /// <summary>
        /// User input and validate operator 
        /// </summary>
        /// <returns>The input operator</returns>
        public Operator InputOperator()
        {
            string inputOperator;
            while (true)
            {
                Console.Write("Input the operator (sum, subtract, multiply, divide): ");
                inputOperator = Console.ReadLine().ToLower();
                switch (inputOperator)
                {
                    case "sum":
                        return Operator.sum;
                    case "subtract":
                        return Operator.subtract;
                    case "multiply":
                        return Operator.multiply;
                    case "divide":
                        return Operator.divide;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
            }
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
