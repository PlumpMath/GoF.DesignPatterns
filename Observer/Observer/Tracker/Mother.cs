using System;
using Observer.Model;

namespace Observer.Tracker
{
    public class Mother : IObserver<Baby>
    {
        public void OnNext(Baby baby)
        {
            if (baby.IsHungry)
            {
                Console.WriteLine("{0} is hungry! Better prepare the meal.", baby.Name);
            }
            else
            {
                Console.WriteLine("Nothing wrong with my {0}.", baby.Name);
            }
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Oh noes! We got an error: {0}", error.Message);
        }

        public void OnCompleted()
        {
            Console.WriteLine("No more babies here.");
        }
    }
}
