﻿// Fig. 12.14: SalariedEmployee.cs
// SalariedEmployee class that extends Employee.
using System;

public class SalariedEmployee : Employee, IComparable
{
   private decimal weeklySalary;

   // four-parameter constructor
   public SalariedEmployee( string first, string last, string ssn,
      decimal salary, string address ) : base( first, last, ssn, address )
   {
       using (SalaryException obj = new SalaryException())
       {
           if (obj.checkSalary(salary))
               weeklySalary = salary;
       }// validate salary via property
   } // end four-parameter SalariedEmployee constructor

   // property that gets and sets salaried employee's salary
   public decimal WeeklySalary
   {
      get
      {
         return weeklySalary;
      } // end get
      set
      {
         if ( value >= 0 ) // validation
            weeklySalary = value;
         else
            throw new ArgumentOutOfRangeException( "WeeklySalary",
               value, "WeeklySalary must be >= 0" );
      } // end set
   } // end property WeeklySalary

   // calculate earnings; implement interface IPayable method
   // that was abstract in base class Employee
   public override decimal GetPaymentAmount()
   {                                         
      return WeeklySalary;                   
   } // end method GetPaymentAmount          

   // return string representation of SalariedEmployee object
   public override string ToString()
   {
      return string.Format( "salaried employee: {0}\n{1}: {2:C}",
         base.ToString(), "weekly salary", WeeklySalary );
   } // end method ToString

   public int CompareTo(Object obj)
   {
       return this.GetPaymentAmount().CompareTo(((Employee)obj).GetPaymentAmount());
   }
} // end class SalariedEmployee

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/