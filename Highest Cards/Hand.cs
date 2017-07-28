using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Hand class that inherits from the CardList class
 * Version: 0.3 
 */

namespace Highest_Cards
{
    public class Hand : CardList
    {
        // Private Methods
        /// <summary>
        /// This method initializes class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            // This method is currently empty
        }

        // Public Methods
        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand contains:\n";
            outputString += "================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void HighestCards()
        {
            var highestCards =
                from card in this
                orderby card.Face descending
                select card;

        Console.WriteLine("This are the highest Cards:\n=====================================================");

            foreach (var crd in highestCards)
            {
                Console.WriteLine("The " + crd.Face + " of " + crd.Suit);
            }
        }

    }
}
