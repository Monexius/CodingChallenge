using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class CardGame
    {
        [Test]
        public void TestMethod1() // check that the starting ammount of cards equates to 52 and remove 1
        {
            //Arrange
            var reverse = new Deck();

            //Act
            var result = Deck.Begin();

            //Assert
            Assert.AreEqual(51, result);
        }

        [Test]
        public void TestMinimumDeck() // Not exactly useful test however, deck does not go below 0
        {
            //Arrange
            var pack = PackOfCardsCreator.Create();

            //Act
            for(int i = pack.Count; i > 0; i--) //Removes all available cards and does not go below 0
            {
                pack.TakeCardFromTopOfPack();
            }
            var result = pack.Count;

            //Assert
            Assert.AreEqual(0, result );
        }

        //Could add another test to validate the sets and values of cards.
    }
}
