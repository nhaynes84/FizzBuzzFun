using FizzBuzzServices.Strategies.Interfaces;
using System;

namespace FizzBuzzServices.Strategies
{
    public class FizzStrategy : INumberStrategy
    {
        /// <summary>
        /// This is the Fizz specific print method.
        /// </summary>
        /// <param name="number"></param>
        public void PrintRelationships(int number)
        {
            Console.Write("{0} - FIZZ \n", number);
        }
    }
}
