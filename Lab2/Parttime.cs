using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class PartTime : Employee
    {
        private double Rate { get; set; }
        private double Hours { get; set; }

        public PartTime() { }
        public PartTime(string id, string name, string address, string phone, long sin, string dateOfBirth,
		string department, double rate, double hours) : base(id, name, address, phone, sin, dateOfBirth, department)
            { 
                this.Rate = rate;
                this.Hours = hours;
            }

        public double GetPay()
        {
            /*
             * •	Part-time employees’ pay is calculated based on hourly rate * work hours with no overtime paid.
             */
            double pay = this.Rate * this.Hours;
            return pay;
        }
        public void ToString(){}
    }

}
