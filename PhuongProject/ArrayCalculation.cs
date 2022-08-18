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
