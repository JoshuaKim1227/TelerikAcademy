using System;
using System.Text;

namespace HangmanGame
{
    public static class Hangman
    {
        private static readonly string[] Words = new string[]
        { 
            "computer", "programmer", "software", "debugger", "compiler", "developer", "algorithm", "array", "method", "variable"
        };
        private static Scoreboard scoreboard = new Scoreboard();
        private static int numberOfMistakesMade;
        public static char[] displayableWord;

        private static bool endOfAllGames;
        private static bool endOfCurrentGame;
        private static bool helpIsUsed;

        static Hangman()
        {
            numberOfMistakesMade = 0;
            PrintWelcomeMessage();
        }

        static void Main()
        {
            bool gamesAreOver = false;

            while (!gamesAreOver)
            {
                gamesAreOver = PlayOneGame("array");
                Console.WriteLine();
            }
        }

        public static bool PlayOneGame(string secretWord)
        {
            // string word = SelectRandomWord();  => Removed for test purposes
            displayableWord = GenerateEmptyWordOfUnderscores(secretWord.Length);

            endOfAllGames = false;
            endOfCurrentGame = false;
            helpIsUsed = false;

            while (!endOfCurrentGame)
            {
                PrintDisplayableWord();

                string userInput = GetUserInput();

                if (userInput.Length == 1)
                {
                    char guessLetter = char.Parse(userInput);

                    ProcessUserGuess(guessLetter, secretWord, ref numberOfMistakesMade);
                }
                else
                {
                    ProcessCommand(userInput, secretWord);
                }

                bool gameIsWon = CheckIfGameIsWon(helpIsUsed, numberOfMistakesMade);

                if (gameIsWon)
                {
                    endOfCurrentGame = true;
                }
            }

            return endOfAllGames;
        }

        public static string SelectRandomWord()
        {
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, Words.Length);
            string randomWord = Words[randomIndex];

            return randomWord;
        }

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to “Hangman” game. Please try to guess my secret word.\n");
            Console.WriteLine("Type 'top' to view the top scoreboard.");
            Console.WriteLine("Type 'restart' to start a new game.");
            Console.WriteLine("Type 'help' to cheat and 'exit' to quit the game.\n");
        }

        public static char[] GenerateEmptyWordOfUnderscores(int wordLength)
        {
            char[] wordOfUnderscores = new char[wordLength];

            for (int index = 0; index < wordLength; index++)
            {
                wordOfUnderscores[index] = '_';
            }

            return wordOfUnderscores;
        }

        public static string ProcessUserGuess(char suggestedLetter, string secretWord, ref int numberOfMistakesMade)
        {
            StringBuilder builder = new StringBuilder(); // Added for test purposes
            int NumberOfRevealedLetters = CheckUserGuess(suggestedLetter, secretWord);

            if (NumberOfRevealedLetters > 0)
            {
                bool wordIsRevealed = CheckIfWordIsRevealed();

                if (!wordIsRevealed)
                {
                    if (NumberOfRevealedLetters == 1)
                    {
                        builder.AppendFormat("Good job! You revealed {0} letter.", NumberOfRevealedLetters);  // Added for test purposes
                        Console.WriteLine("Good job! You revealed {0} letter.", NumberOfRevealedLetters);
                    }
                    else
                    {
                        builder.AppendFormat("Good job! You revealed {0} letters.", NumberOfRevealedLetters);  // Added for test purposes
                        Console.WriteLine("Good job! You revealed {0} letters.", NumberOfRevealedLetters);
                    }
                }
            }
            else
            {
                builder.AppendFormat("Sorry! There are no unrevealed letters \"{0}\".", suggestedLetter);  // Added for test purposes
                Console.WriteLine("Sorry! There are no unrevealed letters \"{0}\".", suggestedLetter);
                numberOfMistakesMade++;
            }

            return builder.ToString(); // Added for test purposes
        }

        public static void ProcessCommand(string command, string secretWord)
        {
            endOfCurrentGame = false;
            endOfAllGames = false;
            helpIsUsed = false;

            switch (command)
            {
                case "top":
                    scoreboard.PrintCurrentScoreboard();
                    break;
                case "restart":
                    endOfCurrentGame = true;
                    endOfAllGames = false;
                    break;
                case "exit":
                    Console.WriteLine("Goodbye!");
                    endOfCurrentGame = true;
                    endOfAllGames = true;
                    break;
                case "help":
                    HelpByRevealingALetter(secretWord);
                    helpIsUsed = true;
                    break;
                default:
                    break;
            }
        }

        private static string GetUserInput()
        {
            string inputLine = string.Empty;
            bool inputIsValid = false;

            while (!inputIsValid)
            {
                Console.Write("Enter your guess or command: ");

                inputLine = Console.ReadLine();
                inputLine = inputLine.ToLower();

                if (inputLine.Length == 1 && char.IsLetter(inputLine, 0))
                {
                    inputIsValid = true;
                }
                else if (inputLine == "top" || inputLine == "restart" || inputLine == "help" || inputLine == "exit")
                {
                    inputIsValid = true;
                }
                else
                {
                    Console.WriteLine("Incorrect guess or command!");
                }
            }

            return inputLine;
        }

        public static string HelpByRevealingALetter(string secretWord)
        {
            StringBuilder builder = new StringBuilder(); // Added for test purposes
            int nextUnrevealedLetterIndex = 0;

            for (int index = 0; index < displayableWord.Length; index++)
            {
                if (displayableWord[index] == '_')
                {
                    nextUnrevealedLetterIndex = index;
                    break;
                }
            }

            char letterToBeRevealed = secretWord[nextUnrevealedLetterIndex];

            for (int index = 0; index < secretWord.Length; index++)
            {
                if (letterToBeRevealed == secretWord[index])
                {
                    displayableWord[index] = letterToBeRevealed;
                }
            }

            builder.AppendFormat("OK, I reveal for you the next letter '{0}'.", letterToBeRevealed); // Added for test purposes
            Console.WriteLine("OK, I reveal for you the next letter '{0}'.", letterToBeRevealed);

            return builder.ToString(); // Added for test purposes
        }

        public static bool CheckIfWordIsRevealed()
        {
            bool wordIsRevealed = true;

            for (int index = 0; index < displayableWord.Length; index++)
            {
                if (displayableWord[index] == '_')
                {
                    wordIsRevealed = false;
                    break;
                }
            }

            return wordIsRevealed;
        }

        public static string PrintDisplayableWord()
        {
            StringBuilder builder = new StringBuilder(); // Added for test purposes

            builder.Append("The secret word is:"); // Added for test purposes
            Console.Write("The secret word is:");

            foreach (var letter in displayableWord)
            {
                builder.AppendFormat(" {0}", letter); // Added for test purposes
                Console.Write(" {0}", letter);
            }

            builder.Append("\n"); // Added for test purposes
            Console.WriteLine();

            return builder.ToString(); // Added for test purposes
        }

        public static int CheckUserGuess(char suggestedLetter, string secretWord)
        {
            int numberOfRevealedLetters = 0;
            bool letterIsAlreadyRevealed = CheckIfLetterIsAlreadyRevealed(suggestedLetter);

            if (!letterIsAlreadyRevealed)
            {
                for (int index = 0; index < secretWord.Length; index++)
                {
                    if (suggestedLetter == secretWord[index])
                    {
                        displayableWord[index] = suggestedLetter;
                        numberOfRevealedLetters++;
                    }
                }
            }

            return numberOfRevealedLetters;
        }

        public static bool CheckIfLetterIsAlreadyRevealed(char suggestedLetter)
        {
            bool letterIsAlreadyRevealed = false;

            for (int index = 0; index < displayableWord.Length; index++)
            {
                if (displayableWord[index] == suggestedLetter)
                {
                    letterIsAlreadyRevealed = true;
                }
            }

            return letterIsAlreadyRevealed;
        }

        public static bool CheckIfGameIsWon(bool helpIsUsed, int numberOfMistakesMade)
        {
            bool wordIsRevealed = CheckIfWordIsRevealed();

            if (wordIsRevealed)
            {
                if (helpIsUsed)
                {
                    Console.Write("You won with {0} mistakes but you have cheated. ", numberOfMistakesMade);
                    Console.WriteLine("You are not allowed to enter into the scoreboard.");

                    PrintDisplayableWord();
                }
                else
                {
                    Console.WriteLine("You won with {0} mistakes.", numberOfMistakesMade);

                    PrintDisplayableWord();
                    scoreboard.TryToSignToScoreboard(numberOfMistakesMade);
                }
            }

            return wordIsRevealed;
        }
    }
}