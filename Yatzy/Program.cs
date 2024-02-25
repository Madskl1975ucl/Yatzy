using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Application;

// display visninger og brugerinput

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Scorecard> scorecards = new List<Scorecard>();
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("Spil YATZY!");
                string menuStart = 
                "1. Tilføj spiller\n" +
                "2. Start spillet\n" +
                "0. Afslut\n" +
                "Klik på menupunkt: 1, 2 eller 0 for at afslutte\n";

                Console.WriteLine(menuStart);

                int.TryParse(Console.ReadLine(), out int menuvalg);

                switch (menuvalg)
                {
                    case 1:
                        Console.Write("Tilføj spiller - indtast navn: ");
                        string _playerName = Console.ReadLine();
                        Console.Write("Indtast spiler nr: ");
                        int _id = int.Parse(Console.ReadLine());
                        scorecards.Add(new Scorecard(_id, _playerName)); 
                        Console.WriteLine($"{_playerName} med {_id} er nu med i spillet");
                        Thread.Sleep(1000);
                        break;
                    case 2: 
                        Console.WriteLine("Nu starter spillet");
                        return;
                    case 0:
                        return;
                }


            }
        }
    }
}
