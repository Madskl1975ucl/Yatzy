namespace Application
{

    public class Player
    {
        public int id;
        public string name;
        public Scorecard scoreCard;

        public Player(int id, string name, Scorecard scorecard)
        {
            id = id;
            name = name;
            scoreCard = scorecard;
        }
    }
}
