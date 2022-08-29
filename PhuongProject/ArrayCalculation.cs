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
        public static string FirstTenArraySum(string[] array)
        {
            int l = array.Length;

            string[] cutString = new string[l];
            for (int i = 0; i < l; i++)
            {
                cutString[i] = array[i].Substring(0, 15);
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

        /// <summary>
        /// Return sum of all elements in an array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>Sum of all elements in an array</returns>
        public static string ArraySum(string[] array)
        {
            int l = array.Length;
            ulong[] subLong1 = new ulong[l];
            ulong[] subLong2 = new ulong[l];
            ulong[] subLong3 = new ulong[l];
            ulong[] subLong4 = new ulong[l];
            ulong[] subLong5 = new ulong[l];

            for (int i = 0; i < l; i++)
            {
                subLong1[i] = ulong.Parse(array[i].Substring(0, 10));
                subLong2[i] = ulong.Parse(array[i].Substring(10, 10));
                subLong3[i] = ulong.Parse(array[i].Substring(20, 10));
                subLong4[i] = ulong.Parse(array[i].Substring(30, 10));
                subLong5[i] = ulong.Parse(array[i].Substring(40, 10));
            }

            ulong sum5 = 0;
            ulong sum4 = 0;
            ulong sum3 = 0;
            ulong sum2 = 0;
            ulong sum1 = 0;
            ulong extraSum5 = 0;
            ulong extraSum4 = 0;
            ulong extraSum3 = 0; 
            ulong extraSum2 = 0;
           
            foreach (ulong ul in subLong5)
            { sum5 += ul; }
            string sum5String = sum5.ToString();
            if(sum5String.Length > 10)
                extraSum5 = ulong.Parse(sum5String.Substring(0, sum5String.Length - 10));

            foreach (ulong ul in subLong4)
            { sum4 += ul; }
            sum4 += extraSum5;
            string sum4String = sum4.ToString();
            if (sum4String.Length > 10)
                extraSum4 = ulong.Parse(sum4String.Substring(0, sum4String.Length - 10));

            foreach (ulong ul in subLong3)
            { sum3 += ul; }
            sum3 += extraSum4;
            string sum3String = sum3.ToString();
            if (sum4String.Length > 10)
                extraSum3 = ulong.Parse(sum3String.Substring(0, sum3String.Length - 10));

            foreach (ulong ul in subLong2)
            { sum2 += ul; }
            sum2 += extraSum3;
            string sum2String = sum2.ToString();
            if (sum4String.Length > 10)
                extraSum2 = ulong.Parse(sum2String.Substring(0, sum2String.Length - 10));

            foreach (ulong ul in subLong1)
            { sum1 += ul; }
            sum1 += extraSum2;
            string sum1String = sum1.ToString();

            return sum1String + sum2String + sum3String + sum4String + sum5String;

        }
    }
}