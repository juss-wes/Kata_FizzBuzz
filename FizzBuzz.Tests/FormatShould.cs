using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FormatShould
    {
        [TestMethod]
        public void ReturnFizzGiven3()
        {
            var result = FizzBuzzLogic.Format(3);

            Assert.IsTrue(result == "Fizz");
        }

        [TestMethod]
        public void ReturnBuzzGiven5()
        {
            var result = FizzBuzzLogic.Format(5);

            Assert.IsTrue(result == "Buzz");
        }

        [TestMethod]
        public void ReturnFizzBuzzGiven15()
        {
            var result = FizzBuzzLogic.Format(15);

            Assert.IsTrue(result == "FizzBuzz");
        }

        [TestMethod]
        public void Return4Given4()
        {
            var result = FizzBuzzLogic.Format(4);

            Assert.IsTrue(result == "4");
        }

        [TestMethod]
        public void ReturnFizzGiven13()
        {
            var result = FizzBuzzLogic.Format(13);

            Assert.IsTrue(result == "Fizz");
        }
    }
}
