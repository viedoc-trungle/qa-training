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
            Console.Write("--- Lesson 2: Arithmetic Operator");
            Console.Write("Input the first number: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            double num2 = Double.Parse(Console.ReadLine());
            double? result = null;
            while (result == null)
            {
                Console.Write("Input the operator (sum, subtract, multiply, divide): ");
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
                        Console.WriteLine("Invalid operator. Please input again.");
                        break;
                }
            }
            Console.Write("The result is: ");
            Console.WriteLine($"{result:0.##}");
        }
    }
}
