using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Main class
 * Version: 0.1
 */

namespace Highest_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); 

            Deck deck = new Deck();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            hand.Add(deck.Deal1()); // deal one card from top
            Console.WriteLine(hand.ToString());
            Console.WriteLine();

            hand.Add(deck.Deal1()); // deal one card from top
            Console.WriteLine(hand.ToString());

            hand = deck.Deal5(); // new Hand object created and assigned to hand
            Console.WriteLine(hand.ToString());

            hand.HighestCards(); // displays the highest cards of the hand
        }
    }
}
