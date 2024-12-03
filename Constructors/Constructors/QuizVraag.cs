public class QuizVraag
{
    public string Vraag { get; }
    public string Antwoord { get; }

    // Constructor
    public QuizVraag(string vraag, string antwoord)
    {
        this.Vraag = vraag;
        this.Antwoord = antwoord;
    }
}
