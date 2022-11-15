using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Cards
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<Card> deck = new List<Card>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i]
                .ToString()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string face = tokens[0];
                string suit = tokens[1];
                try
                {
                    deck.Add(CreateCard(face, suit));
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }
            Console.WriteLine(string.Join(" ", deck));
        }

        static Card CreateCard(string face, string suit)
        {
            string[] validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] validSuits = new string[] { "S", "H", "D", "C" };
            if (!validFaces.Contains(face) || !validSuits.Contains(suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            switch (suit)
            {
                case "S":
                    suit = "\u2660";
                    break;
                case "H":
                    suit = "\u2665";
                    break;
                case "D":
                    suit = "\u2666";
                    break;
                case "C":
                    suit = "\u2663";
                    break;
            }

            return new Card(face, suit);
        }
    }
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }
        public override string ToString()
        => $"[{Face}{Suit}]";
    }
}
