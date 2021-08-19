using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace AirlineReservation
{
    class FlightStore
    {
        private Flight[] flights;

        public Flight this[int index]
        {
            get
            {
                return flights[index];
            }
        }

        private BinaryFormatter formatter = new BinaryFormatter();
        public FlightStore(string[] flightnumbers)
        {
            flights = new Flight[flightnumbers.Length];
            int index = 0;
            foreach(string flightnumber in flightnumbers)
            {
                string filename = string.Format("Store{0}.bin", flightnumber);
                if (File.Exists(filename))
                {
                    using (FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        flights[index] = (Flight)formatter.Deserialize(reader);
                    }
                }
                else
                {
                    flights[index] = new Flight(flightnumber);
                }
                ++index;
            }
        }

        ~FlightStore()
        {
            foreach (var flight in flights)
            {
                string filename = string.Format("Store{0}.bin", flight.FlightNumber);
                using (FileStream writer = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    formatter.Serialize(writer, flight);
                }
            }
        }
    }
}
