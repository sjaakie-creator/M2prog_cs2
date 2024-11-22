using System;

namespace Functions
{


    internal class Program
    {
        static void Main(string[] args)// The function is called Main, return type: void
        {
            Program program = new Program();// The Program() constructor is called, return type: Program
            program.Run();// The function is called Run, return type: void
        }

        internal void Run()
        {
            Console.WriteLine("Welcome to the question program!");

            // Ask questions
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();

            // New functionality: choose a random question
            string randomVraag = KiesWillekeurigeVraag();
            Console.WriteLine($"Random question: {randomVraag}");
        }

        // Question 1
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Question 2
        internal void Vraag2()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Question 3
        internal void Vraag3()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Question 4
        internal void Vraag4()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Question 5
        internal void Vraag5()
        {
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Question 6
        internal void Vraag6()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Function with return type: get a random question from the array
        internal string KiesWillekeurigeVraag()
        {
            string[] vragen = new string[]
            {
                "How long do you think you'd survive in a zombie apocalypse?",
                "If you can still remember, what are your funniest childhood memories?",
                "What would you do if you won a million dollars?",
                "Why do round pizzas come in square boxes?",
                "Has someone caught you dancing in front of the mirror?",
                "Which species would be the rudest if all animals could talk?"
            };

            Random random = new Random();
            int index = random.Next(vragen.Length); // Choose a random index
            return vragen[index];
        }
    }
}