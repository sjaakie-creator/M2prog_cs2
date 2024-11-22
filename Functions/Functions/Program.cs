namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program(); //returntype program
            program.Run(); //dit laat het runnen het is een functie

        }
        //
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }
    }
}
