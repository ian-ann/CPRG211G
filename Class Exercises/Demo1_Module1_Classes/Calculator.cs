using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Module1_Classes
{
    internal class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }


        public string Add(string x, string y)
        {
            return x + y;
        }
        public string Add(string x, int y)
        {
            return x + y;
        }

        public string Add(int x, string y)
        {
            return x + y;
        }
    }
}
