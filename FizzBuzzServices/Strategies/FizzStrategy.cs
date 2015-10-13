using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Strategies.Interfaces;

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
