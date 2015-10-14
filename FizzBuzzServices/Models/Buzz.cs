using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class Buzz : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.Buzz; } }

        /// <summary>
        /// Determines if the current number matches the criteria
        /// and returns a bool to indicate
        /// </summary>
        /// <param name="thisNumber"></param>
        /// <returns></returns>
        public bool IAmThisNumber(int thisNumber)
        {
            return ((thisNumber % 5) == 0);
        }
    }
}
