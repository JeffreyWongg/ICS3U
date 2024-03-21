// Jeffrey Wong
// ICS3U
// November 6th 2023
// C8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the favourite number
            Console.Write("Favourite Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Prompt for the first pet's name
            Console.Write("First Pet's Name: ");
            string pet = Console.ReadLine();

            // Prompt for the street name
            Console.Write("Street Name: ");
            string street = Console.ReadLine();

            // Calls the ThreeThings method that will display the favourite number, pet name, and street name
            threeThings(num, pet, street);

            Console.ReadKey();
        }
        static void threeThings(int num, string pet, string street) // Retrieves the 3 variables that were determined in Main
        {
            Console.WriteLine("\nYour favourite number is " + num + " and you live on " + street + ", with your first pet named " + pet + "."); // Prints out all the user's input in a sentence
        }
    }
}
