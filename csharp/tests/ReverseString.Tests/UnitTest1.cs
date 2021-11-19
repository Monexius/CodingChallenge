using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReversingTests
    {
        [Test] // Check when used normally
        public void TestMethod1()
        {
            //Arrange
            var reverse = new StringUtilities();

            //Act
            var result = reverse.Reverse("New String");

            //Assert
            Assert.AreEqual("gnirtS weN", result);
        }

        [Test] // Check when used with no input
        public void TestMethod2()
        {
            //Arrange
            var reverse = new StringUtilities();

            //Act
            var result = reverse.Reverse("");

            //Assert
            Assert.AreEqual("", result);
        }
    }
}
