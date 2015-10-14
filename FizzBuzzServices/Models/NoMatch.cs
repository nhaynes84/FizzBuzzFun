using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    // This class is mostly like the NullObject pattern except instead of a simple dummy object,
    // we have a method with logic in it.
    public class NoMatch : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.None; } }
        
        /// <summary>
        /// Determines if the current number matches the criteria
        /// and returns a bool to indicate
        /// </summary>
        /// <param name="thisNumber"></param>
        /// <returns></returns>
        public bool IAmThisNumber(int thisNumber)
        {
            // 1.) Evaluate if the number is 0 so it doesn't cause 
            //     false positives with our modulus operations
            if (thisNumber == 0)
            {
                return true;
            }

            // 2.) Probably not the best approach to inject dependencies here however the
            //     code to evaluate this non-zero number already exists so why not use it?
            if (new Fizz().IAmThisNumber(thisNumber) ||
                new Buzz().IAmThisNumber(thisNumber))
            {
                return false;
            }

            return true;
        }
    }
}
