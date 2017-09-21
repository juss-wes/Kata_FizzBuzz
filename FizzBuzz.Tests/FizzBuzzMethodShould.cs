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
            var results = FizzBuzzLogic.FizzBuzz(numberOfRecords);

            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count() == numberOfRecords);
        }
    }
}
