using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongProject
{
    internal class AddLongNumberString
    {
      
        

        public string getFirstTenDigit(string[] Arr)
        {
        
            string[] total = new string[51];
            int temp = 0;
            for (int i = 49; i >= 0; i--)
            {
                int dv = 0;
                int digit = temp +
                            Int32.Parse(Arr[0].Substring(i,1)) + Int32.Parse(Arr[1].Substring(i, 1)) +
                            Int32.Parse(Arr[2].Substring(i, 1)) + Int32.Parse(Arr[3].Substring(i, 1)) +
                            Int32.Parse(Arr[4].Substring(i, 1)) + Int32.Parse(Arr[5].Substring(i, 1)) +
                            Int32.Parse(Arr[6].Substring(i, 1)) + Int32.Parse(Arr[7].Substring(i, 1)) +
                            Int32.Parse(Arr[8].Substring(i, 1)) + Int32.Parse(Arr[9].Substring(i, 1));

                if (digit >= 10)
                {
                    temp = digit / 10;
                    dv = digit % 10;
                }
                else
                {
                    dv = digit;
                }

                total[i + 1] = dv.ToString();
                if (i == 0)
                    total[0] = temp.ToString();


            }

            string _1stTenDigit = null;
            if(total[0] != "0")
                _1stTenDigit = total[0] + total[1] + total[2] + total[3] + total[4] + total[5] + total[6] +
                                  total[7] + total[8] + total[9];
            else
            {
                _1stTenDigit = total[1] + total[2] + total[3] + total[4] + total[5] + total[6] +
                               total[7] + total[8] + total[9]+ total[10];
            }

            return _1stTenDigit;
        }
    }

        


}
