using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckSorter
{
    public class Deck
    {
        private List<Card> deck;
        private readonly DeckType deckType;
        public readonly string Name;
        public int Count => deck.Count;

        public Deck(string name, DeckType deckType)
        {
            this.Name = name;
            this.deckType = deckType;
            CreateDeck(deckType);
        }

        private void CreateDeck(DeckType deckType)
        {
            deck = new List<Card>();
            switch (deckType)
            {
                case DeckType.Deck52:
                    foreach (var value in CardHelper.Value52)
                        foreach (var suit in CardHelper.Suit)
                            deck.Add(new Card(suit.Value, value.Value));
                    break;
                case DeckType.Deck36:
                    foreach (var value in CardHelper.Value36)
                        foreach (var suit in CardHelper.Suit)
                            deck.Add(new Card(suit.Value, value.Value));
                    break;
            }
        }

        public void Shuffle(ShuffleMethod shuffleMethod)
        {
            switch (shuffleMethod)
            {
                case ShuffleMethod.HandShuffle:
                    HandShuffle();
                    break;
                case ShuffleMethod.RandomShuffle:
                    RandomShuffle();
                    break;
            }
        }

        private void RandomShuffle()
        {
            var random = new Random();
            for (int i = deck.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = deck[j];
                deck[j] = deck[i];
                deck[i] = temp;
            }
        }

        private void HandShuffle()
        {
            var random = new Random();
            for (int i = 0; i < 70; i++)
            {
                int deckMiddle = random.Next(-(deck.Count / 4), (deck.Count / 4)) + deck.Count / 2;
                var firstPart = deck.Take(deckMiddle).ToList();
                var secondPart = deck.Skip(deckMiddle).Reverse().ToList();
                deck = secondPart.Concat(firstPart).ToList();
            }
        }

        public override string ToString()
        {
            return string.Join("\n", deck
                .Select(card => card.ToString())
                .ToArray());
        }
    }
}
