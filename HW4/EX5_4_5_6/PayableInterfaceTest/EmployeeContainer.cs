using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class EmployeeContainer : IEnumerable, IEnumerator
    {

        private int position = -1;

        public Employee[] container;

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public EmployeeContainer()
        {
            container = new Employee[4];

            container[0] = new SalariedEmployee("John", "Smith",
         "111-11-1111", (-800.00M), "1 Smith DR");
            container[1] = new SalariedEmployee("Lisa", "Barnes",
               "888-88-8888", 1200.00M, "6 Wall AVE");
            container[2] = new ComissionEmployee("Gabe", "Conlon", "999-99-9999", 10.00M, "10 Army CT");
            container[3] = new BasePlusComissionEmployee("Pete", "Tucker", "000-00-0000", 15.00M, 15000, "300 W Hawthorne");
        }

        

        public void Reset() { position = 0; }
        public bool MoveNext() { position++; return (position < container.Count()); }
        public Object Current { get { return container[position]; } }
    }
