using System;

namespace SimulateJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            BusStop stop = new BusStop();
            Bus bus = new Bus();

            for (int i = 0; i < 6; i++)
                stop.Arrive(PassengerGenerator.CreatePassenger());

            stop.BusArrive(bus);
            bus.ArriveAt("Lancaster");
            bus.ArriveAt("Morecambe");
        }
    }
}
