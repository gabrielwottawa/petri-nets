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

        public Transition(int id) : base(id)
        {
        }

        public void ExecuteTransition()
        {
        }

        private bool tokenIsEnabled() => InputConnections.All(el => el.IsEnabled);
    }
}
