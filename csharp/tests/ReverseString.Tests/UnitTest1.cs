using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReversingTests
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            var reverse = new StringUtilities();

            //Act
            var result = reverse.Reverse("New String");

            //Assert
            Assert.AreEqual("gnirtS weN", result);
        }
    }
}
