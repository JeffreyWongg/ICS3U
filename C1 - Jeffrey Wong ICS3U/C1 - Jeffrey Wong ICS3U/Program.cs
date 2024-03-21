// Jeffrey Wong
// ICS3U
// October 17th 2023
// C1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Word 1: ");
            string word1 = Console.ReadLine();

            Console.Write("Word 2: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.Write("Match");
            }
            else
            {
                Console.Write("Does Not Match");
            }

            Console.ReadKey();
        }
    }
}
