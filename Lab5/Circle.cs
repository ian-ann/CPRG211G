using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    // Circle class definition
    public class Circle
    {
        public double Radius { get; private set; }

        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
                new InvalidRadiusException();   
            }
            else
            {
                new InvalidRadiusException(radius);            
            }

        }

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }
}