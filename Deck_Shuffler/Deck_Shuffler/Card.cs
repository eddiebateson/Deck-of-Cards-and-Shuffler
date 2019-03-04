using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Shuffler
{
    public class Card
    {
        public string value { get; }
        public string suit { get; }
        public Card(string value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }
    }
}
