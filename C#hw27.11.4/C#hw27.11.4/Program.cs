using System;
using System.Collections.Generic;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> wordList = new List<string>();

            Console.WriteLine("Enter words (type 'exit' to stop):");

            string userInput;
            do
            {
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "exit")
                {
                    // Function to check if a word is not empty
                    if (IsValidWord(userInput))
                    {
                        wordList.Add(userInput);
                    }
                    else
                    {
                        Console.WriteLine("Invalid word. Please enter a valid word.");
                    }
                }

            } while (userInput.ToLower() != "exit");

            Console.WriteLine($"\nNumber of words in the list: {wordList.Count}");
            Console.WriteLine("Words in the list:");

            foreach (string word in wordList)
            {
                Console.WriteLine(word);
            }
        }

        private static bool IsValidWord(string word)
        {
            return !string.IsNullOrEmpty(word);
        }
    }
}
