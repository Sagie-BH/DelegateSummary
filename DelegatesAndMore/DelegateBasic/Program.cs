using System;

namespace DelegateBasic
{
    // A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.

    // Delegate declaration determines the methods that can be referenced by the delegate.
    // A delegate can refer to a method, which has the same signature as that of the delegate.
    delegate void MyDelegate();

    class Delegates
    {
        static void Main(string[] args)
        {

            //Invoking the Method directly
            Foo();
            //The object needs an argument to pass
            // MyDelegate myDelegate = new MyDelegate("argument");

            //The delegate passes the method and doesn't invoke it...that's why there is no "()"
            MyDelegate myDelegate = Foo;   //MyDelegate myDelegate = new MyDelegate(Foo);

            //the Delegate invokes the metohd
            myDelegate();  // =             myDelegate.Invoke();

            //Invoking The Method with a method that takes a delegate ("anyDelegate")
            InvokeMyDelegates(Fee);
            //      =
            InvokeMyDelegates(new MyDelegate(Foo));

            Console.ReadLine();
        }


        // Foo Method
        private static void Foo()
        {
            Console.WriteLine("Foo");
        }

        // Fee Method
        private static void Fee()
        {
            Console.WriteLine("Fee");
        }

        //A Method that invokes delegates
        static void InvokeMyDelegates(MyDelegate anyDelegate)
        {
            anyDelegate();
        }
    }
}
