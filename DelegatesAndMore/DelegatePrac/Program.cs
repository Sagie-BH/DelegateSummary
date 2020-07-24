using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePrac
{
    class Program
    {

        //A delegate is a variable that holds information about a method

        // Delegte defines the signature (return type and parameters)

        //Defines a method that returns an int, and has one int as an input
        public delegate int Manipulate(int a);


        static void Main(string[] args)
        {
            var b = NormalMethod(2);

            //Creates an instance of the delegate
            var normalMethodDelegate = new Manipulate(NormalMethod);

            var normalResult = normalMethodDelegate(3);


            //Pass a delegate method as a variable
            var anotherResult = RunAnotheMethod(normalMethodDelegate, 4);

            //Anonymous method is a delegate() { } and it returns a delegate
            Manipulate anonymousMethodDelegate = delegate (int a) { return a * 2; };

            var anonymousResult = anonymousMethodDelegate(3);



            //Lambda expressions are anything with => and a left/right value
            //They can return a delegate (abling a method to be invoked)
            //or a Expression of a delegate(so it can be compiled and then executed)

            Manipulate lambdaDelegate = a => a * 2;
            var lambdaResult = lambdaDelegate(5);

            Manipulate anotherLambdaDelegate = (a) =>
            {
                var c = 2;
                return c * a * 2;           //Full function.....
            };

            //Nicer way to write a lambda
            Manipulate nicerLambdaDelegate = (a) => { return a * 2; };

        }

        /// <summary>
        /// Normal multiply method
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Returns twice the input</returns>
        public static int NormalMethod(int a)
        {
            return a * 2;
        }

        /// <summary>
        /// Accept a method (delegate) as an input
        /// </summary>
        /// <param name="theMethod"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int RunAnotheMethod(Manipulate theMethod, int a)
        {
            return theMethod(a);
        }

        //Cant Pass A Method Into Another Method
        //public static int CantPassAMethodIntoAnotheMethod(NormalMethod normalMethod)
        //{
        //    return 0;
        //}
    }
}
