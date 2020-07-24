using System;
using System.Collections.Generic;

namespace EventsDictionary
{
    class CowWithManyEvents
    {
        //Each Event takes 4byte... to much space
        public event EventHandler BeginMoo;
        public event EventHandler Moo;
        public event EventHandler EndMoo;
        public event EventHandler BeginWalk;
        public event EventHandler Walking;
        public event EventHandler EndWalk;
        public event EventHandler BeginSleep;
        public event EventHandler Sleep;
        public event EventHandler EndSleep;

        string beginmoostr = "Begin Moo";
        string mooing = "Moo";
        string endMooing = "End Moo";
        ////................. 
        ///...................
    }
    class ACowThatDealsWithIt
    {
        /// <summary>
        /// Dealing with many events
        /// A better way to store events subscribers in the memmory and get them on demand
        /// The code exist once in the memmory and all cows can use
        /// </summary>

        // A dictionary with a string key and an EventHandler value will hold all the events
        private Dictionary<string, EventHandler> subscribers =
            new Dictionary<string, EventHandler>();

        //Creating A example Key
        private string BeginMooKey = "Begin moo";
        public event EventHandler Cowing
        {
            add
            {
                ////    If the event already exsit add it again to the dictionary
                
                //if (subscribers.ContainsKey(BeginMooKey))
                //    subscribers[BeginMooKey] += value;
                //else
                //    subscribers.Add(BeginMooKey, value);     // Else Add it

                AddSubscriber(BeginMooKey, value);
            }
            remove
            {
                ////    If it doesnt exist return nothing
                
                //if (!subscribers.ContainsKey(BeginMooKey))
                //    return;

                ////    Else remove it from the dictionary
                
                //subscribers[BeginMooKey] -= value;

                ////if its empty remove it
                
                //if (subscribers[BeginMooKey] == null)
                //    subscribers.Remove(BeginMooKey);
                RemoveSubscriber(BeginMooKey, value);
            }
        }
        #region Adding & Rermoving Methods

        void AddSubscriber(string key, EventHandler subscriber)
        {
            if (subscribers.ContainsKey(key))
                subscribers[BeginMooKey] += subscriber;
            else
                subscribers.Add(key, subscriber);
        }
        void RemoveSubscriber(string key, EventHandler subscriber)
        {
            if (!subscribers.ContainsKey(key))
                return;
            else
                subscribers[key] -= subscriber;
            if (subscribers[key] == null)
                subscribers.Remove(key);
        }

        #endregion
    }
}
class Program
{
    static void Main(string[] args)
    {
    }

}
