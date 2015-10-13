using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class Buzz : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.Buzz; } }

        public bool IAmThisNumber(int thisNumber)
        {
            return ((thisNumber % 5) == 0);
        }
    }
}
