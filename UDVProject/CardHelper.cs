using System;
using System.Collections.Generic;
using System.Text;

namespace DeckSorter
{
    public static class CardHelper
    {
        public static Dictionary<int, string> Suit = new Dictionary<int, string>()
        {
            { 0, "Club" },
            { 1, "Diamond" },
            { 2, "Spade" },
            { 3, "Heart" },
        };

        public static Dictionary<int, string> Value52 = new Dictionary<int, string>()
        {
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" },
            { 10, "Ten" },
            { 11, "Jack" },
            { 12, "Queen" },
            { 13, "King" },
            { 14, "Ace" },
        };

        public static Dictionary<int, string> Value36 = new Dictionary<int, string>()
        {
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" },
            { 10, "Ten" },
            { 11, "Jack" },
            { 12, "Queen" },
            { 13, "King" },
            { 14, "Ace" },
        };
    }
}