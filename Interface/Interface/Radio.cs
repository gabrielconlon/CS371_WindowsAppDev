using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Radio : IPowered, ITunable
    {

        bool power;
        private double[] station;

        public Radio()
        {
            power = false;
            station = new double[100];
        }

        public void PowerOn()
        {
            power = true;
        }

        public double[] setStations
        {
            get
            {
                return station;
            }
            set { station = value; }
        }

        public void PowerOff()
        {
            power = false;
        }
    }
}
