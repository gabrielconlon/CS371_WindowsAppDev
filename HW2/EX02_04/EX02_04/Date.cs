using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX02_04
{
    class Date
    {
        public Date(int x, int y, int z)
        {
            month = x;
            day = y;
            year = z;
        }

        public int month
        {
            get;
            set;
        }
        public int day
        {
            get;
            set;
        }
        public int year
        {
            get;
            set;
        }

        public void DisplayDate()
        {
            System.Console.WriteLine("{0}/{1}/{2}", month, day, year);
        }
    }
}
