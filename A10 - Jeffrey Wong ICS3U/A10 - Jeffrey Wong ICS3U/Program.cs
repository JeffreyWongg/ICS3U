//Jeffrey Wong
//ICS3U
//September 11th 2023
//A10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = ""; // defines the variable as a string and leaves it empty to allow the user to set the value
            string lastName = ""; // defines the variable as a string and leaves it empty to allow the user to set the value
            int grade = 0; // defines the variable as an int and leaves it empty to allow the user to change the value

            Console.Write("First Name: \n"); // Prompt for the first name
            firstName = Console.ReadLine(); //Changes the variable to whatever the user types in

            Console.Write("Last Name: \n"); // Prompt for the last name
            lastName = Console.ReadLine(); // Changes the variable to whatever the user types in

            Console.Write("Grade Level: \n"); // Prompt for their current grade
            grade = Convert.ToInt32(Console.ReadLine()); // Converts the inputted value from a string to an integer

            Console.Write("Hello " + firstName + " " + lastName + ", you are in grade: " + grade + "\n"); //Displays the variables in the following format

            Console.ReadKey();
        }
    }
}
