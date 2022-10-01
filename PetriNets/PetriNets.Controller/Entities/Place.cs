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

        public Place(int id, int tokens) : base(id)
        {
            Tokens = tokens;
        }

        public void ConsumeToken(int quantity)
        {
            if (quantity > Tokens)
                throw new InvalidOperationException($"Erro ao consumir marcas. Valor maior que o disponível de {Tokens}");

            Tokens -= quantity;
        }

        public void ConsumeAllTokens() => ConsumeToken(Tokens);

        public void ProduceToken(int quantity)
        {
            Tokens += quantity;
        }
    }
}
