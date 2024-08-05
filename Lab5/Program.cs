using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Lab5
{
    // Main class to test the code
    public class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                var positiveRadiusCircle = new Circle();
                positiveRadiusCircle.SetRadius(5.0);
                Console.WriteLine(positiveRadiusCircle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            { 
                var negativeRadiusCircle = new Circle(); // This will throw an exception
                negativeRadiusCircle.SetRadius(-5.0);
                Console.WriteLine(negativeRadiusCircle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var zeroRadiusCircle = new Circle(); // This will also throw an exception
                zeroRadiusCircle.SetRadius(0);
                Console.WriteLine(zeroRadiusCircle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
 
 