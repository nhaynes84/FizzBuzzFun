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
    public class NoMatchTests
    {
        [TestMethod]
        public void IAmThisNumber_ValidNoMatch_ReturnsTrue()
        {
            //arrange
            var none = new NoMatch();
            
            // act
            var answer = none.IAmThisNumber(0);

            //assert
            Assert.AreEqual(CriteriaType.None, none.CriteriaType);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void IAmThisNumber_InvalidNoMatch_ReturnsFalse()
        {
            //arrange
            var none = new NoMatch();

            // act
            var answer = none.IAmThisNumber(12);

            //assert
            Assert.IsFalse(answer);
        }
    }
}
