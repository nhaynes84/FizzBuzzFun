using FizzBuzzServices.Models;
using FizzBuzzServices.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Tests.Services
{
    [TestClass]
    public class NumberLoggerExtensionTests
    {
        public void PrintRelationships_ValidParams_NoExceptions()
        {
            // arrange
            var number = 5;

            try
            {
                // act
                number.LogNumber(CriteriaType.None);
            }
            catch (Exception ex)
            {
                // arrange
                Assert.Fail("This should never throw an exception: ", ex);
            }
        }
    }
}
