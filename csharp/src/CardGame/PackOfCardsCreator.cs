using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public static List<Card> newDeck = new List<Card>();

        public PackOfCardsCreator()
        {

        }
        public static IPackOfCards Create() // create a new card for each of the values
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value val in Enum.GetValues(typeof(Value)))
                {
                    newDeck.Add(new Card(suit, val));
                }
            }

            PackOfCards pack = new PackOfCards(); //instanciate the deck
            pack.deck = newDeck;
            pack.Count = newDeck.Count;

            return pack;
        }
    }
}
