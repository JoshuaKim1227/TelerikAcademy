using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestToStringKingClubs()
        {
            Card card = new Card(CardFace.King, CardSuit.Clubs);

            string expected = "K♣";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTenDiamonds()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Diamonds);

            string expected = "10♦";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTwoHearts()
        {
            Card card = new Card(CardFace.Two, CardSuit.Hearts);

            string expected = "2♥";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringAceSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);

            string expected = "A♠";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}