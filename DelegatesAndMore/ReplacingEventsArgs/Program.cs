using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReplacingEventsArgs
{
    
    public enum CowState
    {
        Awake, Sleeping, Dead
    }

    class CowEventsArgs : EventArgs
    {
        public CowState CurrentState { get; private set; }
        public CowEventsArgs(CowState currentState)
        {
            CurrentState = currentState;
        }
    }

    class Cow
    {
        public string Name { get; set; }
        public event EventHandler<CowEventsArgs> Moo;
        public void CowChecker()
        {
            Moo?.Invoke(this, new CowEventsArgs(CowState.Awake));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cow a = new Cow { Name = "Leah" };
            a.Moo += lol;
            Cow b = new Cow { Name = "Olga" };
            b.Moo += lol;

            Cow rndCowd = new Random().Next() % 2 == 0 ? a : b;
            a.CowChecker();
            Console.ReadLine();

        }
        static void lol(object sender, CowEventsArgs e)
        {
            Cow c = sender as Cow;
            Console.WriteLine($"Lol.... {c.Name} farted");
            switch (e.CurrentState)
            {
                case CowState.Awake:
                    Console.WriteLine("Hello?");
                    break;
                case CowState.Sleeping:
                    Console.WriteLine("Get Up!");
                    break;
                case CowState.Dead:
                    Console.WriteLine("Food   :)");
                    break;
            }
                
        }
    }
}
