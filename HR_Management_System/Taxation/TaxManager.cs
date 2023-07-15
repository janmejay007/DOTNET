using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxation
{
    public class TaxManager 
    {
        public static double payIncomeTax = 0.04;
        public static double paySalesTax = 0.02;
        public static double payProfessionalTax = 0.04;
        public double totalTax = payIncomeTax + paySalesTax + payProfessionalTax;




        public double PayIncomeTax(double salary)
        {
            return salary - (salary * totalTax);
        }
    }
}
