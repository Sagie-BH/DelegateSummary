using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndActions
{
    class DoItNowCompileItGood
    {
        class WhatTheCompilierDoes
        {
            public int i;
            public void LambdaMethodGenerated()
            {
                i++;
            }
        }
        static Action GiveMeYourAction()
        {
            return new Action(new WhatTheCompilierDoes().LambdaMethodGenerated);
        }

        static void Main(string[] args)
        {
            ClosuresDoIt();

            Action a = GiveMeAction();
            a(); // i value in a is 0   -   The compiler makes a class for a, i is an a class property

            //Invoking the method on a different class ("b")
            Action b = GiveMeAction();
            b(); // a.i = 0 , b.i = 0; 
            a(); // a.i = 1 , b.i = 0;

            Action c = GiveMeYourAction();
            c();
        }

        static Action GiveMeAction()
        {
            int i = 0;

            //Lambda Shortcut
            //The compilier creates a class and a method that advances i by 1
            //and know to return an Action method
            //Exampale
            //          return new Action(() => i++;
            return () => i++;
        }

        static void ClosuresDoIt()
        {
            Action doIt = DoItMethod();
            doIt();
            doIt();
            doIt();
        }
        static Action DoItMethod()
        {
            //Creating a Action list (must be declare) =>  Action reAction; => No! No!

            Action reAction = null;

            int i = 0;

            reAction += () => { Console.WriteLine("First reAction Method" + i++); };

            reAction += () => { Console.WriteLine("Second reAction Method" + i++); };

            return reAction;
        }
       
    }
}
