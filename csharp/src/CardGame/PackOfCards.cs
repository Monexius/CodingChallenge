using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        public int Count { get; set; }
        public List<Card> deck { get; set; } // collection cards

        int IReadOnlyCollection<ICard>.Count => deck.Count();

        public PackOfCards() // Constructor
        {

        }

        public void Shuffle()
        {
            deck = deck.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public IEnumerator<ICard> GetEnumerator() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
        public ICard TakeCardFromTopOfPack() //Unfinished, the interface returns the correct card but was not able to manipulate it to eventually remove it
        {
            
            if (deck.Count > 0)
            {
                Card card = new Card();
                card.Suit = deck[deck.Count - 1].Suit; //identify the last card
                card.Value = deck[deck.Count - 1].Value;
                deck.RemoveAt(deck.Count - 1); // remove the last card
                return card;
            }
            else
            {
                Debug.WriteLine("Cannot remove any more cards");
                Card card = new Card();
                return card;
            }
            
        }
    }
}
