public class Quiz
{
    private QuizVraag[] vragen;
    private QuizVraagAntwoord[] ingevuldeAntwoorden;

    // Constructor
    public Quiz(int aantalVragen)
    {
        this.vragen = new QuizVraag[aantalVragen];
        this.ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }

    // Voeg een vraag toe
    public void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        vragen[index] = new QuizVraag(vraag, antwoord);
    }

    // Stel een vraag
    public void StelVraag(int index)
    {
        if (vragen[index] != null)
        {
            Console.WriteLine(vragen[index].Vraag);
            string gebruikersAntwoord = Console.ReadLine();
            ingevuldeAntwoorden[index] = new QuizVraagAntwoord(vragen[index], gebruikersAntwoord);

            // Laat zien of het antwoord correct is
            if (ingevuldeAntwoorden[index].IsCorrect)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Fout! Het juiste antwoord is: {vragen[index].Antwoord}");
            }
        }
    }

    // Bereken de score
    public int BerekenScore()
    {
        int score = 0;
        foreach (var antwoord in ingevuldeAntwoorden)
        {
            if (antwoord != null && antwoord.IsCorrect)
            {
                score++;
            }
        }
        return score;
    }
}
