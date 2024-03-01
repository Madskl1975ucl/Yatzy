using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    
    public class Die
    {
        private readonly int _id;
        private Random _random;
        private int _value;

        // constructor til hver terning, der skal slås med
        public Die(int id, Random random)
        {
            _id = id;
            _random = random;
        }

        public int GetId()
        {
            return _id;
        }

        // metode til kast af terning med random værdi ml. 1-6
        public Die RollDie()
        {
            if (StopRollDie) return this;

            _value = _random.Next(1, 7);

            // gemmer værdien i variblen int value
            return this;
        }

        // henter nuværende værdi i int value og gør den public, så den hentes i andre metoder
        // bruges kun til Unit test, skal erstattes med public int Value { get { return _value; } }
        public int Value
        {
            get { return _value; }

            set { _value = value; }
        }

        public string Id { get; set; }

        public bool StopRollDie;
    }
}
