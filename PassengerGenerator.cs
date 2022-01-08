using System;

namespace SimulateJourney
{
    public class PassengerGenerator
    {
        private static int _count = 0;
        private static Random rnd = new Random();

        public static Passenger CreatePassenger()
        {
            string destination = rnd.Next(2) == 0 ? "Lancaster" : "Morecambe";
            return new Passenger($"Person {++_count}", destination);
        }
    }
}
