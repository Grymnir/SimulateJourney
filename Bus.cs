using System;
using System.Collections.Generic;

namespace SimulateJourney
{
    public class Bus
    {
        public const int Capacity = 5;
        public int Space { get => Capacity - passengers.Count; }
        private List<Passenger> passengers = new List<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            passengers.Add(passenger);
            Console.WriteLine($"{passenger} got on the bus");
            return true;
        }

        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (passengers.Count == 0)
                return;

            List<Passenger> goingOff = passengers.FindAll(x => x.Destination == place);
            passengers.RemoveAll(person => person.Destination == place);

            foreach (Passenger passenger in goingOff)
            {
                Console.WriteLine($"{passenger} is getting off");
            }
            Console.WriteLine($"{passengers.Count} is getting off");

            /*
            LinkedListNode<Passenger> currentNode = passengers.First;

            //Code to remove all passengers who are getting off here from the linked list
            do
            {
                LinkedListNode<Passenger> nextNode = currentNode.Next;
                if (currentNode.Value.Destination == place)
                {
                    Console.WriteLine($"{currentNode.Value} is getting off");
                    passengers.Remove(currentNode);
                }
                currentNode = nextNode;
            } while (currentNode != null);
            Console.WriteLine($"{passengers.Count} people left on the bus");
            */
        }
    }
}