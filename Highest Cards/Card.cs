using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Card Class, will be used on card shuffling and dealing simulation.
 * Version: 0.2
 */

namespace Highest_Cards
{
    public class Card : ICloneable
    {
        // Private instance variables
        private Face _face;
        private Suit _suit;

        // Public properties
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }

        // Constructors
        /// <summary>
        /// Main constructor that takes two parameters (face (Face), suit (Suit))
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        /// Methods
        /// <summary>
        /// This method returns the current card's clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }
    }
}
