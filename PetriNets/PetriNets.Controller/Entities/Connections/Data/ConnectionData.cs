using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriNets.Controller.Entities
{
    public class ConnectionData
    {
        public Place? Place { get; private set; }
        public Transition? Transition { get; private set; }
        public int Weight { get; private set; } = 1;

        public ConnectionData(Place? place, Transition? transition, int weight = 1)
        {
            Place = place;
            Transition = transition;
            Weight = weight < 1 ? 1 : weight;
        }
    }
}
