using System.Xml.Linq;
using Application;

// display visninger og brugerinput

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // unit test
            Scorecard scorecard = new Scorecard(1, "Mads" );
            List<Die> dice = new List<Die>();
            Random random = new Random();
            dice.Add(new Die(random, 1).RollDie());
            dice.Add(new Die(random, 2).RollDie());
            dice.Add(new Die(random, 3).RollDie());
            dice.Add(new Die(random, 4).RollDie());
            dice.Add(new Die(random, 5).RollDie());
            scorecard.SaveOnePair(dice);
        }
    }
}
