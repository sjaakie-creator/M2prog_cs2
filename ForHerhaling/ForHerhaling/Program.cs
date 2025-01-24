using System;

namespace ForHerhaling
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            
            double[] prijzen = new double[] { 19.99, 49.99, 29.95 };
            string[] artikelen = { "Boek", "Muis", "Toetsenbord" };
            Formulier[] formulieren = new Formulier[2];

           
            formulieren[0] = new Formulier("Jan", "Goede kwaliteit!");
            formulieren[1] = new Formulier("Piet", "Werkt zoals verwacht.");

            
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine($"Artikel: {artikelen[i]}, Prijs: €{prijzen[i]}");
            }

            
            prijzen = new double[] { 19.99, 49.99, 29.95, 99.99 };
            artikelen = new string[] { "Boek", "Muis", "Toetsenbord", "Monitor" };

            Console.WriteLine("\nNa toevoeging van een artikel:");

           
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine($"Artikel: {artikelen[i]}, Prijs: €{prijzen[i]}");
            }

            
            Console.WriteLine("\nReviews van formulieren:");
            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine($"Naam: {formulier.Naam}, Review: {formulier.Review}");
            }
        }
    }

    public class Formulier
    {
        public string Naam { get; set; }
        public string Review { get; set; }

        public Formulier(string naam, string review)
        {
            Naam = naam;
            Review = review;
        }
    }
}
