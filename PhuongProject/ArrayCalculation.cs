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
            int l1 = array1.Length;
            int l2 = array2.Length;
            int[] array3 = new int[l1];
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                    if (array2[j] == i)
                        array3[i] += j;

            }

            for (int i = 0; i < l1; i++)
            {
                array1[i] += array3[i];
            }

            return array1;
        }
    }
}
