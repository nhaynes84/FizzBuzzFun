using FizzBuzzServices.Models;
using FizzBuzzServices.Strategies;

namespace FizzBuzzServices.Services
{
    public static class NumberLoggerExtension
    {
        /// <summary>
        /// Takes in a number and an Enum type, Fizz, Buzz, FizzBuzz or None
        /// and writes the appropriate output to the console app. This is a static class
        /// so it wouldn't be a bad idea to write an adapter for it (DI and testing purposes)
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        public static void LogNumber(this int number, CriteriaType type)
        {
            // calling our context to resolve our number type and return the correct Print method.
            var context = new NumberContext();         
            context.PrintRelationships(number, type);
        }
    }
}