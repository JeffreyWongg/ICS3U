// Jeffrey Wong
// ICS3U
// October 20th 2023
// C4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the first word
            Console.Write("Word 1: ");
            string word1 = Console.ReadLine();

            // Converting the first word to all caps
            word1 = word1.ToUpper();

            // Prompt for the second word
            Console.Write("Word 2: ");
            string word2 = Console.ReadLine();

            // Converting the second word to all caps
            word2 = word2.ToUpper();

            // Create a new variable to hold the value of the string compare function
            int result = word1.CompareTo(word2);

            if (result < 0) // if the first word is alphabetically BEFORE the second word, it will enter this condition
            {
                // Prints the first word, and then the second word
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }
            else if (result > 0) // if the first word is alphabetically AFTER the second word, it will enter this condition
            {
                // Prints the second word, and then the first word
                Console.WriteLine(word2);
                Console.WriteLine(word1);
            }
            else // if the words are the same, it will enter this condition
            {
                // Will print out the words, the order is irrelevant because they are the same
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }
            Console.ReadKey();
        }
    }
}