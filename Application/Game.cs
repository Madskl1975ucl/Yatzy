using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// roll dices
// save dices
// save result + select option on scorecard
// next player


namespace Application
{
    public class Game
    {
        // List med datatypen Scorecard
        List<Scorecard> scoreCards;
        public void AddScorecard(Scorecard scoreCard)
        {
            scoreCards.Add(scoreCard);
        }

        public Scorecard GetScorecardById(int id)
        {
            int ScorecardId;

            foreach (var scorecard in scoreCards)
            {
                ScorecardId = scorecard.getId();
                if (ScorecardId == id)
                {
                    return scorecard;
                }
            }

            return null;
        }

        //public List<Die> RollDice()
        //{
        //    //Round 1 viser 5 terninger, der viser 5 værdier
        //    //Round 2:
        //    // - vælger de terninger, der skal fjernes fra listen og erstatte nye random
        //    // - reroll terninger kastes og nye værdier tilføjes listen
        //    //Round 3:
        //    // - vælger de terninger, der skal fjernes fra listen og erstatte nye random
        //    // - reroll terninger kastes og nye værdier tilføjes listen
        //    // 1 eller 2 metoder her?

        //    //return dices;
        //}

        public void SaveScorecard(Scorecard scorecard)
        {
            // skal gemme scorecard for player, så der kan skiftes tur
        }

        //public List <Scorecard> NextScorecard ()
        //{


        //    // return nextScorecard;
        //    //List < scorecards >
        //    // 0 1 2 3 = 4 spillere
        //    // nextplayer[i] +1
        //    // if [i] == List<Scorecards>.Count
        //    // nextplayder = [0]
        //}

    }


    
}
