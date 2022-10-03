using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriNets.Controller.Entities
{
    public class Transition : Entity
    {
        public bool IsEnabled { get { return tokenIsEnabled(); } }

        public List<Connection> InputConnections = new();
        public List<Connection> OutputConnections = new();

        public Transition(string id) : base(id)
        {
        }

        public void ExecuteTransition()
        {
            foreach(var connection in InputConnections)
                connection.ConsumeTokens();

            foreach (var connection in OutputConnections)
                connection.Place?.ProduceToken(connection.Weight);
        }

        private bool tokenIsEnabled() => InputConnections.Any() && InputConnections.All(el => el.IsEnabled);
    }
}
