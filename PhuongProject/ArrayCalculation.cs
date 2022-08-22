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
    }
}
