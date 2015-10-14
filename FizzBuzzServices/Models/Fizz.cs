using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class Fizz : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.Fizz; } }

        /// <summary>
        /// Determines inf the current number matches the criteria
        /// and returns a bool to indicate
        /// </summary>
        /// <param name="thisNumber"></param>
        /// <returns></returns>
        public bool IAmThisNumber(int thisNumber)
        {
            return ((thisNumber % 3) == 0);
        }
    }
}
