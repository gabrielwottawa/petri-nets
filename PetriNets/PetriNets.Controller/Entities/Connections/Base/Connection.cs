namespace PetriNets.Controller.Entities
{
    public abstract class Connection
    {
        public Place? Place { get; private set; }

        public Transition? Transition { get; private set; }

        public int Weight { get; private set; } = 1;

        public ConnectionDirection Direction { get; private set; }

        public Connection(ConnectionData data)
        {
            Place = data.Place;
            Transition = data.Transition;
            Weight = data.Weight;
            Direction = data.Direction;
        }
    }
}
