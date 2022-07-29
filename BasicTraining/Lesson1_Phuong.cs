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
            Console.Write("--- Lesson 1: Sum Operator");
            Console.Write("Input the first number: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            double num2 = Double.Parse(Console.ReadLine());
            Console.Write("The total is: ");
            Console.WriteLine(num1 + num2);
        }
    }
}
