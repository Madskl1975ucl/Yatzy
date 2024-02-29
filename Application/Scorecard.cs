using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    // Metode til udregning af stilling


    public class Scorecard
{
        int _id;
        string _playerName;
        int ones = -1;
        int twos = -1;
        int threes = -1;
        int fours = -1;
        int fives = -1;
        int sixers = -1;
        int onePair = -1;
        int twoPairs = -1;
        int threeEquals = -1;
        int fourEquals = -1;
        int littleStraight = -1;
        int bigStraight = -1;
        int chance = -1;
        int yatzy = -1; 

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

        public bool SaveOnes(Dice dice)
        {
            List<Die> diceList = dice.Getdice();
            // er ones udfyldt tidligere i spillet
            if (ones != -1) 
            {
                return false;
            }

            // tjekker om slaget kan bruges
            foreach (Die d in diceList)
            {
                if (d.Value != 1)
                {
                    ones = 0;
                }
                return true;
            }

            // sum af slagets værdi
            foreach (Die d in diceList)
            {
                if (d.Value == 1) 
                {
                    ones = ones + d.Value;
                }
            }
            return true;
        }

        public bool SaveTwos(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (twos != -1)
            {
                return false;
            }

            foreach (Die d in diceList)
            {
                if (d.Value == 2)
                {
                    twos = twos + d.Value;
                }
            }
            return true;
        }

        public bool SaveThrees(Dice dice)
        {
            List<Die> diceList = dice.Getdice();
            
            if (threes != -1)
            {
                return false;
            }

            foreach (Die d in diceList)
            {
                if (d.Value == 3)
                {
                    threes = threes + d.Value;
                }
            }
            return true;
        }

        public bool SaveFours(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (fours != -1)
            {
                return false;
            }

            foreach (Die d in diceList)
            {
                if (d.Value == 4)
                {
                    fours = fours + d.Value;
                }
            }
            return true;
        }

        public bool SaveFives(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (fives != -1)
            {
                return false;
            }

            foreach (Die d in diceList)
            {
                if (d.Value == 5)
                {
                    fives = fives + d.Value;
                }
            }
            return true;
        }

        public bool SaveSixers(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (sixers != -1)
            {
                return false;
            }

            foreach (Die d in diceList)
            {
                if (d.Value == 6)
                {
                    sixers = sixers + d.Value;
                }
            }
            return true;
        }

        public bool SaveOnePair (Dice dice) 
        {
            // Sort svarer til forech i dice, der sorter fra lavest to højest 
            // Value.CompareTo svarer til ==
            // 2 4 1 5 6 bliver til 1 2 4 5 6 
            List<Die> diceList = dice.Getdice();

            if (onePair != -1)
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)  
            {
                int tempDieValue = diceList[i].Value;
                if (tempDieValue == diceList[i +1].Value) 
                {
                    onePair = diceList[i].Value + diceList[i].Value;
                }
               
            }
            return true;
        }

        public bool SaveTwoPairs(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (twoPairs != -1) 
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            int tempDieValue = 0;
            twoPairs = 0;

            for (int i = 1; i <= 4; i++)
            {
                tempDieValue = diceList[i - 1].Value;

                if (i == 4) 
                {
                    return true;
                }

                if (tempDieValue == diceList[i].Value)
                {
                    twoPairs += diceList[i].Value * 2 ; 
                }
            }
            return true;
        }

        public bool SaveThreeEquals(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (threeEquals != -1)
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = diceList[i].Value;
                if (tempDieValue == diceList[i + 1].Value && tempDieValue == diceList[i + 2].Value)
                {
                    threeEquals = diceList[i].Value * 3;
                }
            }
            return true;
        }

        public bool SaveFourEquals(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (ones != -1)
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = diceList[i].Value;
                if (tempDieValue == diceList[i + 1].Value && tempDieValue == diceList[i + 2].Value && tempDieValue == diceList[i + 3].Value)
                {
                    fourEquals = diceList[i].Value * 4;
                }

            }
            return true;
        }

        public bool SaveLittleStraight(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (ones != -1)
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            int tempDieValue = 1;

            for (int i = 1; i <= 4; i++)
            {
                if (diceList[0].Value == tempDieValue && diceList[1].Value == tempDieValue + 1 && diceList[2].Value == tempDieValue + 2 && diceList[3].Value == tempDieValue + 3 && diceList[4].Value == tempDieValue + 4)
                {
                    littleStraight += diceList[i].Value;
                    
                }
            }
            return true;
        }

        public bool SaveBigStraight(Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (ones != -1)
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            int tempDieValue = 2;

            for (int i = 0; i <= 4; i++)
            {
                if (diceList[0].Value == tempDieValue && diceList[1].Value == tempDieValue + 1 && diceList[2].Value == tempDieValue + 2 && diceList[3].Value == tempDieValue + 3 && diceList[4].Value == tempDieValue + 4)
                {
                    bigStraight += diceList[i].Value;
                }
            }
            return true;

        }

        public bool SaveChance(Dice dice) 
        {
            List<Die> diceList = dice.Getdice();

            if (ones != -1)
            {
                return false;
            }

            foreach (Die d in dice)
            {
                if (d.Value > 0)
                {
                    chance += d.Value;
                }
            }
            return true;
        }


        public bool SaveYatzy (Dice dice)
        {
            List<Die> diceList = dice.Getdice();

            if (ones != -1)
            {
                return false;
            }

            diceList.Sort((leftValue, rightValue) => leftValue.Value.CompareTo(rightValue.Value));

            for (int i = 0; i <= 4; i++)
            {
                int tempDieValue = dice[i].Value;
                if (tempDieValue == dice[i + 1].Value && tempDieValue == dice[i + 2].Value && tempDieValue == dice[i + 3].Value && tempDieValue == dice[i + 4].Value)
                {
                    yatzy = dice[i].Value * 5;
                }
            }
            return true;
        }

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
