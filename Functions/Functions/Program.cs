namespace Functions
{
    internal class Program
    {
        static void Main(string[] args) // The function is called Main, return type: void
        {
            Program program = new Program(); // The Program() constructor is called, return type: Program
            program.Run(); // The function is called Run, return type: void
        }

        
        internal void Run() // The function is called Run, return type: void
        {
            Console.WriteLine("Welcome to the question program!");

            Vraag1(); 
            Vraag2(); 
            Vraag3(); 
            Vraag4(); 
            Vraag5(); 
            Vraag6(); 
        }

        // Vraag 1
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Vraag 2
        internal void Vraag2()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Vraag 3
        internal void Vraag3()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Vraag 4
        internal void Vraag4()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Vraag 5
        internal void Vraag5()
        {
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }

        // Vraag 6
        internal void Vraag6()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Your answer: {antwoord}");
        }
    }
}