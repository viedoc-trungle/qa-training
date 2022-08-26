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
        public static string ArraySum(string[] array)
        {
            int l = array.Length;

            string[] cutString = new string[l];
            for (int i = 0; i < l; i++)
            {
                cutString[i] = array[i].Substring(0,15);
            }

            ulong[] tempLong = new ulong[l];
            for (int i = 0; i < l; i++)
            {
                tempLong[i] = ulong.Parse(cutString[i]);
            }
            
            ulong sumLong = 0;
            foreach (ulong ul in tempLong)
            {
                sumLong += ul;
            }

            return sumLong.ToString().Substring(0, 10);
        }
    }
}