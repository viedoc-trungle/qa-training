using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PhuongProject
{
    public class Validator
    {
        /// <summary>
        /// User input and validate number
        /// </summary>
        /// <param name="numberName">Name of the number</param>
        /// <returns>The input number</returns>
        public static double InputNumber(string numberName)
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
        public static Calculator.Operator InputOperator()
        {
            string inputOperator;
            while (true)
            {
                Console.Write("Input the operator (sum, subtract, multiply, divide): ");
                inputOperator = Console.ReadLine().ToLower();
                switch (inputOperator)
                {
                    case "sum":
                        return Calculator.Operator.sum;
                    case "subtract":
                        return Calculator.Operator.subtract;
                    case "multiply":
                        return Calculator.Operator.multiply;
                    case "divide":
                        return Calculator.Operator.divide;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
            }
        }
    }
}
