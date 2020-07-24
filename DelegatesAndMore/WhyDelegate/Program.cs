using System;
using System.Collections.Generic;

namespace WhyDelegate
{
    class WhyDelegate
    {
        /// <summary>
        /// No Delegate Method
        /// The Code repeats itself
        /// </summary>
        static void NoDelegates()
        {
            int[] numbersArray = new[] { 1, 5, 2, 6, 22, 19, 88, 9, 7, 3 };

            IEnumerable<int> result = numbersArray;

            result = GetAllNumbersLessThaFive(numbersArray);
            foreach (int n in result)
                Console.WriteLine(n);

            result = GetAllNumbersBiggerThanTen(numbersArray);
            foreach (int n in result)
                Console.WriteLine(n);

            result = GetAllEvenNumbers(numbersArray);
            foreach (int n in result)
                Console.WriteLine(n);

        }
        static IEnumerable<int> GetAllNumbersLessThaFive(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
                if (number < 5)
                    yield return number;
        }
        static IEnumerable<int> GetAllEvenNumbers(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
                if (number % 2 == 0)
                    yield return number;
        }
        static IEnumerable<int> GetAllNumbersBiggerThanTen(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
                if (number > 10)
                    yield return number;
        }

        /// <summary>
        /// Using Delegates and booleans
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        delegate bool ProcessDelegate(int num);
        static bool LessThanFive(int n) { return n < 5; }
        static bool EvenNumbers(int n) { return n % 2 == 0; }
        static bool BiggetThanTen(int n) { return n > 10; }
        static void WithDelegates()
        {
            int[] numbersArray = new[] { 1, 5, 2, 6, 22, 19, 88, 9, 7, 3 };


            //The Method takes in an int array or list, and a int process conected to ProcessDelegate
            static IEnumerable<int> ProcessNumbers(IEnumerable<int> numbers, ProcessDelegate process)
            {
                foreach (int number in numbers)
                    //any process and any number
                    if (process(number))
                        yield return number;
            }
            ProcessNumbers(numbersArray, IsKAbubOk());


            IEnumerable<int> result = ProcessNumbers(numbersArray, BiggetThanTen);
            foreach (int a in result)
                Console.WriteLine(a);
            result = ProcessNumbers(numbersArray, EvenNumbers);
            foreach (int a in result)
                Console.WriteLine(a);
            result = ProcessNumbers(numbersArray, LessThanFive);
            foreach (int a in result)
                Console.WriteLine(a);


        }

        private static ProcessDelegate IsKAbubOk()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Another way without the bool - The system does the same thing in the background
        /// </summary>
        /// <param name="n"></param>
        delegate void AnyIntProcess(int n);


        static void ShorterWay()
        {
            int[] numbersArray = new[] { 1, 5, 2, 6, 22, 19, 88, 9, 7, 3 };

            static IEnumerable<int> BuildProcess(IEnumerable<int> numbers, ProcessDelegate process)
            {
                foreach (int number in numbers)
                    if (process(number))
                        yield return number;
            }



            //A Methods thats takes an int list and get all the numbers smaller than 5

            IEnumerable<int> LessThanFiveResult = BuildProcess(numbersArray, num => num < 5);
            foreach (int n in LessThanFiveResult)
                Console.WriteLine(n);


            IEnumerable<int> EvenResult = BuildProcess(numbersArray, num => num % 2 == 0);
            foreach (int n in EvenResult)
                Console.WriteLine(n);



            IEnumerable<int> BiggerThanTenResult = BuildProcess(numbersArray, num => num > 10);
            foreach (int n in BiggerThanTenResult)
                Console.WriteLine(n);


        }
    }
}
