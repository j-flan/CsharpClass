using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeff_Flanegan.Models
{
    public class WageCalculator
    {
        public string Name { get; set; }
        public string EmployeeNumber { get; set; }
        public Double Hours { get; set; }
        public Double Rate  { get; set; }
        public string Wage {
            get
            {
                
                Double overtimePay = 0;
                if (Hours > 40)
                {
                    Double overtime = 0;
                    overtime = Hours - 40;       
                    Hours = 40;
                    overtimePay = overtime * (Rate * 1.5);
                }
                Double pay = Hours * Rate + overtimePay;
                return pay.ToString("C");
            }
        }

        public WageCalculator()
        {
            Name = "";
            EmployeeNumber = "";
            Hours = 0;
            Rate = 0;
        }
    }
}