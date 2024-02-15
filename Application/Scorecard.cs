using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application

    // 14 metoder til at gemme result på scorecard 
    // Metode til udregning af point
    // Metode til udregning af stilling

{   //Burde flyttes til nyt project Domain 
    public class Scorecard
    {
        int id;
        int ones;
        int twos;
        int threes;
        int fours;
        int fives;
        int sixers;
        int onePair;
        int twoPairs;
        int threeEquals;
        int fourEquals;
        int littleStraight;
        int bigStraight;
        int chance;
        int yatzy; 

        // constructor til Scorecard, så den bruges som datatype
        // parameterne i Scorecard burde laves med et interface IScorecard
        public Scorecard(int id, int ones, int twos, int threes, int fours, int fives, int sixers, int onePair, int twoPairs, int threeEquals, int fourEquals, int littleStraight, int bigStraight, int chance, int yatzy)
        {
            id = id;
            ones = ones;
            twos = twos;
            threes = threes;
            fours = fours;
            fives = fives;
            sixers = sixers;
            onePair = onePair;
            twoPairs = twoPairs;
            threeEquals = threeEquals;
            fourEquals = fourEquals;
            littleStraight = littleStraight;
            bigStraight = bigStraight;
            chance = chance;
            yatzy = yatzy;
        }

    }
}
