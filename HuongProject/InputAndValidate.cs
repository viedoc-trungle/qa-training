using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTraining
{
    internal class InputAndValidate
    {
        /*
         * Input and validate integer number
         */

        public static int InputAndValidateIntegerNumber()
        {
            Console.WriteLine("Input integer number: ");
            var num1 = Console.ReadLine();
            bool num1IsInt = int.TryParse(num1, out int number1);
            while (!num1IsInt)
            {
                Console.WriteLine("Input correct integer number: ");
                num1 = Console.ReadLine();
                num1IsInt = int.TryParse(num1, out number1);
            }
            return number1;
        }

        /*
         * Input and validate correct operator
         */
        public static string GetOperator()
        {
            List<string> operators = new List<string>() { "add", "subtract", "multiply", "divide" };
            Console.WriteLine("Input correct operator(add, subtract, multiply, divide): ");
            string op = Console.ReadLine().ToLower();

            while (!operators.Contains(op))
            {
                Console.WriteLine("Please input correct operator(add, subtract, multiply, divide): ");
                op = Console.ReadLine().ToLower();
            }

            return op;

        }
    }
}
