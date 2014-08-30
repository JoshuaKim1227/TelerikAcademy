using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count == 5)
            {
                for (int card = 0; card < hand.Cards.Count; card++)
                {
                    for (int comparingCard = 1; comparingCard < hand.Cards.Count; comparingCard++)
                    {
                        if (card != comparingCard)
                        {
                            if (hand.Cards[card].Face == hand.Cards[comparingCard].Face && 
                                hand.Cards[card].Suit == hand.Cards[comparingCard].Suit)
                            {
                                return false;
                            }
                        }
                    }
                }

                return true;
            }

            return false;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            for (int firstCard = 0; firstCard < hand.Cards.Count; firstCard++)
            {
                for (int secondCard = 0; secondCard < hand.Cards.Count; secondCard++)
                {
                    for (int thirdCard = 0; thirdCard < hand.Cards.Count; thirdCard++)
                    {
                        for (int fourthCard = 0; fourthCard < hand.Cards.Count; fourthCard++)
                        {
                            if (firstCard != secondCard && secondCard != thirdCard && thirdCard != fourthCard)
                            {
                                if (hand.Cards[firstCard].Face == hand.Cards[secondCard].Face && 
                                    hand.Cards[secondCard].Face == hand.Cards[thirdCard].Face &&
                                    hand.Cards[thirdCard].Face == hand.Cards[fourthCard].Face)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            for (int card = 1; card < hand.Cards.Count; card++)
            {
                if (hand.Cards[card - 1].Suit != hand.Cards[card].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
