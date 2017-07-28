using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Deck class that inherits from the Card class
 * Version: 0.1 
 */ 

namespace Highest_Cards
{
    public class Deck
    {
        // Private instance variables
        private Random _random;

        // Private Properties
        private Random Random
        {
            get
            {
                return this._random;
            }

        }

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // Private Methods

        /// <summary>
        /// This is the private _initialize method that loads the deck with 52 cards.
        /// This method also initializes other class variables
        /// </summary>
        protected override void _initialize()
        {
            // initialization of the random object
            this._random = new Random();

            // load the list with cards
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // Public methods

        /// <summary>
        /// This method overrides the built-in ToString method and outputs the current contents
        /// of the deck.
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Deck contains:\n";
            outputString += "================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }

        /// <summary>
        /// This method removes a Card from element 0 in the List and returns this Card.
        /// </summary>
        public Card Deal1()
        {
            Card firstCard = (Card)this[0].Clone();
            this.RemoveAt(0); // removes the top card

            Console.WriteLine("Deck Contains: " + this.Count + " Cards");
            return firstCard;
        }
    }
}
