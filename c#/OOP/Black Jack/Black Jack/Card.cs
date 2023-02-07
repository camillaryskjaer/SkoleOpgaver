using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public struct Card
    {
        string suit = "";
        byte value = 0;
        byte point = 0;

        public Card(string s, byte v, byte p)
        {
            Suit = s;
            Value = v;
            Point = p;
        }

        public string Suit { get => suit; private set => suit = value; }
        public byte Value { get => value; private set => this.value = value; }
        public byte Point { get => point; private set => point = value; }



        public override string ToString()
        {
            return this.suit + " : " + this.Value;
        }
    }
}
