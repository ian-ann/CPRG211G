using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Wages : Employee
    {
        private double Rate { get; set; }
        private double Hours { get; set; }
        private string name { get; set; }

        public Wages() { }
        public Wages(string id, string name, string address, string phone, long sin, string dateOfBirth,
		string dept, double rate, double hours) : base(id, name, address, phone, sin, dateOfBirth, dept)
            { 
                this.Rate = rate;
                this.Hours = hours;
                this.name = name;
            }


        public double GetPay()
            {
            	/*Wage employees’ pay is calculated using hourly rate * work hours with overtime paid at time and a half for any hours worked over 40 in one week.*/
                double pay = 0;
                if (this.Hours <= 40)
                    pay = this.Hours  * this.Rate;
                else
                    pay =  (this.Rate * 40) + ((this.Hours - 40) * this.Rate * 1.5);

                return pay; 
            }

        public void ToString(){}
    }

}
