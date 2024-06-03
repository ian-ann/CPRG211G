using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Salaried : Employee
    {
        private double Salary { get; set; }

        public Salaried() { }

        public Salaried(string id, string name, string address, string phone, long sin, string dateOfBirth,
		string department, double salary) : base(id, name, address, phone, sin, dateOfBirth, department)
        {
 
	        this.Salary = salary;
        }

        public double GetPay()
            { 
                // •	Salaried employees are paid a set salary each week.
                return this.Salary; 
            }

        public void ToString(){}
    }
}
