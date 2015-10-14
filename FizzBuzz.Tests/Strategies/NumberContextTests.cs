using FizzBuzzServices.Models;
using FizzBuzzServices.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
