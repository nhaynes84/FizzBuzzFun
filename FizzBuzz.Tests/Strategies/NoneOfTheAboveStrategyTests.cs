using FizzBuzzServices.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Tests.Strategies
{
    [TestClass]
    public class NoneOfTheAboveStrategyTests
    {
        [TestMethod]
        public void PrintRelationships_ValidNumber_WritesToConsole()
        {
            // arrange
            var strategy = new NoneOfTheAboveStrategy();

            try 
	        {
                // act
                strategy.PrintRelationships(0);	
	        }
	        catch (Exception ex)
	        {
                // assert .. all we can do is explicitly fail if this code gets hit.
	        	Assert.Fail("Expected no exception and got this", ex);
	        }
        }
    }
}
