using FizzBuzzServices.Models;
using FizzBuzzServices.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests.Services
{
    [TestClass]
    public class NumberIdentifierTests
    {
        [TestMethod]
        public void IdentifyNumberType_ValidBuzz_ReturnsType()
        {
            // arrange
            var numberIdentifier = new NumberIdentifier();

            // act
            var type = numberIdentifier.IdentifyNumberType(5);

            // assert
            Assert.AreEqual(CriteriaType.Buzz, type);
        }

        [TestMethod]
        public void IdentifyNumberType_ValidFizz_ReturnsType()
        {
            // arrange
            var numberIdentifier = new NumberIdentifier();

            // act
            var type = numberIdentifier.IdentifyNumberType(3);

            // assert
            Assert.AreEqual(CriteriaType.Fizz, type);
        }

        [TestMethod]
        public void IdentifyNumberType_ValidFizzBuzz_ReturnsType()
        {
            // arrange
            var numberIdentifier = new NumberIdentifier();

            // act
            var type = numberIdentifier.IdentifyNumberType(15);

            // assert
            Assert.AreEqual(CriteriaType.FizzBuzz, type);
        }

        [TestMethod]
        public void IdentifyNumberType_ValidNoMatch_ReturnsType()
        {
            // arrange
            var numberIdentifier = new NumberIdentifier();

            // act
            var type = numberIdentifier.IdentifyNumberType(0);

            // assert
            Assert.AreEqual(CriteriaType.None, type);
        }
    }
}
