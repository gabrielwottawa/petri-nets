using PetriNets.Controller.Entities;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace PetriNets.Controller
{
    public class PetriNet
    {
        public int CurrentCycle { get; private set; } = 0;
        public List<Place> Places { get; private set; } = new();
        public List<Transition> Transitions { get; private set; } = new();
        public List<Connection> Connections { get; private set; } = new();        

        public Dictionary<string, string> PlaceAndTransitionsGrid => getPlaceAndTransitions();

        public bool CreatePlace(string id, int qtyTokens = 0)
        {
            if (GetPlace(id) != null)
                return false;

            var place = new Place(id, qtyTokens);
            Places.Add(place);
            return true;
        }

        public Place? GetPlace(string id) => Places.Where(el => el.Id == id).FirstOrDefault();

        public bool RemovePlace(string id)
        {
            var place = GetPlace(id);
            if (place == null)
                return false;

            Places.Remove(place);
            return true;
        }

        public bool CreateTransition(string id)
        {
            if (GetTransition(id) != null)
                return false;

            var transition = new Transition(id);
            Transitions.Add(transition);
            return true;
        }

        public Transition? GetTransition(string id) => Transitions.Where(el => el.Id == id).FirstOrDefault();

        public bool RemoveTransition(string id)
        {
            var transition = GetTransition(id);
            if (transition == null)
                return false;

            Transitions.Remove(transition);
            return true;
        }

        public bool CreateConnection(Place place, Transition transition, int weight, ConnectionType connectionType, ConnectionDirection direction)
        {
            var data = new ConnectionData(place, transition, weight, direction);
            var connection = ConnectionFactory.Create(connectionType, data);

            if (connection != null)
            {
                Connections.Add(connection);
                insertTransitionConnection(transition, direction, connection);
                return true;
            }

            return false;
        }

        private static void insertTransitionConnection(Transition transition, ConnectionDirection direction, Connection connection)
        {
            switch (direction)
            {
                case ConnectionDirection.Input:
                    transition.InputConnections.Add(connection);
                    break;

                case ConnectionDirection.Output:
                    transition.OutputConnections.Add(connection);
                    break;
            }
        }

        public bool RemoveConnection(Place place, Transition transition, ConnectionDirection direction)
        {
            var connection = GetConnection(place, transition);
            if (connection == null)
                return false;

            Connections.Remove(connection);
            removeTransitionConnection(transition, direction, connection);
            return true;
        }

        private static void removeTransitionConnection(Transition transition, ConnectionDirection direction, Connection connection)
        {
            switch (direction)
            {
                case ConnectionDirection.Input:
                    transition.InputConnections.Remove(connection);
                    break;

                case ConnectionDirection.Output:
                    transition.OutputConnections.Remove(connection);
                    break;
            }
        }

        public Connection? GetConnection(Place place, Transition transition) => Connections.Where(el => el.Place?.Id == place.Id && el.Transition?.Id == transition.Id).FirstOrDefault();

        public Place? GetConnectionPlace(Connection connection) => connection.Place;

        public Transition? GetConnectionTransition(Connection connection) => connection.Transition;

        public List<Connection> GetEntryConnections(string id) => GetTransition(id)?.InputConnections ?? new();

        public List<Connection> GetExitConnections(string id) => GetTransition(id)?.OutputConnections ?? new();

        public bool AddTokens(int qty, string id)
        {
            var netPlace = GetPlace(id);
            if (netPlace == null)
                return false;

            netPlace.ProduceToken(qty);
            return true;
        }

        public bool RemoveTokenFromPlace(int qty, string id)
        {
            var netPlace = GetPlace(id);
            if (netPlace == null)
                return false;

            netPlace.ConsumeToken(qty);
            return true;
        }


        public void ClearPlace(string id)
        {
            var place = GetPlace(id);
            if (place != null)
                place.ConsumeAllTokens();
        }

        public int CountTokens(string id)
        {
            var place = GetPlace(id);
            if (place != null)
                return place.Tokens;

            return 0;
        }

        public bool GetStatusTransition(string id)
        {
            var transition = GetTransition(id);
            if (transition != null)
                return transition.IsEnabled;

            return false;
        }

        public bool ExecuteCycle()
        {
            var transitions = Transitions.Where(el => el.IsEnabled).ToList();

            if (!transitions.Any())
                return false;

            foreach (var transition in transitions)
            {
                while (transition.IsEnabled)                                    
                    transition.ExecuteTransition();                
            }

            CurrentCycle++;
            return true;
        }

        private Dictionary<string, string> getPlaceAndTransitions()
        {
            var places = Places.ToDictionary(el => $"L{el.Id}", el => $"{el.Tokens}");
            var transitions = Transitions.ToDictionary(el => $"T{el.Id}", el => el.IsEnabled ? "S" : "N");

            return places.Concat(transitions).ToDictionary(el => el.Key, el => el.Value);
        }

        public string GetConnectionsInfo()
        {
            var builder = new StringBuilder();
            foreach (var connection in Connections)
                builder.AppendLine(connection?.ToString() ?? "");

            return builder.ToString();
        }

        public void LoadNetByFile(List<Place> places, List<Transition> transitions, List<Connection> connections)
        {
            Places = places;
            Transitions = transitions;
            Connections = connections;
        }
    }
}
