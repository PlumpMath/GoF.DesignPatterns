using System;
using Observer.Model;
using Observer.Tracker;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var baby = new Baby
            {
                IsHungry = false,
                Name = "Little Doug"
            };
            var mother = new Mother();

            var unsubscriber = baby.Subscribe(mother);

            Random random = new Random();
            for (int i = 1; i <= 10; i++)
                baby.IsHungry = (random.Next(0, i) > 0);

            unsubscriber.Dispose();

            Console.ReadKey();
        }
    }
}
