public class QuizVraagAntwoord
{
    public QuizVraag Vraag { get; }
    public string GebruikersAntwoord { get; }
    public bool IsCorrect { get; }

    // Constructor
    public QuizVraagAntwoord(QuizVraag vraag, string gebruikersAntwoord)
    {
        this.Vraag = vraag;
        this.GebruikersAntwoord = gebruikersAntwoord;
        this.IsCorrect = gebruikersAntwoord.Trim().Equals(vraag.Antwoord, StringComparison.OrdinalIgnoreCase);
    }
}
