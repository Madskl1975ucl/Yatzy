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
            dice.Add(new Die(random).RollDie());
            dice.Add(new Die(random).RollDie());
            dice.Add(new Die(random).RollDie());
            dice.Add(new Die(random).RollDie());
            dice.Add(new Die(random).RollDie());
            scorecard.SaveOnePair(dice);
            dice.Add(new Die(random) { Value = 2 });
            dice.Add(new Die(random) { Value = 5 });
            dice.Add(new Die(random) { Value = 2 });
            dice.Add(new Die(random) { Value = 4 });
            dice.Add(new Die(random) { Value = 5 });
            scorecard.SaveTwoPairs(dice);
            dice.Add(new Die(random) { Value = 2 });
            dice.Add(new Die(random) { Value = 5 });
            dice.Add(new Die(random) { Value = 2 });
            dice.Add(new Die(random) { Value = 5 });
            dice.Add(new Die(random) { Value = 5 });
            scorecard.SaveThreeEquals(dice);

        }
    }
}
