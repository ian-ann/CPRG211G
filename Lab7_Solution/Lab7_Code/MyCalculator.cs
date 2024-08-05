using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Code
{
    public class MyCalculator : ICalculator
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Divide(double value1, double value2)
        {
            if(value2 == 0)
            {
                throw new DivideByZeroException();
            }
            return value1 / value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Subtract(double value1, double value2)
        {
            return value1- value2;
        }
    }
}
