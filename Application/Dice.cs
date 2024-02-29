using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Dice
    {
        private List<Die> _dice;

        public Dice()
        {
            Random random = new Random();

            _dice = new List<Die>();

            _dice.Add(new Die(1, random));
            _dice.Add(new Die(2, random));
            _dice.Add(new Die(3, random));
            _dice.Add(new Die(4, random));
            _dice.Add(new Die(5, random));
        }

        public List<Die> Getdice() // i stedet for add and remove dice
        {
            return _dice;
        }

        public List<Die> RollDice()
        {
            List<Die> result = new List<Die>();

            foreach (var die in _dice)
            {
                result.Add(die.RollDie());
            }

            _dice = result;

            return _dice;
        }

        //todo: implementering mangler
        public void LockedDice(int[] lockedDiceList)
        {
            throw new NotImplementedException();
        }

        public void SetLockedDice(string diceInput)
        {
            string[] splitDiceInput = diceInput.Split(',');

            foreach (string diceId in splitDiceInput)
            {
                int i = int.Parse(diceId);
                _dice[i - 1].StopRollDie = true;
            }

        }
    }
}
