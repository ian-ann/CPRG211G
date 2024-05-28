using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        private string ID { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private long Sin { get; set; }
        private string DoB { get; set; }
        private string Dept { get; set; }



        public void Employee();
    }

    public class Salaried : Employee
    {
        public double Salary { get; set; }

        public override double CalculateWeeklyPay()
        {
            return Salary;
        }
    }

    public class PartTime : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public override double CalculateWeeklyPay()
        {
            return HourlyRate * HoursWorked;
        }
    }

    public class Wages : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public override double CalculateWeeklyPay()
        {
            if (HoursWorked <= 40)
                return HourlyRate * HoursWorked;
            else
                return (HourlyRate * 40) + ((HoursWorked - 40) * HourlyRate * 1.5);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
