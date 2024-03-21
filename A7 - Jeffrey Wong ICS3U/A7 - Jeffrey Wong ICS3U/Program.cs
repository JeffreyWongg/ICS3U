//Jeffrey Wong
//ICS3U
//September 8th 2023
//A7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presetting the variables for the first time
            string firstName = "Jeffrey"; // defining the variable as string allows the variable to receive anything
            string lastName = "Wong";
            int grade = 11; // defining the variable as int allows the variable to be a number

            // Displays the variables in the following format
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grade);

            // Reassigning the variables 
            firstName = "Carson";
            lastName = "Greig";
            grade = 11;

            // Displays the reassigned variables in the following format
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grade);

            // Reassigning the variables
            firstName = "Ammar";
            lastName = "Yousaf";
            grade = 11;

            // Displays the reassigned variables in the following format
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grade);

            Console.ReadKey();
        }
    }
}
