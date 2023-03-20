using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETProblems
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public DateTime startDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string Department { get; set; }
        public double BasicPay { get;set; }
        public double Deduction { get;set; }
        public double TaxablePay { get;set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
