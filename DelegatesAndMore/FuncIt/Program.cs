using System;

namespace FuncIt
{
    class FuncIt
    {
        //setting the boolian argument for the func delegate
        static bool AutoCreated(int num)
        {
            return num > 10;
        }
        static void AutoDelegateToFunc()
        {
            //Creates a delegate in the background that takes 1 int as argument
            //and returns bool acording to AutoCreated Method

            Func<int, bool> AutoFunc = AutoCreated;
            AutoFunc(99);
        }


        // All the above in short              :)
        static void Funk()
        {
            // Func<int, bool> sameFunc = delegate (int num) { return num > 5; };

            Func<int, bool> func = num => num > 10;

            Console.WriteLine(func(8));       //False
            Console.WriteLine(func(22));      //True
        }
    }
}
