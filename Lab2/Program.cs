using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("../../res/employees.txt");

            List<Employee> employees = new List<Employee>();

            // Read the data file line by line
            foreach (var line in lines)
            {
                var parts = line.Split(':');

                // Create the appropriate object based on the ID number
                Employee employee;

                if (parts[0].StartsWith("0") || parts[0].StartsWith("1") || parts[0].StartsWith("2") || parts[0].StartsWith("3") || parts[0].StartsWith("4"))
                {
                    employee = new Salaried(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]));
                }
                else if (parts[0].StartsWith("5") || parts[0].StartsWith("6") || parts[0].StartsWith("7"))
                {
                    employee = new Wages(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8]));
                }
                else
                {
                    employee = new PartTime(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8]));
                }

                employees.Add(employee);
            }

 
            //// b. Calculate and return the average weekly pay for all employees.
            //double totalPay = employees.OfType<Salaried>().Sum(e => e.GetPay()) +
            //                  employees.OfType<Wages>().Sum(e => e.GetPay()) +
            //                  employees.OfType<PartTime>().Sum(e => e.GetPay());
            //double averagePay = totalPay / employees.Count;
            //Console.WriteLine($"Average weekly pay: ${averagePay}");

            //// c. Calculate and return the highest weekly pay for the wage employees, including the name of the employee.
            //var highestWageEmployee = employees.OfType<Wages>().OrderByDescending(e => e.GetPay()).First();
            //Console.WriteLine($"Highest wage employee: {highestWageEmployee} {highestWageEmployee} , weekly pay: {highestWageEmployee.GetPay()}");

            //// d. Calculate and return the lowest salary for the salaried employees, including the name of the employee.
            //var lowestSalaryEmployee = employees.OfType<Salaried>().OrderBy(e => e.GetPay()).First();
            //Console.WriteLine($"Lowest salary employee: {lowestSalaryEmployee}, weekly pay: {lowestSalaryEmployee.GetPay()}");

            double totalSalariedPay = 0;
            double totalWagesPay = 0;
            double totalPartTimePay = 0;
            int salariedemployeecount = 0;
            int wagedemploycount = 0;
            int parttimeemploycount = 0;
            double totalEmployees = employees.Count;

            foreach (var employee in employees)
            {
                if (employee is Salaried salariedEmployee)
                {
                    totalSalariedPay += salariedEmployee.GetPay();
                    salariedemployeecount += 1;

                }
                else if (employee is Wages wagesEmployee)
                {
                    totalWagesPay += wagesEmployee.GetPay();
                    wagedemploycount += 1;
                }
                else if (employee is PartTime partTimeEmployee)
                {
                    totalPartTimePay += partTimeEmployee.GetPay();
                    parttimeemploycount += 1;
                }
            }

            //Console.WriteLine($"Slaried Employee average {totalSalariedPay/salariedemployeecount}");
            //Console.WriteLine($"Waged Employee average {totalWagesPay/wagedemploycount}");
            //Console.WriteLine($"Partime Employee average {totalPartTimePay/parttimeemploycount}");

            double averagePay = (totalSalariedPay + totalWagesPay + totalPartTimePay) / totalEmployees;

            Console.WriteLine($"Average weekly pay: {averagePay.ToString("C")}");

            // c. Calculate and return the highest weekly pay for the wage employees, including the name of the employee.
            Wages highestWageEmployee = null;
            double highestPay = 0;
            foreach (var employee in employees)
            {
                if (employee is Wages wagesEmployee && wagesEmployee.GetPay() > highestPay)
                {
                    highestWageEmployee = wagesEmployee;
                    highestPay = wagesEmployee.GetPay();
                }
            }
            if (highestWageEmployee != null)
            {
                Console.WriteLine($"Highest wage employee: {highestWageEmployee}, weekly pay: {highestWageEmployee.GetPay().ToString("C")}");
            }

            // d. Calculate and return the lowest salary for the salaried employees, including the name of the employee.
            Salaried lowestSalaryEmployee = null;
            double lowestPay = double.MaxValue;
            foreach (var employee in employees)
            {
                if (employee is Salaried salariedEmployee && salariedEmployee.GetPay() < lowestPay)
                {
                    lowestSalaryEmployee = salariedEmployee;
                    lowestPay = salariedEmployee.GetPay();
                }
            }
            if (lowestSalaryEmployee != null)
            {
                Console.WriteLine($"Lowest salary employee: {lowestSalaryEmployee}, weekly pay: {lowestSalaryEmployee.GetPay().ToString("C")}");
            }

            // e.	What percentage of the company’s employees fall into each employee category? 

            double salariedPercentage = (double)salariedemployeecount / totalEmployees * 100;
            double wagesPercentage = (double)wagedemploycount / totalEmployees * 100;
            double partTimePercentage = (double)parttimeemploycount / totalEmployees * 100;

            Console.WriteLine($"Salaried employees: {salariedPercentage.ToString("F2")}%");
            Console.WriteLine($"Wage employees: {wagesPercentage.ToString("F2")}%");
            Console.WriteLine($"Part-time employees: {partTimePercentage.ToString("F2")}%");
        }
    }

}
