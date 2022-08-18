using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongProject
{
    internal class StringActions
    {
        /*
         * Input 2 strings
         * Check whether 1st string include 2nd string
         * output the number of appear times of 2nd string in 1st string
         */

        public static int Is_1stString_include_2ndString(string s1, string s2)
        {
            int _1StStringLengthN = s1.Length;
            int _2StStringLengthN = s2.Length;
            int count = 0;

            for (int i = 0; i <= _1StStringLengthN - _2StStringLengthN; i++)
            {
                int j;
                /* For current index i, check for pattern match */
                for (j = 0; j < _2StStringLengthN; j++)
                    if (s1[i + j] != s2[j])
                        break;
                if (j == _2StStringLengthN)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
