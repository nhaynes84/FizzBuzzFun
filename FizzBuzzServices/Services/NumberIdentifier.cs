using FizzBuzzServices.Interfaces;
using FizzBuzzServices.Models;
using FizzBuzzServices.Strategies;
using System.Linq;
namespace FizzBuzzServices.Services
{
    public class NumberIdentifier : ICanIdentify
    {
        /// <summary>
        /// This method determines which Enum type the current number belongs to.
        /// </summary>
        /// <param name="thisNumber"></param>
        /// <returns></returns>
        public CriteriaType IdentifyNumberType(int thisNumber)
        {
            var context = new NumberContext();
            
            foreach(var strategy in context.Strategies.OrderBy(x => x.Key))
            {
                // return the associated enum for this strategy if it is evaluated to be this type 
                if (strategy.Value.Keys.SingleOrDefault().IAmThisNumber(thisNumber))
                {
                    return strategy.Key;
                }
            }

            // if somehow it is none of the above then return None 
            // This should never get hit but it is best to handle it with a value.
            return CriteriaType.None;
        }
    }
}
