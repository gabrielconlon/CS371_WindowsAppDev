using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX03_02
{
    class ReserveTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Flight number to book: ");
            string name = Console.ReadLine();

            AirlineReservation FlyRight = new AirlineReservation(name);

            int openseats = 1;

            while(openseats != 0)
                openseats = FlyRight.AssignSeat();

            Console.WriteLine("All seats have been filled, Next flight is in 3 hours.");
        }
    }
}
