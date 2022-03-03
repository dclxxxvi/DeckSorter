using System;

namespace DeckSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckSorter.Create("firstDeck", DeckType.Deck52);
            DeckSorter.Create("secondDeck", DeckType.Deck36);
            DeckSorter.Create("thirdDeck", DeckType.Deck52);
            Console.WriteLine("Названия колод: ");
            Console.WriteLine(DeckSorter.DeckNames);
            Console.WriteLine("Колода по умолчанию: ");
            Console.WriteLine(DeckSorter.Find("firstDeck").ToString());
            Console.WriteLine("Рандомный метод перетасовки: \n");
            DeckSorter.Shuffle("firstDeck", ShuffleMethod.RandomShuffle);
            Console.WriteLine(DeckSorter.Find("firstDeck").ToString());
            Console.WriteLine("Эмуляция перетасовки вручную: \n");
            DeckSorter.Shuffle("thirdDeck", ShuffleMethod.HandShuffle);
            Console.WriteLine(DeckSorter.Find("thirdDeck").ToString());
            Console.WriteLine("Перетасовка колоды из 36 карт: ");
            DeckSorter.Shuffle("secondDeck", ShuffleMethod.RandomShuffle);
            Console.WriteLine(DeckSorter.Find("secondDeck").ToString());
            Console.WriteLine("Удаление колоды: ");
            DeckSorter.Remove("firstDeck");
            Console.WriteLine(DeckSorter.DeckNames);
        }
    }
}
