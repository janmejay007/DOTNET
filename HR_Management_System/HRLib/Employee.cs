using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Employee
    {
        private int id { get; set; }=0;
        private string firstName { get; set; }=string.Empty;
        private string lastName { get; set; }=string.Empty; 
        private string email { get; set; } = string.Empty;
        private double salary { get; set; } =  0;

        public Employee() { }

        public Employee (int id, string firstName, string lastName, string email, double salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.salary = salary;
        }

        public virtual double ComputeSalary()
        {
            return salary;
        }

        public override string ToString()
        {
            string data = string.Format("{0},{1},{2},{3},{4}", this.id,this.firstName,this.lastName,this.email,this.salary) ;
            return data;
        }
    }
}
