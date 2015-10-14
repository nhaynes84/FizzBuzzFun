using FizzBuzzServices.Strategies.Interfaces;
using System;

namespace FizzBuzzServices.Strategies
{
    public class FizzStrategy : INumberStrategy
    {
        public void PrintRelationships(int number)
        {
            Console.Write("{0} - FIZZ \n", number);
        }
    }
}
