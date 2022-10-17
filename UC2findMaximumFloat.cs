using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13FindMaximumUsingGenerics
{
    internal class UC2findMaximumFloat
    {
        public float findMaxFloat(float num1, float num2, float num3)
        {
            if ((num1.CompareTo(num2) > 0) && (num1.CompareTo(num3) > 0))
            {
                return num1;
            }

            else if (num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
