using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Linq;
using Application;

// display visninger og brugerinput

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {

            {
                Scorecard scorecard = new Scorecard(1, "Mads");
                List<Die> dice = new List<Die>();
                Random random = new Random();
                dice.Add(new Die(random) { Value = 6 });
                dice.Add(new Die(random) { Value = 2 });
                dice.Add(new Die(random) { Value = 4 });
                dice.Add(new Die(random) { Value = 3 });
                dice.Add(new Die(random) { Value = 1 });
                scorecard.SaveTwoPairs(dice);

                //List<Scorecard> scorecards = new List<Scorecard>();


                //while (true)
                //{
                //    Thread.Sleep(1000);
                //    Console.WriteLine("");
                //    Console.WriteLine("Spil YATZY!");
                //    string menuStart =
                //    "1. Tilføj spiller\n" +
                //    "2. Start spillet\n" +
                //    "3. Vis tilføjede spillere\n" +
                //    "0. Afslut\n" +
                //    "Klik på menupunkt: 1, 2 eller 0 for at afslutte\n";

                //    Console.WriteLine(menuStart);

                //    int.TryParse(Console.ReadLine(), out int menuvalg);

                //    switch (menuvalg)
                //    {
                //        case 1:
                //            Console.Write("Tilføj spiller - indtast navn: ");
                //            string _playerName = Console.ReadLine();
                //            Console.Write("Indtast spiler nr: ");
                //            int _id = int.Parse(Console.ReadLine());
                //            Scorecard scorecard = new Scorecard(_id, _playerName);
                //            scorecards.Add(new Scorecard(_id, _playerName));
                //            Console.WriteLine($"{_playerName} med {_id} er nu med i spillet");
                //            // Thread.Sleep(800);
                //            break;
                //        case 2:
                //            Console.WriteLine("Nu starter spillet");
                //            return;
                //        case 3:
                //        // scorecards.ForEach(scorecard => Console.WriteLine($"{_playerName} med id: {_id}"));
                //        //foreach (Scorecard scorecard in scorecards)
                //        //{
                //        //    Console.WriteLine($"{_playerName} med id: {_id}");
                //        //}
                //        //break;
                //        case 0:
                //            return;
        //    }


        //}
            }
        }
    }
}
