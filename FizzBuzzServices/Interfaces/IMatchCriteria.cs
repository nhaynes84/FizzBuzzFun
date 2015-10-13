using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzServices.Models;

namespace FizzBuzzServices.Interfaces
{
    public interface IMatchCriteria
    {
        bool IAmThisNumber(int thisNumber);
        CriteriaType CriteriaType { get;}
    }
}
