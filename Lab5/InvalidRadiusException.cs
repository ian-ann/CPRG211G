using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    // InvalidRadiusException class definition
    public class InvalidRadiusException 
    {
        public InvalidRadiusException() 
        { 
            Console.WriteLine("Valid Message: Radius is greater than zero.");
            //throw new ArgumentException("Valid Message: Radius is greater than zero.");
        }

        public InvalidRadiusException(double radius) 
        {
            //Console.WriteLine($"Invalid radius: {radius}. Radius must be greater than zero.");
            throw new ArgumentException($"Invalid radius: {radius}. Radius must be greater than zero.");
        }
    }
}
