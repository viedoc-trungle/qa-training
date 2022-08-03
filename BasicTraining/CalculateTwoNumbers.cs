using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace BasicTraining
{
    internal class CalculateTwoNumbers
    {
        public double calculate2Numbers(string inputOperator, double a, double b)
        {
            if (inputOperator == "add")
                return a+b;
            else if (inputOperator == "subtract")
                return a-b;
            else if (inputOperator == "multiply")
                return a*b;
            else if (inputOperator == "divide")
                return a / b;
            else return 0;
        }

    }
}
