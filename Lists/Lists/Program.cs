using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = { 10.99, 20.49, 15.75 };
            string[] artikelen = { "Pen", "Notitieboek", "Markeerstift" };
            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier { Naam = "Jan", Review = "Goed product" };
            formulieren[1] = new Formulier { Naam = "Anna", Review = "Zeer tevreden" };

            
            Console.WriteLine("Prijzen en Artikelen:");
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine($"Artikel: {artikelen[i]}, Prijs: {prijzen[i]:C}");
            }

            
            Console.WriteLine("\nFormulier Reviews:");
            foreach (var formulier in formulieren)
            {
                Console.WriteLine($"Naam: {formulier.Naam}, Review: {formulier.Review}");
            }

            string[] characters = { "Pac-Man", "Samus", "Crash Bandicoot", "Spyro the Dragon", "Donkey Kong", "Mario", "Luigi", "Astro", "Solid Snake", "Master Chief", "Kratos", "Sonic the Hedgehog", "Link" };
            List<string> characterList = new List<string> { "Lara Croft" };

            foreach (var character in characters)
            {
                characterList.Add(character);
            }

            Console.WriteLine("\nCharacters in List:");
            foreach (var character in characterList)
            {
                Console.WriteLine(character);
            }

            
            List<double> reviewsList = new List<double> { 4.5, 3.7, 5.0, 342.97, 1.2 };
            Console.WriteLine("\nReviews List:");
            foreach (var review in reviewsList) Console.WriteLine(review);

            reviewsList.Remove(342.97); 
            reviewsList.RemoveAt(0);    
            Console.WriteLine("\nReviews List after removal:");
            foreach (var review in reviewsList) Console.WriteLine(review);

            
            List<Pickup> pickups = new List<Pickup>();
            for (int i = 0; i < 5; i++)
            {
                pickups.Add(new Pickup { Name = $"Pickup-{i + 1}", Collected = false });
            }

            Console.WriteLine("\nPickups verzamelen:");
            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                pickups[i].Collected = true;
                pickups.RemoveAt(i);
                Console.WriteLine($"Pickup {i + 1} verzameld.");
            }

           
            List<Mob> mobs = new List<Mob>
            {
                new Mob { Name = "Mob-1", HP = 10 },
                new Mob { Name = "Mob-2", HP = 15 },
                new Mob { Name = "Mob-3", HP = 20 }
            };

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                foreach (var mob in mobs)
                {
                    if (random.Next(0, 100) < 30)
                    {
                        mob.TakeDamage(1);
                    }
                }
            }

            var defeatedMobs = mobs.Where(m => m.IsDead);
            Console.WriteLine("\nDefeated Mobs:");
            foreach (var mob in defeatedMobs)
            {
                Console.WriteLine($"{mob.Name} is verslagen!");
            }
        }
    }

    class Formulier
    {
        public string Naam { get; set; }
        public string Review { get; set; }
    }

    class Pickup
    {
        public string Name { get; set; }
        public bool Collected { get; set; }
    }

    class Mob
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public bool IsDead { get; set; }

        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP <= 0) IsDead = true;
        }
    }
}
