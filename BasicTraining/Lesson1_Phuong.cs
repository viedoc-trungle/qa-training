using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTraining
{
    internal class Lesson1_Phuong
    {
        public static void Sum()
        {
            Console.WriteLine("--- Lesson 1: Sum Operator");
            
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

            Console.Write("The total is: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine();
        }
    }
}
