namespace SimulateJourney
{
    public class Passenger
    {
        public string Name { get; init; }
        public string Destination { get; init; }

        public Passenger(string name, string destination)
        {
            this.Destination = destination;
            this.Name = name;
        }
        public override string ToString() => $"{Name} to {Destination}";
    }
}
