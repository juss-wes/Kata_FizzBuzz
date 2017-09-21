using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzMethodShould
    {
        [TestMethod]
        public void ReturnCorrectNumberOfResults()
        {
            var numberOfRecords = 100;
            var collection = FizzBuzzLogic.FizzBuzz(numberOfRecords);

            Assert.IsNotNull(collection);
            Assert.IsTrue(collection.Count() == numberOfRecords);
        }
    }
}
