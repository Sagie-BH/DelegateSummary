using System;

namespace ActionAddAndRemove
{
    /// <summary>
    /// Building the Add & Remove for Action delegate
    /// </summary>
    partial class ActionAndFunc
    {
        // Action and Func Are Delegates
        // We don't have to declare them before the class
        // Action returns Void
        // Func returns T value

        static void Action() // + Try Catch
        {
            //Chaining Methods as Action to del
            Action del = (Action)Moo + Exception + Goo;
            //Looping threw the del Delegate list with GetInvocationList()
            foreach (Action action in del.GetInvocationList())
            {
                //Trying the action List to catch exceptions
                try { action(); }

                //Helndaling the exception
                catch { }
            }
        }
        static void Moo() { Console.WriteLine("Moo"); }
        static void Exception() { throw new Exception("I'm Lazy... Don't judge me"); }
        static void Goo() { Console.WriteLine("Goo"); }

    }
}
