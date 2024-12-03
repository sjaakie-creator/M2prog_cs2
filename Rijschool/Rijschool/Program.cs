using System.Runtime.InteropServices;

namespace Rijschool
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            Program.Run();

            Auto auto1 = new Auto();
            {
                Automaat = true,
                    kenteken = "AA824H",
                    Kilometerstand= 20567,
                    merk = "Volkswagen"
            };
        }
    }
}
