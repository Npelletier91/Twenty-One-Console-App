using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {




            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Nic";
            game += player;
            

            Deck deck = new Deck();

            int count = deck.Cards.Count(x => x.Face == Face.King);

            List<Card> newList = deck.Cards.Where(x => x.Suit == Suit.Clubs).ToList();

            foreach (Card card in newList)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");

            }


            int timesShuffled = 0;
            deck.Shuffle(out timesShuffled, 4); //calling shuffle method (4) times. returning shuffled deck to deck.

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled: {0}", timesShuffled);

            Console.ReadLine();
        }
    }
}
