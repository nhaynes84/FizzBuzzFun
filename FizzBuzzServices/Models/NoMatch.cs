using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class NoMatch : IMatchCriteria
    {
        public bool IAmThisNumber(int thisNumber)
        {
            // evaluate if the number is 0 so it doesn't cause 
            // false positives with our modulus operations
            if (thisNumber == 0)
            {
                return true;
            }

            if (new Fizz().IAmThisNumber(thisNumber) ||
                new Buzz().IAmThisNumber(thisNumber))
            {
                return false;
            }

            return true;
        }

        public CriteriaType CriteriaType
        {
            get { return CriteriaType.None; }
        }
    }
}
