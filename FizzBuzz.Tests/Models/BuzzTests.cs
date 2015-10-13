using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzServices.Models;

namespace FizzBuzzServices.Tests.Models
{
    [TestClass]
    public class BuzzTests
    {
        [TestMethod]
        public void IAmThisNumber_ValidBuzz_ReturnsTrue()
        {
            //arrange
            var buzz = new Buzz();
            
            // act
            var answer = buzz.IAmThisNumber(5);

            //assert
            Assert.AreEqual(CriteriaType.Buzz, buzz.CriteriaType);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void IAmThisNumber_InvalidBuzz_ReturnsFalse()
        {
            //arrange
            var buzz = new Buzz();

            // act
            var answer = buzz.IAmThisNumber(11);

            //assert
            Assert.AreEqual(CriteriaType.Buzz, buzz.CriteriaType);
            Assert.IsFalse(answer);
        }
    }
}
