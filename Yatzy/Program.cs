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
                Scorecards scorecards = new Scorecards();

                int playerCounter = 0;

                // int roundsCounter = 0;

                int numberOfRolls = 0;

                bool terminateThisLoop = false;

                Scorecard currentScorecard = null;

                Dice dice = null;

                Texts.ShowAddedPlayers(scorecards.GetScorecards());

                Console.WriteLine("Yatzy");

                Texts.MenuStart();

                while (!terminateThisLoop)
                {
                    if (numberOfRolls == 3)
                    {
                        Texts.ScoreCard(currentScorecard);
                        Console.WriteLine("Ikke flere kast, gem dit kast på Yatzy blokken");
                        Texts.ShowScorcardSaves();
                        int scoreSelect = 0;
                        int.TryParse(Console.ReadLine(), out scoreSelect);

                        switch (scoreSelect)
                        {
                            case 1:
                                currentScorecard.SaveOnes(dice);
                                break;

                            case 2:
                                currentScorecard.SaveTwos(dice);
                                break;

                            case 3:
                                currentScorecard.SaveThrees(dice);
                                break;

                            case 4:
                                currentScorecard.SaveFours(dice);
                                break;

                            case 5:
                                currentScorecard.SaveFives(dice);
                                break;

                            case 6:
                                currentScorecard.SaveSixers(dice);
                                break;

                            case 7:
                                currentScorecard.SaveOnePair(dice);
                                break;

                            case 8:
                                currentScorecard.SaveTwoPairs(dice);
                                break;

                            case 9:
                                currentScorecard.SaveThreeEquals(dice);
                                break;

                            case 10:
                                currentScorecard.SaveFourEquals(dice);
                                break;

                            case 11:
                                currentScorecard.SaveLittleStraight(dice);
                                break;

                            case 12:
                                currentScorecard.SaveBigStraight(dice);
                                break;

                            case 13:
                                currentScorecard.SaveChance(dice);
                                break;

                            case 14:
                                currentScorecard.SaveYatzy(dice);
                                break;
                        }
                        break;
                    }
                    int menuSelect = 0;

                    bool result = int.TryParse(Console.ReadLine(), out menuSelect);

                    switch (menuSelect)
                    {
                        case 1: // add player

                            playerCounter++;

                            Texts.AddPlayer(scorecards.GetScorecards(), playerCounter);

                            break;

                        case 2: // start game + first roll

                            dice = new Dice();

                            Texts.ChoosePlayer();

                            Texts.ShowAddedPlayers(scorecards.GetScorecards());

                            int playerId = 0;

                            int.TryParse(Console.ReadLine(), out playerId);

                            currentScorecard = scorecards.GetScoreCardById(playerId);

                            Texts.MenuGame();

                            Texts.StartGameHeadline();

                            Texts.ShowCurrentPlayer(currentScorecard);

                            dice.RollDice(); // slag 1

                            numberOfRolls++;

                            Texts.ShowRolledDice(dice);

                            // terminateThisLoop = true;
                            break;

                            case 3: // gem terninger

                            Texts.ShowChooseText();

                            Texts.SaveDiceText();

                            string lockedDice = Console.ReadLine();

                            dice.SetLockedDice(lockedDice);

                            Texts.ShowSavedDiceText(lockedDice);

                            dice.RollDice(); // slag 2

                            numberOfRolls++;

                            Texts.ShowRolledDice(dice);

                            break;

                            case 4: // kast igen

                            dice = new Dice();

                            dice.RollDice();

                            numberOfRolls++;

                            Texts.ShowRolledDice(dice);

                            break;

                            case 5: // tilføj til scorecard

                            case 6: // vis scorecard

                            break;
                            
                        case 7: // næste spiller
                                                        
                            break;
                    }






                    //Vis aktiv spiller

                    //Vis slag






                }

            }
        }
    }
}

