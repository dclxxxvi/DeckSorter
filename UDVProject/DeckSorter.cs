using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckSorter
{
    public static class DeckSorter
    {
        private static List<Deck> decks = new List<Deck>();
        public static string DeckNames => string.Join("\n", decks.Select(deck => deck.Name));

        public static Deck Find(string name) => decks.Find(deck => deck.Name == name);

        public static void Create(string name, DeckType deckType) => decks.Add(new Deck(name, deckType));

        public static void Shuffle(string name, ShuffleMethod shuffleMethod) => decks.Find(deck => deck.Name == name).Shuffle(shuffleMethod);

        public static void Remove(string name) => decks.RemoveAll(deck => deck.Name == name);
    }
}