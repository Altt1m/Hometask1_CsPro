using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hometask1
{
    public static class Calculator
    {
        public static double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double SubNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double MulNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double DivNumbers(double num1, double num2)
        {
            if (num2 !=0 )
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("Nizya na zero");
            }
            
        }
    }
}
