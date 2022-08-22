using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongProject
{
    internal class ArraysActions
    {
        public int[] createArray(int maxValue, int length)
        {
            int[] array = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int random = rnd.Next(0,maxValue);
                array[i] = random;
            }

            return array;
        }



        /*
         * Update Array
         */

        public int[] updateArray(int[] array1, int[] array2)
        {
         
            for (int j = 0; j < array2.Length; j++)
            {
                array1[array2[j]] += j;
            }

            return array1;
        }

        /*
         * Print array
         */

        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (i == arr.Length-1)
                    Console.WriteLine(arr[i]);
                else
                {
                    Console.Write(arr[i] + ", ");
                }

            }
                
        }

    }

}

