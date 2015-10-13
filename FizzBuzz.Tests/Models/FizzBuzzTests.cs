using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzServices.Tests.Models
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void IAmThisNumber_ValidFizzBuzz_ReturnsTrue()
        {
            //arrange
            var fizzBuzz = new FizzBuzzServices.Models.FizzBuzz();
            
            // act
            var answer = fizzBuzz.IAmThisNumber(15);

            //assert
            Assert.AreEqual(FizzBuzzServices.Models.CriteriaType.FizzBuzz, fizzBuzz.CriteriaType);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void IAmThisNumber_InvalidFizzBuzz_ReturnsFalse()
        {
            //arrange
            var fizzBuzz = new FizzBuzzServices.Models.FizzBuzz();

            // act
            var answer = fizzBuzz.IAmThisNumber(11);

            //assert
            Assert.IsFalse(answer);
        }
    }
}
