using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class Deck
    {
        public static int maxCards { get; set; }

        public static int Begin()
        {
            var pack = PackOfCardsCreator.Create(); //Create the deck. the class inherits the PackOfCards object
            pack.TakeCardFromTopOfPack();
            pack.Shuffle();
            
            return pack.Count;
        }
    }
}
