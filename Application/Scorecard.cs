using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        int _id;
        string _playerName;
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
        public Scorecard(int id, string playerName)
        {
            _id = id;
            _playerName = playerName;     
        }

        public int getId() 
        { 
            return _id; 
        }

        public void SaveOnes(List<Die> dice) 
        {
            // validering om dice er korrekte
            foreach (Die d in dice) 
            {
                if (d.Value == 1) 
                {
                    ones = ones + d.Value;
                }
                else 
                {
                    ones = 0;
                    return;
                } 
            }
        }

        public void SaveOnePair (List<Die> dice) 
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 
            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i =0; i < 4; i++)  
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i +1].Value) 
                {
                    onePair = dice[i].Value + dice[i].Value;
                    return;
                }
               
            }
        }

        public void SaveTwoPairs(List<Die> dice)
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 
            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i < 4; i++)
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i + 1].Value)
                {
                    twoPairs = dice[i].Value + dice[i].Value;
                }

            }
        }
    }
}
