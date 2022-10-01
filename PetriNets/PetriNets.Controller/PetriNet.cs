using PetriNets.Controller.Entities;

namespace PetriNets.Controller
{
    public class PetriNet
    {
        public List<Place> Places { get; set; } = new();
        public List<Transition> Transitions { get; set; } = new();
        public List<Connection> Connections { get; set; } = new();

        public bool CreatePlace(int id, int qtyTokens = 0)
        {
            if (GetPlace(id) != null)
                return false;

            var place = new Place(id);
            Places.Add(place);
            return true;
        }

        public Place? GetPlace(int id) => Places.Where(el => el.Id == id).FirstOrDefault();

        public bool RemovePlace(int id)
        {
            var place = GetPlace(id);
            if (place == null)
                return false;

            Places.Remove(place);
            return true;
        }

        public bool CreateTransition(int id)
        {
            if (GetTransition(id) != null)
                return false;

            var transition = new Transition(id);
            Transitions.Add(transition);
            return true;
        }

        public Transition? GetTransition(int id) => Transitions.Where(el => el.Id == id).FirstOrDefault();

        public bool RemoveTransition(int id)
        {
            var transition = GetTransition(id);
            if (transition == null)
                return false;

            Transitions.Remove(transition);
            return true;
        }

        public bool CreateConnection(Place place, Transition transition, int weight, ConnectionType connectionType)
        {
            var data = new ConnectionData(place, transition, weight);
            var connection = ConnectionFactory.Create(connectionType, data);

            if (connection != null)
                Connections.Add(connection);
            return true;
        }

        public bool RemoveConnection(Place place, Transition transition)
        {
            var connection = GetConnection(place, transition);
            if (connection == null)
                return false;

            Connections.Remove(connection);
            return true;
        }

        public Connection? GetConnection(Place place, Transition transition) => Connections.Where(el => el.Place?.Id == place.Id && el.Transition?.Id == transition.Id).FirstOrDefault();

        public Place? GetConnectionPlace(Connection connection)
        {
            return null;
        }

        public Transition? GetConnectionTransition(Connection connection)
        {
            return null;
        }

        public List<Connection> GetEntryConnections(int id)
        {
            return new List<Connection>();
        }

        public List<Connection> GetExitConnections(int id)
        {
            return new List<Connection>();
        }

        public void AddTokens(int qty, Place place)
        {

        }

        public bool RemoveTokenFromPlace(Token token, Place place)
        {
            return false;
        }

        public void ClearPlace(Place place)
        {

        }
    }
}
