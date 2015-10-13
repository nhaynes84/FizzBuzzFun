using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Models;
using FizzBuzzServices.Strategies;
using FizzBuzzServices.Strategies.Interfaces;
using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Strategies
{
    public class NumberContext
    {
        public Dictionary<CriteriaType, Dictionary<IMatchCriteria, INumberStrategy>> Strategies;

        public NumberContext()
        {
            // Initializing and building out Strategy dictionary for contextual reference.
            // Nested a dictionary as a value to determine if a number meets criteria.
            Strategies = new Dictionary<CriteriaType, Dictionary<IMatchCriteria, INumberStrategy>>();

            Strategies.Add(CriteriaType.None, new Dictionary<IMatchCriteria, INumberStrategy> 
            { 
                {
                    new NoMatch(), new NoneOfTheAboveStrategy()
                }
            });
            Strategies.Add(CriteriaType.FizzBuzz, new Dictionary<IMatchCriteria, INumberStrategy> 
            { 
                {
                    new FizzBuzz(), new FizzBuzzStrategy()
                }
            });
            Strategies.Add(CriteriaType.Fizz, new Dictionary<IMatchCriteria, INumberStrategy> 
            { 
                {
                    new Fizz(), new FizzStrategy()
                }
            });
            Strategies.Add(CriteriaType.Buzz, new Dictionary<IMatchCriteria, INumberStrategy> 
            { 
                {
                    new Buzz(), new BuzzStrategy()
                }
            });
        }

        /// <summary>
        /// Takes in an Enum type to determine which strategy is needed
        /// and then calls the appropriate method.
        /// </summary>
        /// <param name="type"></param>
        public void PrintRelationships(int number, CriteriaType type)
        {
            Strategies[type].Values.SingleOrDefault().PrintRelationships(number);
        }
    }
}
