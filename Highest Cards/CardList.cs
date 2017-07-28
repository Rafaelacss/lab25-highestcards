using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Abstract class CardList
 * Version: 0.1 
 */

namespace Highest_Cards
{
    public abstract class CardList 
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
