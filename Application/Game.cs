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
                public void AddScoreCard(Scorecard scoreCard) 
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
        public List<Die> RollDice() 
        {
            return null;
        }

        public void SaveScorecard(Scorecard scorecard) 
        {

        }

    }

    
}
