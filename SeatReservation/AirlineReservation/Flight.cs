using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirlineReservation
{
    [Serializable]
    class Flight
    {
        private string flightNumber;

        public string FlightNumber { get { return flightNumber; } }

        private bool[] seats;

        public Flight(string number)
        {
            flightNumber = number;
            seats = new bool[10];
        }

        public enum Class {First, economy};

        public int AssignSeat(Class classType)
        {
            if (classType == Class.First)
            {
                for (int i = 0; i < 5; ++i)
                    if (!seats[i])
                        return i;
            }
            else if (classType == Class.economy)
            {
                for (int i = 5; i < 10; ++i)
                    if (!seats[i])
                        return i;
            }
            return -1;
        }

        public void SelectSeat(int seatnumber)
        {
            seats[seatnumber] = true;
        }
    }
}
