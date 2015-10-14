using FizzBuzzServices.Strategies.Interfaces;
using System;

namespace FizzBuzzServices.Strategies
{
    public class FizzBuzzStrategy : INumberStrategy
    {
        /// <summary>
        /// This is the FizzBuzz specific print method.
        /// </summary>
        /// <param name="number"></param>
        public void PrintRelationships(int number)
        {
            Console.Write("{0} - Fizz & Buzz!! \n", number);
        }
    }
}
