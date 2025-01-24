using System;
using System.Collections.Generic;

namespace PickupGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            
            List<Pickup> pickups = new List<Pickup>();

            for (int i = 1; i <= 5; i++)
            {
                pickups.Add(new Pickup($"Pickup {i}", i * 10));
            }

           
            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                if (pickups[i].Value < 30)
                {
                    Console.WriteLine($"Pickup {pickups[i].Name} opgepakt!");
                    pickups.RemoveAt(i);
                }
            }

            Console.WriteLine("\nOvergebleven pickups:");
            foreach (Pickup pickup in pickups)
            {
                Console.WriteLine($"{pickup.Name} met waarde {pickup.Value}");
            }
        }
    }

    class Pickup
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Pickup(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
