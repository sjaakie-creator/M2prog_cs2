using Constructors;
using System;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
       
        Quiz quiz = new Quiz(10);

       
        quiz.VoegVraagToeOpIndex(0, "Wat is de hoofdstad van Nederland?", "Amsterdam");
        quiz.VoegVraagToeOpIndex(1, "Hoeveel provincies heeft Nederland?", "12");

        
        for (int i = 0; i < 2; i++)
        {
            quiz.StelVraag(i);
        }

        
        Console.WriteLine($"Je score: {quiz.BerekenScore()}");
    }
}
