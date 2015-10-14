using FizzBuzzServices.Models;

namespace FizzBuzzServices.Interfaces
{
    public interface IMatchCriteria
    {
        bool IAmThisNumber(int thisNumber);
        CriteriaType CriteriaType { get;}
    }
}
