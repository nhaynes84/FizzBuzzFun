using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzServices.Strategies;

namespace FizzBuzz.Tests.Strategies
{
    [TestClass]
    public class FizzStrategyTests
    {
        [TestMethod]
        public void PrintRelationships_ValidNumber_WritesToConsole()
        {
            // arrange
            var strategy = new FizzStrategy();

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
