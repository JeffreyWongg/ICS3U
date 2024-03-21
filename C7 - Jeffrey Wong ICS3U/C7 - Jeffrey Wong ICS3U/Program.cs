// Jeffrey Wong
// ICS3U
// October 26th 2023
// C7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first; // Initializing the first name's variable to be an array
            string[] last; // Initializing the last name's variable to be an array

            // Determining the size of each array as 3
            first = new string[3];
            last = new string[3];

            // For loop to ask for the first name and last name 3 times
            for (int i = 0; i < 3; i++)
            {
                // Prompt for the first name
                Console.Write("First Name: ");
                first[i] = Console.ReadLine();

                // Prompt for the last name
                Console.Write("Last Name: ");
                last[i] = Console.ReadLine();
            }
            // Another for loop to display the 3 different inputs
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(first[i] + "\t" + last[i]); // Displays the first name and last name three different times
            }
            Console.ReadKey();
        }
    }
}
