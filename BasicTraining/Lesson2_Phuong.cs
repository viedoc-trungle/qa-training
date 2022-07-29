using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTraining
{
    internal class Lesson2_Phuong
    {
        public static void Calculate()
        {
            Console.WriteLine("--- Lesson 2: Arithmetic Operator");

            Console.Write("Input the first number: ");
            var inputNum1 = Console.ReadLine();
            double num1;
            while (!double.TryParse(inputNum1, out num1))
            {
                Console.Write("Invalid number. Input the first number again: ");
                inputNum1 = Console.ReadLine();
            }

            Console.Write("Input the second number: ");
            var inputNum2 = Console.ReadLine();
            double num2;
            while (!double.TryParse(inputNum2, out num2))
            {
                Console.Write("Invalid number. Input the second number again: ");
                inputNum2 = Console.ReadLine();
            }

            Console.Write("Input the operator (sum, subtract, multiply, divide): ");
            double? result = null;
            while (result == null)
            {
                string inputOperator = Console.ReadLine().ToLower();
                switch (inputOperator)
                {
                    case "sum":
                        result = num1 + num2;
                        break;
                    case "subtract":
                        result = num1 - num2;
                        break;
                    case "multiply":
                        result = num1 * num2;
                        break;
                    case "divide":
                        result = num1 / num2;
                        break;
                    default:
                        Console.Write("Invalid operator. Input the operator (sum, subtract, multiply, divide) again:");
                        break;
                }
            }
            Console.Write("The result is: ");
            Console.WriteLine($"{result:0.##}");
        }
    }
}
