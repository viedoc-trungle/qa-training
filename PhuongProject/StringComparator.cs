using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongProject
{
    internal class StringComparator
    {
        /// <summary>
        /// Calculate the number of occurrences of string 2 in string 1
        /// </summary>
        /// <param name="str1">string 1</param>
        /// <param name="str2">string 2</param>
        /// <returns>number of occurrences</returns>
        public static int SubStringOccurrences(string str1, string str2)
        {
            int l1 = str1.Length;
            int l2 = str2.Length;
            int occurrences = 0;
            List<char> matchedChar = new();
            for (int i = 0; i < l1; i++)
            {
                int k = i;

                for (int j = 0; j < l2; j++)
                {
                    if (str1[k] == str2[j])
                    {
                        matchedChar.Add(str2[j]);
                        if (k >= l1 - 1)
                        {
                            if (j >= l2 - 1)
                            {
                                break;
                            }
                            {
                                matchedChar.Clear();
                                break;
                            }
                        }
                        k++;
                    }
                    else
                    {
                        matchedChar.Clear();
                        break;
                    }
                }

                if (matchedChar.Count != 0)
                    occurrences++;

                matchedChar.Clear();
            }
            return occurrences;
        }
    }
}


