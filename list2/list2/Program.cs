using System;
using System.Collections.Generic;

namespace RemoveFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
           
            List<double> reviewScores = new List<double> { 342.97, 128.45, 256.78, 190.32 };

            
            Console.WriteLine("Scores in de List:");
            foreach (double score in reviewScores)
            {
                Console.WriteLine(score);
            }

            
            Console.WriteLine("\nVerwijder 342.97:");
            reviewScores.Remove(342.97);

            Console.WriteLine("Scores na Remove:");
            foreach (double score in reviewScores)
            {
                Console.WriteLine(score);
            }

            
            Console.WriteLine("\nVerwijder het eerste element:");
            reviewScores.RemoveAt(0);

            Console.WriteLine("Scores na RemoveAt:");
            foreach (double score in reviewScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
