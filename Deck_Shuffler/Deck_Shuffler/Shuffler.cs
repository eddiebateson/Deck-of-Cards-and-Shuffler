using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Shuffler
{
    class Shuffler
    {
        public static Deck Shuffle(Deck DeckToShuffle)
        {
            Random rnd = new Random();
            List<int> indexes = Enumerable.Range(0, 52).ToList();
            //var randomisedIndexes = indexes.OrderBy(idx => rnd.Next());

            List<int> randomisedIndexes = new List<int>();
            while (indexes.Count>0)
            {
                int randomNo = rnd.Next(0,52);

                if (indexes.Contains(randomNo))
                {
                    randomisedIndexes.Add(randomNo);
                    indexes.Remove(randomNo);
                }
            }

            Deck shuffledDeck = new Deck("emptyDeck");

            foreach (var index in randomisedIndexes)
            {
                shuffledDeck.AddToDeck(DeckToShuffle.Cards[index].value,DeckToShuffle.Cards[index].suit);
            }

            return shuffledDeck;
        }
    }
}
