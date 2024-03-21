using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; // Initializes the variable age
            do 
            { // This while loop will continuously prompt for an age
                // This section will prompt the user for the age and resassign the variable "age"
                Console.Write("Age: "); 
                age = Convert.ToInt32(Console.ReadLine());

                if (age > 29) // If the age is greater than 29, it will print "You are old!"
                {
                    Console.WriteLine("You are old!");
                }
                else if (age > 19 && age <= 29) // If the age is greater than 19, but less than 29 (inclusive), it will print "You are getting old!"
                {
                    Console.WriteLine("You are getting old!");
                }
                else if (age >= 13 && age <= 19) // If the age is between 13 and 19 inclusive, it will print "You are a teenager!"
                {
                    Console.WriteLine("You are a teenager!"); 
                }
                else if (age >= 0 && age < 13) // If the age is greater than 0 (inclusive, but less than 13, it will print "You are a child!"
                {
                    Console.WriteLine("You are a child!");
                }
            }
            while (age >= 0) ; // This condition will make sure it stays in the loop, until the age inputted is a negative number

            Console.Write("End"); // Marks the end of the program after a negative number is inputted
            Console.ReadKey();
        }
    }
}
