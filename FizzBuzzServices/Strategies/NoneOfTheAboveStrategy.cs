using FizzBuzzServices.Strategies.Interfaces;
using System;

namespace FizzBuzzServices.Strategies
{
    public class NoneOfTheAboveStrategy : INumberStrategy
    {
        /// <summary>
        /// If the number doesn't match our other strategies then
        /// this is the print method that gets called. Kind of NullObject pattern.
        /// </summary>
        public void PrintRelationships(int number)
        {
            Console.WriteLine("{0} - Nada", number);
        }
    }
}
