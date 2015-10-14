using FizzBuzzServices.Services;
using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1.) Initialize our number identifier
            var numberIdentifier = new NumberIdentifier();

            // 2.) Iterate through all the numbers in a given range.
            for (int i = 1; i <= 100; i++)
            {
                // 3.) Using the LogNumber extension method to output to the console app and
                // calling our number identifier to resolve the type: Fizz, Buzz, FizzBuzz or None.
                i.LogNumber(numberIdentifier.IdentifyNumberType(i));

                Console.ReadKey();
            }
        }
    }
}
