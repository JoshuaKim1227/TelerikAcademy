using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string cardFace = FaceToString(this.Face);
            string cardSuit = SuitToString(this.Suit);

            return cardFace + cardSuit; 
        }

        private string FaceToString(CardFace cardFace)
        {
            string result;

            if (this.Face <= CardFace.Ten)
            {
                result = ((int)this.Face).ToString();
            }
            else
            {
                switch (this.Face)
                {
                    case CardFace.Jack:
                        result = "J";
                        break;
                    case CardFace.Queen:
                        result = "Q";
                        break;
                    case CardFace.King:
                        result = "K";
                        break;
                    case CardFace.Ace:
                        result = "A";
                        break;
                    default:
                        throw new ArgumentException("CardFace", "Card face in invalid.");
                }
            }

            return result;
        }

        private string SuitToString(CardSuit cardSuit)
        {
            string result;

            switch (cardSuit)
            {
                case CardSuit.Clubs:
                    result = "♣";
                    break;
                case CardSuit.Diamonds:
                    result = "♦";
                    break;
                case CardSuit.Hearts:
                    result = "♥";
                    break;
                case CardSuit.Spades:
                    result = "♠";
                    break;
                default:
                    throw new ArgumentException("CardSuit", "Card suit is invalid.");
            }

            return result;
        }
    }
}