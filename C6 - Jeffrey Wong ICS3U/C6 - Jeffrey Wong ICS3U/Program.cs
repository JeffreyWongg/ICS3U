// Jeffrey Wong
// ICS3U
// October 25th 2023
// C6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            do
            {
                // Prompt for the word
                Console.Write("Word: ");
                word = Console.ReadLine();

                if (word.CompareTo("X") == 0 || word.CompareTo("x") == 0)
                {
                    break;
                }
                else
                {
                    for (int i = 0, n = word.Length; i < n; i += 2)
                    {
                        Console.WriteLine(word[i]);
                    }
                }
            }
            while (word.CompareTo("X") != 0 && word.CompareTo("x") != 0);

            Console.Write("End");
            Console.ReadKey();
        }
    }
}