using FizzBuzzServices.Strategies.Interfaces;
using System;

namespace FizzBuzzServices.Strategies
{
    public class FizzBuzzStrategy : INumberStrategy
    {
        public void PrintRelationships(int number)
        {
            Console.Write("{0} - Fizz & Buzz!! \n", number);
        }
    }
}
