using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    // 14 metoder til at gemme result på scorecard 
    // Metode til udregning af point
    // Metode til udregning af stilling


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

        public void SaveTwos(List<Die> dice)
        {
            // validering om dice er korrekte
            foreach (Die d in dice)
            {
                if (d.Value == 2)
                {
                    twos = twos + d.Value;
                }
            }
        }

        public void SaveThrees(List<Die> dice)
        {
            // validering om dice er korrekte
            foreach (Die d in dice)
            {
                if (d.Value == 3)
                {
                    threes = threes + d.Value;
                }
            }
        }

        public void SaveFours(List<Die> dice)
        {
            // validering om dice er korrekte
            foreach (Die d in dice)
            {
                if (d.Value == 4)
                {
                    fours = fours + d.Value;
                }
            }
        }

        public void SaveFives(List<Die> dice)
        {
            // validering om dice er korrekte
            foreach (Die d in dice)
            {
                if (d.Value == 5)
                {
                    fives = fives + d.Value;
                }
            }
        }

        public void SaveSixers(List<Die> dice)
        {
            // validering om dice er korrekte
            foreach (Die d in dice)
            {
                if (d.Value == 6)
                {
                    sixers = sixers + d.Value;
                }
            }
        }

        public void SaveOnePair (List<Die> dice) 
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 
            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i =0; i <= 4; i++)  
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

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i + 1].Value)
                {
                    twoPairs += dice[i].Value + dice[i].Value;
                }

            }
        }

        public void SaveThreeEquals(List<Die> dice)
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 

            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i + 1].Value && tempDieValue == dice[i + 2].Value)
                {
                    threeEquals = dice[i].Value * 3; 
                    return;
                }

            }
        }

        public void SaveFourEquals(List<Die> dice)
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 

            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i + 1].Value && tempDieValue == dice[i + 2].Value && tempDieValue == dice[i + 3].Value)
                {
                    fourEquals = dice[i].Value * 4;
                    return;
                }

            }
        }

        public void SaveLittleStraight(List<Die> dice)
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 
            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            int tempDieValue = 1;

            for (int i = 1; i <= 4; i++)
            {
                if (dice[0].Value == tempDieValue && dice[1].Value == tempDieValue + 1 && dice[2].Value == tempDieValue + 2 && dice[3].Value == tempDieValue + 3 && dice[4].Value == tempDieValue + 4)
                {
                    littleStraight += dice[i].Value;
                }
            }

        }

        public void SaveBigStraight(List<Die> dice)
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 
            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            int tempDieValue = 2;

            for (int i = 0; i <= 4; i++)
            {
                if (dice[0].Value == tempDieValue && dice[1].Value == tempDieValue + 1 && dice[2].Value == tempDieValue + 2 && dice[3].Value == tempDieValue + 3 && dice[4].Value == tempDieValue + 4)
                {
                    bigStraight += dice[i].Value;
                    
                }
            }

        }

        public void SaveChance(List<Die> dice) 
        {
            foreach (Die d in dice)
            {
                if (d.Value > 0)
                {
                    chance += d.Value;
                }
            }
        }


        public void SaveYatzy (List<Die> dice)
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 

            dice.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i + 1].Value && tempDieValue == dice[i + 2].Value && tempDieValue == dice[i + 3].Value && tempDieValue == dice[i + 4].Value)
                {
                    yatzy = dice[i].Value * 5;
                    return;
                }

            }
        }
        //todo: Mangler 2,3,4,5,6 + fire ens, yatzy, lille straight, store straight og chancen

        public int CalculatePoints() 
        {
            int points = 0;
            points += ones;
            points += twos;
            points += threes;
            points += fours;
            points += fives;
            points += sixers;
            if (points >= 63 && points <= 93) 
            {
                points += 50;
            }
            if (points >= 94)
            {
                points += 100;
            }
            points += onePair;
            points += twoPairs;
            points += threeEquals;
            points += fourEquals;
            points += littleStraight;
            points += bigStraight;
            points += chance;
            points += yatzy;
            if (yatzy != 0) 
            {
                points += 50;
            }

            return points;
        }

    }
}
