using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongProject
{
    internal class StringActions
    {
        public static int Is_1stString_include_2ndString(string s1, string s2)
        {
            int N = s1.Length;
            int M = s2.Length;
            int count = 0;

            for (int i = 0; i <= N - M; i++)
            {
                int j;
                /* For current index i, check for pattern match */
                for (j = 0; j < M; j++)
                    if (s1[i + j] != s2[j])
                        break;
                if (j == M)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
