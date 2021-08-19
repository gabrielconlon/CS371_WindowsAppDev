using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    sealed class BasePlusComissionEmployee : ComissionEmployee, IComparable
    {
        private decimal baseSalary;

        public decimal BaseSalary { get { return baseSalary; } set { baseSalary = value; } }

        public BasePlusComissionEmployee(string first, string last, string ssn, decimal rate, decimal salary, string address)
            : base(first, last, ssn, rate, address)
        {
            using (SalaryException obj = new SalaryException())
            {
                if (obj.checkSalary(salary))
                    baseSalary = salary;
            }
        }

        public override decimal GetPaymentAmount()
        {
            return baseSalary + base.GetPaymentAmount();
        }

        public override string ToString()
        {
            return string.Format("Base plus {0}\nBase Salary {1:C}",
                base.ToString(), baseSalary);
        }

        public int CompareTo(Object obj)
        {
            return this.GetPaymentAmount().CompareTo(((Employee)obj).GetPaymentAmount());
        }
    }