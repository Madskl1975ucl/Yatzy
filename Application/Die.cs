using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application

    // en terning + random tal mellem 1-6
    // metode til throw, return value, gem i lokal varible
    // id på terning

{
    // definition af den enkelte terning
    public class Die
    {
        Random _random;
        int _value;

        // constructor til hver terning, der skal slås med 5 ad gangen i 3 omgange
        public Die(Random random) 
        {
            _random = random;
        }
        
        // metode til kast af terning med random værdi ml. 1-6
        public Die RollDie() 
        { 
            _value = _random.Next(1, 6);
            // gemmer værdien i variblen int value
            return this;
        }
        // henter nuværende værdi i int value og gør den public, så den hentes i andre metoder
        // bruges kun til Unit test, skal erstattes med public int Value { get { return _value; } }
        public int Value { get { return _value; } set { _value = value; } }
    }
}
