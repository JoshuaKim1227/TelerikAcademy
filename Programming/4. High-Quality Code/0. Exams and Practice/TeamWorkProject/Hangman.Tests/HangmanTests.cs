using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangmanGame;

namespace HangmanTests
{
    [TestClass]
    public class HangmanTests
    {
        private string word = "array";

        [TestMethod]
        public void TestGneratingWordUnderscoresInitial()
        {
            char[] expected = { '_', '_', '_', '_', '_' };
            char[] actual = Hangman.GenerateEmptyWordOfUnderscores(word.Length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPrintDisplayableWordInitial()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = '_';
            Hangman.displayableWord[2] = '_';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = '_';

            string actual = Hangman.PrintDisplayableWord();
            string expected = "The secret word is: _ _ _ _ _\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckUserGuess()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = '_';
            Hangman.displayableWord[2] = '_';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = '_';

            char letter = 'a';

            int expected = 2;
            int actual = Hangman.CheckUserGuess(letter, word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfLetterIsAlreadyRevealedTrue()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = '_';
            Hangman.displayableWord[2] = '_';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = 'y';

            char letter = 'y';

            bool expected = true;
            bool actual = Hangman.CheckIfLetterIsAlreadyRevealed(letter);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfLetterIsAlreadyRevealedFalse()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = '_';
            Hangman.displayableWord[2] = '_';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = '_';

            char letter = 'a';

            bool expected = false;
            bool actual = Hangman.CheckIfLetterIsAlreadyRevealed(letter);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestProcessUserGuessLetterA()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = '_';
            Hangman.displayableWord[2] = '_';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = '_';

            int numberOfMistakesMade = 0;
            char letter = 'a';

            string expected = "Good job! You revealed 2 letters.";
            string actual = Hangman.ProcessUserGuess(letter, word, ref numberOfMistakesMade);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestProcessUserGuessLetterY()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = 'r';
            Hangman.displayableWord[2] = 'r';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = '_';

            int numberOfMistakesMade = 2;
            char letter = 'y';

            string expected = "Good job! You revealed 1 letter.";
            string actual = Hangman.ProcessUserGuess(letter, word, ref numberOfMistakesMade);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestProcessUserGuessLetterZ()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = '_';
            Hangman.displayableWord[1] = 'r';
            Hangman.displayableWord[2] = 'r';
            Hangman.displayableWord[3] = '_';
            Hangman.displayableWord[4] = '_';

            int numberOfMistakesMade = 3;
            char letter = 'z';

            string expected = "Sorry! There are no unrevealed letters \"z\".";
            string actual = Hangman.ProcessUserGuess(letter, word, ref numberOfMistakesMade);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHelpByRevealingALetter()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = 'a';
            Hangman.displayableWord[1] = '_';
            Hangman.displayableWord[2] = '_';
            Hangman.displayableWord[3] = 'a';
            Hangman.displayableWord[4] = '_';

            string expected = "OK, I reveal for you the next letter 'r'.";
            string actual = Hangman.HelpByRevealingALetter(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfWordIsRevealedTrue()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = 'a';
            Hangman.displayableWord[1] = 'r';
            Hangman.displayableWord[2] = 'r';
            Hangman.displayableWord[3] = 'a';
            Hangman.displayableWord[4] = 'y';

            bool expected = true;
            bool actual = Hangman.CheckIfWordIsRevealed();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfWordIsRevealedFalse()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = 'a';
            Hangman.displayableWord[1] = 'r';
            Hangman.displayableWord[2] = 'r';
            Hangman.displayableWord[3] = 'a';
            Hangman.displayableWord[4] = '_';

            bool expected = false;
            bool actual = Hangman.CheckIfWordIsRevealed();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfGameIsWonFalse()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = 'a';
            Hangman.displayableWord[1] = 'r';
            Hangman.displayableWord[2] = 'r';
            Hangman.displayableWord[3] = 'a';
            Hangman.displayableWord[4] = '_';

            bool helpIsUsed = false;
            int numberOfMistakesMade = 3;

            bool expected = false;
            bool actual = Hangman.CheckIfGameIsWon(helpIsUsed, numberOfMistakesMade);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfGameIsWonTrueWithHelp()
        {
            Hangman.displayableWord = new char[5];
            Hangman.displayableWord[0] = 'a';
            Hangman.displayableWord[1] = 'r';
            Hangman.displayableWord[2] = 'r';
            Hangman.displayableWord[3] = 'a';
            Hangman.displayableWord[4] = 'y';

            bool helpIsUsed = true;
            int numberOfMistakesMade = 0;

            bool expected = true;
            bool actual = Hangman.CheckIfGameIsWon(helpIsUsed, numberOfMistakesMade);

            Assert.AreEqual(expected, actual);
        }
    }
}