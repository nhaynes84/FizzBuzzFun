using FizzBuzzServices.Models;

namespace FizzBuzzServices.Interfaces
{
    public interface ICanIdentify
    {
        CriteriaType IdentifyNumberType(int number);
    }
}
