using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Employee
    {
        private string ID { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private long Sin { get; set; }
        private string DoB { get; set; }
        private string Dept { get; set; }

        public Employee() { 
            }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            ID = id;
            Name = name;
            Address = address;
            Phone = phone;
            Sin = sin;
            DoB = dob;
            Dept = dept;
        }

        public override string ToString() 
        { 
            return Name;
        }

    }
}
