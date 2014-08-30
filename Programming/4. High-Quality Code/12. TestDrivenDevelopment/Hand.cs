using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(params Card[] cards)
        {
            this.Cards = new List<ICard>();

            foreach (Card card in cards)
            {
                this.Cards.Add(card);
            }
        }

        public override string ToString()
        {
            StringBuilder handBuilder = new StringBuilder();

            foreach (ICard card in this.Cards)
            {
                handBuilder.Append(card.ToString() + " ");
            }

            handBuilder.Remove(handBuilder.Length - 1, 1);

            return handBuilder.ToString();
        }
    }
}
