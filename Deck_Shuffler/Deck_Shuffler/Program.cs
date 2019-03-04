using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Shuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck EddsDeck = new Deck();

            Deck ShuffledDeck = Shuffler.Shuffle(EddsDeck);

            foreach (var card in ShuffledDeck.Cards)
            {
                Console.WriteLine($"{card.value} of {card.suit}");                
            }
            Console.ReadKey();
        }
    }
}
