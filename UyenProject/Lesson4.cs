namespace UyenProject
{
    internal class Lesson4
    { 
        //Enter string and check if it's empty
        public static string CheckStringIsEmpty()
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine().ToLower();
            if (str == string.Empty)
            {
                Console.WriteLine("String is empty, please enter again: ");
            }
            return str;
        }

        //Check if str1 is substring of str2 and count number times appears of str1 in str2
        public static int IsSubstringAndCount(string str1, string str2)
        {
            int L1 = str1.Length;
            int L2 = str2.Length;
            int count = 0; 
            for (int i = 0; i <= L2 - L1; i++)
            {
                int j;
                for(j = 0; j < L1; j++)
                    if (str2[i + j] != str1[j])
                        break;
                if (j == L1)
                {
                    count++;
                    j=0;
                }
            }
            return count;
        }

    }
}
