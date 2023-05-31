using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloushingCards2_Win_forms_
{
    class Deck
    {
        private List<Card> cards;
        public int Count { get { return cards.Count(); } }

        private Random random = new Random();
        public void Add(Card cardToAdd)
            => cards.Add(cardToAdd);

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int n = random.Next(cards.Count + 1);
                Card card = cards[i];
                cards[i] = cards[n];
                cards[n] = card;
            }
        }
        public IEnumerable<string> GetCardNames()
        {
            List<string> Names = new List<string>();
            foreach (Card card in cards)
            {
                Names.Add(card.ToString());
            }
            return Names;
        }
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 0; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
            => this.cards = new List<Card>(initialCards);

        public void Sort()
            => cards.Sort(new SortByValuesNSuits());
    }
}
