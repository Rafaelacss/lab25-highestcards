using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Abstract class CardList that inherits from the List generic collection.
 * Version: 0.2 
 */

namespace Highest_Cards
{
    public abstract class CardList : List<Card>
    {
        // Constructor
        public CardList()
        {
            this._initialize();
        }

        // Methods
        protected abstract void _initialize();
    }
}
