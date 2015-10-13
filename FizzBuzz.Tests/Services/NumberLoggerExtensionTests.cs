using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzServices.Services;
using FizzBuzzServices.Models;

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
