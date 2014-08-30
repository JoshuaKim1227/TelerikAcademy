using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestHand()
        {
            IHand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds));

            string expected = "2♣ K♦ 10♥ J♠ A♦";
            string actual = hand.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}