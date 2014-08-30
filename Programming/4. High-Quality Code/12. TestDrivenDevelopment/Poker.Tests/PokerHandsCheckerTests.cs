using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        // Hand validity tests
        [TestMethod]
        public void TestHandValidityGoodHand()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds));

            Assert.IsTrue(handsChecker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestHandValiditySameCard()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds));

            Assert.IsFalse(handsChecker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestHandValidityLessCards()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades));

            Assert.IsFalse(handsChecker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestHandValidityMoreCards()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts));

            Assert.IsFalse(handsChecker.IsValidHand(hand));
        }

        // Hand Flush tests
        [TestMethod]
        public void TestHandFlushClubs()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs));

            Assert.IsTrue(handsChecker.IsFlush(hand));
        }

        [TestMethod]
        public void TestHandFlushDiamonds()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds));

            Assert.IsTrue(handsChecker.IsFlush(hand));
        }

        [TestMethod]
        public void TestHandFlushHearts()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts));

            Assert.IsTrue(handsChecker.IsFlush(hand));
        }

        [TestMethod]
        public void TestHandFlushSpades()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades));

            Assert.IsTrue(handsChecker.IsFlush(hand));
        }

        [TestMethod]
        public void TestHandFlushFalse()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades));

            Assert.IsFalse(handsChecker.IsFlush(hand));
        }

        // Hand Four of a kind tests
        [TestMethod]
        public void TestHandFourOfKindMiddleDifferent()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades));

            Assert.IsTrue(handsChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestHandFourOfKindFirstDifferent()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades));

            Assert.IsTrue(handsChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestHandFourOfKindLastDifferent()
        {
            IPokerHandsChecker handsChecker = new PokerHandsChecker();

            IHand hand = new Hand(
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades));

            Assert.IsTrue(handsChecker.IsFourOfAKind(hand));
        }
    }
}