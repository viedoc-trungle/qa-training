using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTraining
{
    internal class SumOfTwoNumbers
    {
        public int Sums(int a, int b)
        {
            return (a + b);
        }

        public float Subtract(float a, float b)
        {
            return (a - b);
        }

        public float multiply(int a, int b)
        {
            return (a * b);
        }

        public double divide(int a, int b)
        {
            double res = decimal.ToDouble(a) / decimal.ToDouble(b);
            return res;
        }

    }
}
