using FizzBuzzServices.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzServices.Tests.Models
{
    [TestClass]
    public class FizzTests
    {
        [TestMethod]
        public void IAmThisNumber_ValidFizz_ReturnsTrue()
        {
            // arrange
            var fizz = new Fizz();
            
            // act
            var answer = fizz.IAmThisNumber(3);

            // assert
            Assert.AreEqual(CriteriaType.Fizz, fizz.CriteriaType);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void IAmThisNumber_InvalidFizz_ReturnsFalse()
        {
            //arrange
            var fizz = new Fizz();

            // act
            var answer = fizz.IAmThisNumber(11);

            //assert
            Assert.IsFalse(answer);
        }
    }
}
