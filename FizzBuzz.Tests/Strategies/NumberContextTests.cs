using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzServices.Strategies;
using FizzBuzzServices.Models;

namespace FizzBuzz.Tests.Strategies
{
    [TestClass]
    public class NumberContextTests
    {
        [TestMethod]
        public void PrintRelationships_ValidType_ReturnsSpecificMethod()
        {
            // arrange
            var context = new NumberContext();

            try
            {
                // act
                context.PrintRelationships(5, CriteriaType.Buzz);
            }
            catch (Exception ex)
            {
                Assert.Fail("This should never throw exceptions: ", ex);
            }
        }
    }
}
