using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Interfaces;

namespace FizzBuzzServices.Models
{
    public class FizzBuzz : IMatchCriteria
    {
        public CriteriaType CriteriaType { get { return CriteriaType.FizzBuzz; } }

        public bool IAmThisNumber(int thisNumber)
        {
            return ((thisNumber % 3) == 0 
                && ((thisNumber % 5) == 0));
        }
    }
}
