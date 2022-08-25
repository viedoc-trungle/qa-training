using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UyenProject
{
    internal class Lesson5
    {
        //Write a program to update the data for the 1st array based on the second array.
        //The new value will be the sum of the original value and the position of all the iterators on the second array
        //which have the value equal the position of it.
        public static int UpdateDataForThe1stArray(int[] array1, int[] array2)
        {    
            int l1 = array1.Length;
            int l2 = array2.Length;

          for (int j = 0; j < l2; j++)
            {
                array1[array2[j]] += j;
            }

            for (int i = 0; i < l1; i++)
            {
                Console.Write(array1[i] + " ");
            }
            return 0;
        }
    }
}
