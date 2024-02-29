using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Scorecards
    {
        private List<Scorecard> _scorecards;

        public Scorecards()
        {
            _scorecards = new List<Scorecard>();
        }

        public List<Scorecard> GetScorecards()
        {
            return _scorecards;
        }

        public Scorecard GetScoreCardById(int playerId)
        {
            for (int index = 0; index < _scorecards.Count; index++)
            {
                Scorecard scorecard = _scorecards[index];

                if (scorecard.GetId() == playerId)
                    return scorecard;
            }

            return null;
        }
    }
}
