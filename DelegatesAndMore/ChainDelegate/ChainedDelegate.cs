using System;

namespace ChainDelegate
{
    partial class ActionAndFunc
    {
        delegate void MeDelegate();

        class ChainedDelegate
        {
            static void ChainingDelegates()
            {
                MeDelegate meDelegate = One;
                //Creates a delegates that points to "One" Method

                //Combining another delegate
                meDelegate += Two;
                //meDelegate = (MeDelegate)Delegate.Combine(meDelegate, new MeDelegate(Two));
               
                
                meDelegate += Three;
                meDelegate += One;
                meDelegate();
                //Removes the first "One" method from the end
                meDelegate -= One;

            }
            static void One() { Console.WriteLine("One"); }
            static void Two() { Console.WriteLine("Two"); }
            static void Three() { Console.WriteLine("Three"); }
        }
    }
}
