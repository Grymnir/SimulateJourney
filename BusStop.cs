using System;
using System.Collections.Generic;

namespace SimulateJourney
{
    public class BusStop
    {
        public Queue<Passenger> waiting = new Queue<Passenger>();

        public void Arrive(Passenger passenger)
        {
            waiting.Enqueue(passenger);
            Console.WriteLine($"{passenger} queuing at the bus stop");
        }
        public void BusArrive(Bus bus)
        {
            Console.WriteLine("\r\nBus arrive at bus stop to load passengers");
            while (bus.Space > 0 && waiting.Count > 0)
            {
                Passenger passenger = waiting.Dequeue();
                bus.Load(passenger);
            }
        }
    }
}