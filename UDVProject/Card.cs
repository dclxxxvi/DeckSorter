using System;

namespace DeckSorter
{
    public class Card
    {
        public readonly string Suit;
        public readonly string Value;

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return Value + " of " + Suit;
        }
    }
}