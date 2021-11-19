using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }

        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            
        }

        public Card()
        {

        }

        public bool Equals(ICard other) => throw new NotImplementedException();
    }
}
