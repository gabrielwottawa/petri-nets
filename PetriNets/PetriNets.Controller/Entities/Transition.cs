using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriNets.Controller.Entities
{
    public class Transition : Entity
    {
        public bool IsEnabled { get; set; }

        public Transition(int id) : base(id)
        {
        }        

        public void ExecuteTransition()
        {            
        }
    }
}
