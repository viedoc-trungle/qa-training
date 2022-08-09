using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace UyenProject
{
    internal class Lesson3_Calculate
    {
        public static double Calculator(string operation, int num1, int num2)
        {
            if (operation == "+")
            {
                Sum(num1, num2);
            }
            else if (operation == "-")
            {
                Sub(num1, num2);
            }
            else if (operation == "*")
            {
                Multi(num1, num2);
            }

            else if (operation == "/")
            {
                Division(num1, num2);
            }

            return 0;
        }
        static void Sum(int num1, int num2)
        {
            Console.WriteLine("Sum of 2 numbers:" + (num1 + num2));

        }
        static void Sub(int num1, int num2)
        {
            Console.WriteLine("Sub of 2 numbers::" + (num1 - num2));

        }
        static void Multi(int num1, int num2)
        {
            Console.WriteLine("Multiplication of 2 numbers:" + (num1 * num2));

        }
        static void Division(int num1, int num2)
        {
            if (num2 != 0)
            {
                Console.WriteLine("Division of 2 numbers:" + (num1 / num2));
            }
            else if (num2 == 0)

            {
                Console.WriteLine("Can not divide to 0");
            }
        }

    }
}