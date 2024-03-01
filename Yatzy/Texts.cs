using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Presentation
{
    public class Texts
    {
        public static void MenuStart()
        {

            Console.WriteLine("1. Tilføj spiller");

            Console.WriteLine("2. Start spillet");

            //Console.WriteLine("3. Vis scorecard");

            //Console.WriteLine("4. Gem terninger");

            //Console.WriteLine("5. Kast igen");

            ShowExitText();

            Console.WriteLine("Klik på menupunkt: 1, 2 eller 0 for at afslutte");

        }

        public static void ShowExitText()
        {
            Console.WriteLine("0. Afslut");
        }

        public static void AddPlayer(List<Scorecard> scorecards, int playerId)
        {
            Console.Write("Tilføj spiller - indtast navn: ");

            string playerName = Console.ReadLine();

            Scorecard scorecard = new Scorecard(playerId, playerName);

            scorecards.Add(scorecard);

            Console.WriteLine($"{playerName} med {playerId} er nu med i spillet");
        }

        public static void ShowAddedPlayers(List<Scorecard> scorecards)
        {
            foreach (var scorecard in scorecards)
            {
                Console.WriteLine($"{scorecard.getId()}. \"{scorecard.GetName()}\"");
            }
        }

        public static void ChoosePlayer()
        {
            Console.WriteLine("Vælg hvilken spiller starter ?");
        }

        public static void MenuGame()
        {
            Console.WriteLine("3. Gem terninger");

            Console.WriteLine("4. Kast alle terninger igen");

            Console.WriteLine("5. Skriv resultat i scorekortet og næste spillers tur starter");
        }

        public static void StartGameHeadline()
        {
            Console.WriteLine("Nu starter spillet");
        }


        public static void ShowCurrentPlayer(Scorecard scorecard)
        {
            Console.WriteLine($"Den aktive spiller er: {scorecard.GetName()}");
        }

        public static void ShowRolledDice(Dice dice)
        {
            Console.WriteLine("");

            Console.WriteLine("Kastet terninger:");

            Console.WriteLine("");

            string resultString = "";

            foreach (var die in dice.Getdice())
            {
                resultString += $"T#{die.GetId()}: {die.Value}, ";
            }

            Console.Write(resultString + "\n");
        }

        public static void ShowChooseText()
        {
            Console.WriteLine("Hvilke terninger vil du gemme til næste kast?");
        }

        public static void SaveDiceText()
        {
            Console.WriteLine("Indtast terning nr., terning nr. du vil gemme, f.eks. 1,3,5");
        }

        public static void ShowSavedDiceText(string lockedDiceInput)
        {
            Console.WriteLine("Du har gemt disse terninger: " + lockedDiceInput);
        }
        public static void ScoreCard(Scorecard currentscorecard)
        {
            Console.WriteLine("");
            Console.WriteLine($"Scorecord: {currentscorecard.GetName()}");
            Console.WriteLine($"Et-ere:\t{currentscorecard.GetOnes()}");

            Console.WriteLine($"To-ere:\t{currentscorecard.GetTwos()}");

            Console.WriteLine($"tree-re:\t{currentscorecard.GetThrees()}");

            //...
        }

        public static void ShowScorcardSaves()
        {
            Console.WriteLine("1. Gem 1'ere");
            Console.WriteLine("2. Gem 2'ere");
            Console.WriteLine("3. Gem 3'ere");
            Console.WriteLine("4. Gem 4'ere");
            Console.WriteLine("5. Gem 5'ere");
            Console.WriteLine("6. Gem 6'ere");
            Console.WriteLine("7. Gem et par");
            Console.WriteLine("8. Gem to par");
            Console.WriteLine("9. Gem 3 ens");
            Console.WriteLine("10. Gem 4 ens");
            Console.WriteLine("11. Gem lille straight");
            Console.WriteLine("12. Gem store straight");
            Console.WriteLine("13. Gem chancen");
            Console.WriteLine("11. Gem Yatzy!");
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
