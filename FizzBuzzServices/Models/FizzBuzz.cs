using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class FizzBuzz : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.FizzBuzz; } }

        /// <summary>
        /// Determines inf the current number matches the criteria
        /// and returns a bool to indicate
        /// </summary>
        /// <param name="thisNumber"></param>
        /// <returns></returns>
        public bool IAmThisNumber(int thisNumber)
        {
            return ((thisNumber % 3) == 0 
                && ((thisNumber % 5) == 0));
        }
    }
}
