using FizzBuzzServices.Strategies.Interfaces;
using System;

namespace FizzBuzzServices.Strategies
{
    public class BuzzStrategy : INumberStrategy
    {
        public void PrintRelationships(int number)
        {
            Console.Write("{0} - BUZZ \n", number);
        }
    }
}
