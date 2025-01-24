using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace FileIOExample
{
    class Program
    {
        
        static string saveFile = "welkomState.txt";

        static void Main(string[] args)
        {
            Run();
            RunProducten();
            RunEigen();
            Schrijven();
        }

        
        static void Run()
        {
            string welkomstTekst = "hello world";

           
            if (File.Exists(saveFile))
            {
                welkomstTekst = File.ReadAllText(saveFile);
            }

            while (true)
            {
                Console.WriteLine(welkomstTekst);
                Console.WriteLine("Type nieuwe welkomsttekst (of druk Enter om te herhalen):");

                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    welkomstTekst = input;

                    
                    File.WriteAllText(saveFile, welkomstTekst);
                }
            }
        }

       
        static void RunProducten()
        {
            string productenFile = "Producten.json";

            if (File.Exists(productenFile))
            {
                string text = File.ReadAllText(productenFile);
                Product[] producten = JsonSerializer.Deserialize<Product[]>(text);

                foreach (var product in producten)
                {
                    Console.WriteLine($"Product: {product.Name}, Prijs: {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("Producten.json niet gevonden!");
            }
        }

        
        static void RunEigen()
        {
            string afsprakenFile = "Afspraken.json";

            if (File.Exists(afsprakenFile))
            {
                string text = File.ReadAllText(afsprakenFile);
                Afspraak[] afspraken = JsonSerializer.Deserialize<Afspraak[]>(text);

                foreach (var afspraak in afspraken)
                {
                    Console.WriteLine($"Afspraak: {afspraak.Beschrijving} op {afspraak.Dag}/{afspraak.Maand}/{afspraak.Jaar} om {afspraak.Tijd}");
                }
            }
            else
            {
                Console.WriteLine("Afspraken.json niet gevonden!");
            }
        }

        
        static void Schrijven()
        {
            
            string mijnTekst = "Dit is een testbestand.";
            File.WriteAllText("mijntekst.txt", mijnTekst);

           
            string[] mijnRegels = { "Regel 1", "Regel 2", "Regel 3" };
            File.WriteAllLines("mijnregels.txt", mijnRegels);


            FavoriteGame[] favoriteGames = new FavoriteGame[]
            {
                new FavoriteGame { Name = "The Witcher 3", Platform = "PC" },
                new FavoriteGame { Name = "Breath of the Wild", Platform = "Nintendo Switch" },
                new FavoriteGame { Name = "Elden Ring", Platform = "PlayStation" }
            };

            string jsonText = JsonSerializer.Serialize(favoriteGames, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("games.json", jsonText);

           
            string jsonInhoud = File.ReadAllText("games.json");
            FavoriteGame[] ingeladenGames = JsonSerializer.Deserialize<FavoriteGame[]>(jsonInhoud);

            foreach (var game in ingeladenGames)
            {
                Console.WriteLine($"Game: {game.Name}, Platform: {game.Platform}");
            }
        }

        
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Afspraak
        {
            public int Dag { get; set; }
            public int Maand { get; set; }
            public int Jaar { get; set; }
            public string Tijd { get; set; }
            public string Beschrijving { get; set; }
        }

        public class FavoriteGame
        {
            public string Name { get; set; }
            public string Platform { get; set; }
        }
    }
}
