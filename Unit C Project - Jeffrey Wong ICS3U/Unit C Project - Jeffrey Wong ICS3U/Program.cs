// Jeffrey Wong
// ICS3U
// November 10th 2023
// Unit C Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_C_Project___Jeffrey_Wong_ICS3U
{
    class Program
    {
        // Main section of the code
        static void Main(string[] args)
        {
            string[] postalCode; // Initializing an array for string 
            int numOfPostal; // Size of the array and dependant whatever the user inputs
            string convert; // Used to check if inputs are a variable or not

            do
            {
                do // Nested do-while loop
                {
                    // Prompt for the number of postal codes
                    Console.Write("Number of Postal Codes: ");
                    convert = Console.ReadLine();
                }
                while (!checkInteger(convert)); // Ensures that the input is valid by checking if it is an integer
            }
            while (Convert.ToInt32(convert) <= 0); // After the number is confirmed as an integer, this will make sure the number is greater than 0

            numOfPostal = Convert.ToInt32(convert); // numOfPostal is a counter that is based on whatever the user inputs

            postalCode = new string[numOfPostal]; // Creating a new array that is the size of whatever the user inputted

            // For loop to ask for postal codes dependant on how many times the user wants
            for (int i = 0; i < numOfPostal; i++)
            {
                do // Check to see if the postal code is either rural or urban
                {
                    Console.Write("Postal Code #" + (i + 1) + ": "); // Prompt for the postal codes
                    postalCode[i] = Console.ReadLine();
                }
                while (!isValid(postalCode[i])); // Will continuously ask for a postal code until a valid one is entered (either rural or urban)
            }

            // Allows the outputs to standout
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Rural Postal Codes:"); // Title for the rural postal codes
            // For loop to print out the rural postal codes
            for (int i = 0; i < numOfPostal; i++)
            {
                string temp = postalCode[i].ToUpper(); // Making a temporary variable to access the array of the postalCode

                // Two different pathways depending if the user put a space in their postal code or not
                if (isRural(postalCode[i]))
                {

                    if (isBlank(temp[3])) // Confirms the user put a space in the middle
                    {
                        // For loop to print out every character in postalCode
                        for (int j = 0, n = temp.Length; j < n; j++)
                        {
                            Console.Write(temp[j]);
                        }
                    }
                    else // This means the postalCode did not have a space in between
                    {
                        // Manually printing out the first 3 characters and last 3 characters divided by a space
                        Console.Write(temp[0]);
                        Console.Write(temp[1]);
                        Console.Write(temp[2]);
                        Console.Write(" " + temp[3] + temp[4] + temp[5]);
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Urban Postal Codes:"); // Title for the urban postal codes
            // For loop to print out the urban postal codes
            for (int i = 0; i < numOfPostal; i++)
            {
                string temp = postalCode[i].ToUpper(); // Making a temporary variable to access the array of the postalCode

                if (!isRural(postalCode[i])) // Confirms that the postal code is urban
                {
                    if (isBlank(temp[3])) // Confirms the user put a space in the middle
                    {
                        // For loop to print out every character in postalCode    
                        for (int j = 0, n = temp.Length; j < n; j++)
                        {
                            Console.Write(temp[j]);
                        }
                    }                   
                    else // This means the postalCode did not have a space in between
                    {
                        // Manually printing out the first 3 characters and last 3 characters divided by a space
                        Console.Write(temp[0]);
                        Console.Write(temp[1]);
                        Console.Write(temp[2]);
                        Console.Write(" " + temp[3] + temp[4] + temp[5]);
                    }
                    Console.WriteLine("");
                }               
            }
            
            // Reverting the highlight and font colour
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }

        // Checks if a number is an integer
        static bool checkInteger(string s)
        {
            try // If the string can be converted to an integer, it will return true
            {
                Convert.ToInt32(s);
                return true;
            }
            catch (FormatException) // FormatException to indicate there is improper input and returns false
            {
                Console.WriteLine("Improper Input");
                return false;
            }
            catch (OverflowException) // OverflowException to show the number is too large for the memory dedicated to it, returns false
            {
                Console.WriteLine("Number Too Large");
                return false;
            }
        }

        // Specific to checking if characters within the postal code are integers
        static bool postalInteger(char s)
        {
            int temp = s; // Assigning the value of the character to a temporary variable of type int
            temp = temp - 48; // Subtracting by 48 to reduce from the value of the number according to ASCII to the actual number (ex. 0 = 48 on ASCII, 48-48 = 0 <- the real value)

            if (temp <= 9) // Since s is type 'char' the max number the integer can be is 9 in a one digit space
            {
                // The number is an integer
                return true;
            }
            else // Not an integer
            {
                return false;
            }
        }

        // Checks if the character is a letter and is a valid letter in a postal code
        static bool postalLetter(char s)
        {
            int temp = s; // Assigning the value of the character to a temporary variable, to represent the direct value on ASCII

            // A = 65, Z = 90
            if (65 <= temp && temp <= 90) // If the character is a letter it will proceed
            {
                // D = 68, F = 70, I = 73, O = 79, Q = 81, U = 85
                if (temp != 68 && temp != 70 && temp != 73 && temp != 79 && temp != 81 && temp != 85)
                {
                    // Returns true (s is valid letter) if the letter does not equal any of the restricted characters listed
                    return true;
                }
                else // It is one of the restricted characters
                {
                    return false;
                }
            }
            else // Not a letter at all
            {
                return false;
            }
        }

        // Specific to the space in the middle of the postal code
        static bool isBlank(char s)
        {
            int temp = s; // Assigning the value of the character to a temporary variable of type int
            temp = temp - 48; // Subtracting by 48 to reduce from the value of the number according to ASCII to the actual number (ex. 0 = 48 on ASCII, 48-48 = 0 <- the real value)

            // A blank space " " is valued as -16, discovered by testing
            if (temp == -16)
            {
                // Confirms the character is a blank space
                return true;
            }
            else // Is not a blank space
            {
                return false;
            }
        }

        // Checks if the postal code entered is urban with criteria specified in the rubric
        static bool isValid(string s)
        {
            s = s.ToUpper(); // Converting the entire postal code to uppercase for convenience and formality

            // Ensures the postal code is not an improper length (Either 6 or 7 characters long)
            if (s.Length > 7 || s.Length < 6)
            {
                Console.WriteLine("Postal Code Must Be 6 or 7 Characters");
                Console.WriteLine("");
                return false;
            }

            // Starts scanning through every character of the postal code
            if (postalLetter(s[0])) // Checks if the first character is a valid letter to use in postal codes
            {
                int temp = s[0]; // Assigning the value of the character to a temporary variable of type int
                // W = 87, Z = 90
                if (temp != 87 && temp != 90) // Ensures the first letter is not "W" or "Z"
                {
                    if (postalInteger(s[1])) // Checks if the second character is an integer
                    {
                        if (postalLetter(s[2])) // Checks if the third character is a valid letter to use in postal codes
                        {

                            if (isBlank(s[3])) // Checks if there is a space in the middle of the postal code
                            {
                                if (postalInteger(s[4])) // Checks if the fifth character is an integer
                                {
                                    if (postalLetter(s[5])) // Checks if the sixth character is a valid letter to use in postal codes
                                    {
                                        if (postalInteger(s[6])) // Checks if the seventh character is an integer
                                        {
                                            return true; // All characters in the postal code are valid
                                        }
                                        else // Seventh character is not an integer and returns false
                                        {
                                            Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                            return false;
                                        }
                                    }
                                    else // Sixth character is not a valid letter to use in postal codes and returns false
                                    {
                                        Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                        return false;
                                    }
                                }
                                else // Fifth character is not an integer and returns false 
                                {
                                    Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                    return false;
                                }
                            }

                            else // There is no space in the middle of the postal code (fourth character)
                            { 
                                if (s.Length == 6) // If there is no space, the postal code MUST be 6 characters long
                                {
                                    if (postalInteger(s[3])) // Checks if the fourth character is an integer
                                    {
                                        if (postalLetter(s[4])) // Checks if the fifth character is a valid letter to use in postal codes
                                        {
                                            if (postalInteger(s[5])) // Checks if the sixth character is an integer
                                            {
                                                return true; // After the postal code passes all restrictions, return true
                                            }
                                            else // Sixth character is not an integer and returns false
                                            {
                                                Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                                return false;
                                            }
                                        }
                                        else // Fifth character is not a valid letter to use in postal codes and returns false
                                        {
                                            Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                            return false;
                                        }
                                    }
                                    else // Fourth character is not an integer and returns false
                                    {
                                        Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                        return false;
                                    }
                                }
                                else // No space in the middle, but is also not 6 characters in length
                                {
                                    Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                                    return false;
                                }     
                            }

                        }
                        else // Third character is not a valid letter to use in a postal code and returns false 
                        {
                            Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                            return false;
                        }

                    }
                    else // Second character is not an integer and returns false
                    {
                        Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                        return false;
                    }
                }

                else // First charcter is a "W" or "Z" and returns false
                {
                    Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                    return false;
                }
            }
            else // First charcter is not a valid letter to use in a postal code and returns false
            {
                Console.WriteLine("Format: L#L #L#\nL cannot be D, F, I, O, Q, or U AND cannot start with W or Z\nThe first # must be 0-9 depending on if it is rural or urban\n");
                return false;
            }
        }

        // To check if the valid postal code is rural or not
        static  bool isRural(string s)
        {
            int temp = s[1]; // Assigning the value of the character to a temporary variable of type int
            temp = temp - 48; // Subtracting by 48 to reduce from the value of the number according to ASCII to the actual number (ex. 0 = 48 on ASCII, 48-48 = 0 <- the real value)

            if (temp == 0) // If the first number in the postal code is 0, return true
            {
                return true;
            }
            else // This means the first number is not 0, meaning it is urban and returns false
            {
                return false;
            }
        }
    }
}