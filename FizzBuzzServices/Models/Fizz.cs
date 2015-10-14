using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class Fizz : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.Fizz; } }

        public bool IAmThisNumber(int thisNumber)
        {
            return ((thisNumber % 3) == 0);
        }
    }
}
