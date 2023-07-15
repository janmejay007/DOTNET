﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class HRManager : Employee
    {
        public double da { get; set; } = 0;
        public double ta { get; set; } = 0;
        public double hra { get; set; } = 0;
        public double totalSalary = 0;

        public HRManager(int id, string fname, string lname, string email, double salary, double da, double ta, double hra) : base(id, fname, lname, email, salary)
        {
            this.da = da;
            this.ta = ta;
            this.hra = hra;
            totalSalary = base.ComputeSalary() + da + ta + hra;
        }

        public override double ComputeSalary()
        {
           
            return base.ComputeSalary() + da + ta + hra;
        }

        public override string ToString()
        {
            string data = String.Format("{0},{1}", base.ToString(), totalSalary);
            return data;
        }

    }
}
