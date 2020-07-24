using System;

namespace CompilerImplentationAction
{
    class Cooing
    {
        //Creating a public Action field method
        public Action Mooing;

        //Creating a private Action field and an event Action
        //can only access Gooing Action threw the class
        //An event 
        public event Action Gooing;

        private Action fooing;
        //add & remove  in events
        public event Action Fooing
        {
            add
            {
                fooing += value;
                //fooing += value;          - can do more than once
                Console.WriteLine("adding");
            }
            remove
            {
                fooing -= value;
                Console.WriteLine("removing");
            }
        }
        public void PushCow()
        {

            //Fooing(); can't invoke the event - Fooing refers to code - 

            //Checking if there are objects in fooing
            if (fooing != null)
                fooing();
        }
    }


    //same as above... the compiler implements the Action automaticly when we use the event
    class CowFoo
    {
        public event Action Foo;

    }


    class Program
    {
        static void Main(string[] args)
        {
            Cooing c = new Cooing();
            c.Mooing();

            //c.Gooing();  Worng.. can't implement class event 

            c.Fooing += () => Console.WriteLine("Feeeeeeee");

            c.PushCow();
        }
    }
}
