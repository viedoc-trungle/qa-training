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
                if (double.TryParse(Console.ReadLine(), out number))
                     myArray[i] = number;
                else
                    Console.WriteLine("Invalid input. Please enter numbers only");
            }           
            return myArray;
        }
        /// <summary>
        /// Summary all elements in an array
        /// </summary>
        /// <param name="myArray"></param>
        /// <returns></returns>
        public static double SumArrayElements(double[] myArray)
        {
            double sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine("Sum of all elements is: " + sum);          
           
            return sum;
        }
        ///Print 10 first digits in sum 
        public static double Print10Digits(double sum, int n)
        {
            // getting number of digits in sum
            int numberOfDigits =(int)Math.Floor(Math.Log10(sum)+1);
            Console.WriteLine("Number of Digits:" + numberOfDigits);          
            
            //Print 10 first digits in the number 
            double first10Digit = (double)(sum / Math.Pow(10, numberOfDigits - n));            
            Console.WriteLine("10 first digits is: " + Math.Round(first10Digit));
            return first10Digit;
        }
    }
}


