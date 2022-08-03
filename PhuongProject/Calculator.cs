using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
        /// Input and validate number
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
