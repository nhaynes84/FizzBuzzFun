using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Strategies.Interfaces;

namespace FizzBuzzServices.Strategies
{
    public class NoneOfTheAboveStrategy : INumberStrategy
    {
        /// <summary>
        /// If the number doesn't match our other strategies then
        /// this is the print method that gets called.
        /// </summary>
        public void PrintRelationships(int number)
        {
            Console.WriteLine("{0} - Nada", number);
        }
    }
}
