namespace Functions
{
    internal class Program
    {
        static void Main(string[] args) // The function is called Main returntype: void
        {
            Program program = new Program(); // Here the constructor Program() is used returntype: Program
            program.Run(); // The function is called Run returntype: void
        }

        // The Run function
        internal void Run()
        {
            Console.WriteLine("Welcome to the question program!");

            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();

            // Ask 4 random questions
            AskRandomQuestion(); // Ask a random question
            AskRandomQuestion(); // Ask another random question
            AskRandomQuestion(); // Ask another random question
            AskRandomQuestion(); // Ask another random question
        }

        // This function asks the first question
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // This function asks the second question
        internal void Vraag2()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // This function asks the third question
        internal void Vraag3()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // This function asks the fourth question
        internal void Vraag4()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // This function asks the fifth question
        internal void Vraag5()
        {
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // This function asks the sixth question
        internal void Vraag6()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // This function picks a random question from the list
        internal string GetRandomVraag()
        {
            Random random = new Random();
            string[] vragen = {
                "How long do you think you'd survive in a zombie apocalypse?",
                "What secret conspiracy would you like to actually start letting other people know?",
                "If you can still remember, what are your funniest childhood memories?",
                "What would you do if you won a million dollars?",
                "What is the worst game you played but that you liked anyway?",
                "Why do round pizzas come in square boxes?",
                "Has someone caught you dancing in front of the mirror?",
                "Have you ever tried talking to an animal?",
                "What would you call a male ladybug?",
                "Which species would be the rudest if all animals could talk?"
            };
            int index = random.Next(vragen.Length); // Get a random index
            return vragen[index]; // Return the random question
        }

        // This function asks a random question and shows the answer
        internal void AskRandomQuestion()
        {
            string vraag = GetRandomVraag(); // Get a random question
            Console.WriteLine(vraag); // Display the question
            string antwoord = Console.ReadLine(); // Get the user's answer
            Console.WriteLine($"Your answer: {antwoord}"); // Show the answer
        }
    }
}
