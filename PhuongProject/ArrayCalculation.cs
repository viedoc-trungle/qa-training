using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongProject
{
    internal class ArrayCalculation
    {
        /// <summary>
        /// Update the data for the first array based on the second array
        /// </summary>
        /// <param name="array1">first array</param>
        /// <param name="array2">second array</param>
        /// <returns>the updated first array</returns>
        public static int[] ArrayCalculate(int[] array1, int[] array2)
        {
            int l2 = array2.Length;
            for (int i = 0; i < l2; i++)
            {
                array1[array2[i]] += i;

            }
            return array1;
        }

        /// <summary>
        /// Return the first 10 numbers of sum of all elements in an array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The first 10 numbers of sum of all elements in an array</returns>
        public static string GetFirstTenDigitArraySum(string[] array)
        {
            return ArraySum(array).Substring(0, 10);
        }

        /// <summary>
        /// Return sum of all elements in an array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>Sum of all elements in an array</returns>
        public static string ArraySum(string[] array)
        {
            string sum = null;
            string extraSum = null;

            for (int i = 49; i >= 0; i--)
            {
                int tempSum = 0;
                foreach (var num in array)
                {
                    tempSum += int.Parse(num.Substring(i, 1));
                }
                tempSum += extraSum == null ? 0 : int.Parse(extraSum);
                sum = string.Concat(i == 0 ? tempSum : tempSum.ToString().Substring(tempSum.ToString().Length - 1, 1), sum);
                extraSum = tempSum.ToString().Substring(0, tempSum.ToString().Length - 1);
            }

            return sum;
        }
    }
}