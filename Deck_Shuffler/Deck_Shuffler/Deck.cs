using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Shuffler
{
    class Deck
    {
        public List<Card> Cards = new List<Card>();
        
        public Deck()
        {
            string[] suits = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    Cards.Add(new Card(value, suit));
                }
            }
        }
        public Deck(string emptyDeck)
        {
            //Cards = null;
        }

        public void AddToDeck(string value, string suit)
        {
            Cards.Add(new Card(value, suit));
        }
            
    }
}
