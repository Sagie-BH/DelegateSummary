using System;
using System.Collections.Generic;

namespace PredicateDelegate
{
    class Program
    {
        /// <summary>
        /// Predicate delegate takes one parameter and return a bool (false/true)
        /// </summary>
        /// <param name="Get Low"></param>
        static void Main(string[] args)
        {
            

            Predicate<int> isEven = IsEven;

            Console.WriteLine(isEven(298));

            Predicate<string> isLowIsLowIsLowIsLow = IsLowerCase;

            Console.WriteLine(isLowIsLowIsLowIsLow("Three, Six, Nine, DAMN SHE FINE!"));
            //Gotta Love The Shortcuts
            Predicate<int> isEvenInLess = num => num % 2 == 0;
            Console.WriteLine(isEvenInLess(20));

        }
        static bool IsEven(int num) => num % 2 == 0;

        static bool IsLowerCase(string txt) => txt.Equals(txt.ToLower());

        /// <summary>
        /// like Func with a boolean as a T result
        /// </summary>
        Func<int, bool> sameFunc = delegate (int num) { return num % 2 == 0; };
    }
}
