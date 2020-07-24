using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerProject
{
    class Cow
    {
        public string Name { get; set; }

        //The EventHadler takes in an object and EventArgs
        public event EventHandler Moo;
        public void BeTrippedOver()
        {
            //if (Moo != null)
            //    //takes in this object(Cow), And No Addindg Information (Empty)
            //    Moo(this, EventArgs.Empty);

            // Same thing - if(?) Moo() not null
            Moo?.Invoke(this, EventArgs.Empty);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cow a = new Cow { Name = "Leah" };
            //Adding Cow a to lol
            a.Moo += lol;
            Cow b = new Cow { Name = "Olga" };
            //Adding Cow b to lol
            b.Moo += lol;

            
            //Getting a random cow     a / b
            //Cow rndCow = new Cow();
            //Random rnd = new Random();
            //if (rnd.Next() % 2 == 0)
            //    rndCow = a;
            //else
            //    rndCow = b;

            //Same thing as above
            // ? = if       : = else 

            Cow rndCowd = new Random().Next() % 2 == 0 ? a : b;

            rndCowd.BeTrippedOver();
            Console.ReadLine();
        }
        static void lol(object sender, EventArgs e)
        {
            Cow c = sender as Cow;
            Console.WriteLine($"Lol.... {c.Name} farted");

        }
    }
}
