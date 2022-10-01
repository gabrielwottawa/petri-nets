using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriNets.Controller.Entities
{
    public class Place : Entity
    {
        public int Tokens { get; set; }

        public Place(int id) : base(id)
        {
        }

        public void ConsumeToken(int quantity)
        {

        }
    }
}
