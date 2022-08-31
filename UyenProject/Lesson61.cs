using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UyenProject
{
    internal class Lesson61
    {
        // Enter an array contain only digits, has length > 50
        public static double[] ReadAndWriteAnArray()
        {
            double number = 0;
            double[] myArray = new double[15];

            Console.WriteLine("Enter elements for an array contain only number: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out number);
                myArray[i] = number;
            }

            Console.Write("\nWe have full array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0}  ", myArray[i]);
            }
            return myArray;
        }

        public static double CalculateSumFirst10Elements(double[] myArray)
        {
            double sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum = myArray[i] + sum;
            }

            Console.Write("Sum of 10 1st elements is: " + sum);
            return sum;
        }
    }
}
