using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class SalaryException : Exception, IDisposable
    {
        public SalaryException() { }
        public SalaryException(string message) : base(message) { }
        public SalaryException(string message, Exception inner) : base(message, inner) { }

        public void Dispose() { }

        public bool checkSalary(decimal salary)
        {
                try
                {
                    if (salary < 0)
                    {
                        SalaryException obj = new SalaryException("Salary Value is less than 0.");
                        throw obj;
                    }
                }
                catch (Exception exceptionParameter)
                {
                    Console.WriteLine("Error: " + exceptionParameter.Message);
                }
            return true;
        }
    }

public class SSNException : Exception, IDisposable
{
    public void Dispose() {}

    public SSNException(){}
    public SSNException(string message) : base(message) {}
    public SSNException(string message, Exception inner) : base(message, inner) {}

    public bool checkSSN(string ssn)
    {
            try
            {
                if (ssn.Length != 11)
                {
                    SalaryException obj = new SalaryException("SSN not valid, please make sure format is ***-**-****");
                    throw obj;
                }
            }
            catch (Exception exceptionParameter)
            {
                Console.WriteLine("Error: " + exceptionParameter.Message);
            }
        return true;
    }

}
