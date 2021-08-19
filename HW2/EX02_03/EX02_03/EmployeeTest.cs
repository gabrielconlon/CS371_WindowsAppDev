using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX02_03
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Gabe", "Conlon", 75M);
            Employee employee2 = new Employee("Pete", "Tucker", 1000000M);

            Console.WriteLine("Lastname:{0} Firstname:{1} Salary:{2:C}", employee1.firstName, employee1.lastName, employee1.Salary);
            Console.WriteLine("Lastname:{0} Firstname:{1} Salary:{2:C}\n", employee2.firstName, employee2.lastName, employee2.Salary);

            employee1.Salary = employee1.Salary * 1.1M;
            employee2.Salary = employee2.Salary * 1.1M;

            Console.WriteLine("Lastname:{0} Firstname:{1} Salary:{2:C}", employee1.firstName, employee1.lastName, employee1.Salary);
            Console.WriteLine("Lastname:{0} Firstname:{1} Salary:{2:C}", employee2.firstName, employee2.lastName, employee2.Salary);
        }
    }
}
