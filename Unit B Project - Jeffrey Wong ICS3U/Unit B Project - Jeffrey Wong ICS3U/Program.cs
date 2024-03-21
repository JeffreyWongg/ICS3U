// Jeffrey Wong
// ICS3U
// October 3rd 2023
// Unit B Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_B_Project___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do while loop to ask for the number of students the user would like to create a report card for
            int numStudents;
            do
            {
                // Prompt for number of students
                Console.Write("Number of Students:\t");
                numStudents = Convert.ToInt32(Console.ReadLine());
            }
            while (numStudents <= 0); // lets the user proceed when the number is greater than 0 (at least 1)
            Console.WriteLine("");

            // Will enter a loop to ask for certain inputs and will repeat based on however many students there are
            for (int i = 0; i < numStudents; i++)
            {
                // Prompt for the first name of the student
                Console.Write("First Name:\t\t");
                string firstName = Console.ReadLine();

                // Prompt for the last name of the student
                Console.Write("Last Name:\t\t");
                string lastName = Console.ReadLine();

                // This do while loop is for receiving a student number
                double studentNumberLength;
                int studentNumber;
                do
                {
                    // Prompt for the student ID number
                    Console.Write("Student Number:\t\t");
                    studentNumber = Convert.ToInt32(Console.ReadLine());

                    // Converts the length of the student number to a usable variable/number
                    studentNumberLength = studentNumber.ToString().Length;
                }
                while (studentNumberLength != 7 || studentNumber < 0); // lets the user proceed when the number length is 7 digits, and not a negative number

                // This do while loop is for receiving a homeroom number
                double homeroomLength;
                int homeroom;
                do
                {
                    // Prompt for the homeroom number
                    Console.Write("Homeroom Number:\t");
                    homeroom = Convert.ToInt32(Console.ReadLine());

                    // Converts the homeroom number inputted to a number based on the number of digits inputted
                    homeroomLength = homeroom.ToString().Length;
                }
                while (homeroomLength != 3 || homeroom < 0); // Lets the user proceed when the homeroom length is 3 digits long, and not a negative number

                // This do while loop will ask for the number of courses the student is taking
                int courses;
                do
                {
                    // Prompt for number of courses currently taking
                    Console.Write("# of Courses:\t\t");
                    courses = Convert.ToInt32(Console.ReadLine());
                }
                while (courses != 3 && courses != 4); // Will only accept 3 or 4 courses, otherwise it will constantly prompt

                // initalizing some variables to use in the upcoming if conditions
                string courseName1, courseName2, courseName3, courseName4;
                int mark1, mark2, mark3, mark4;

                if (courses == 3) // Will only enter this condition if the number of courses the student is taking is 3
                {
                    // Prompt for the first course's name
                    Console.Write("Course #1:\t\t");
                    courseName1 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the mark of the first course
                        Console.Write("Mark:\t\t\t");
                        mark1 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark1 < 0 || mark1 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Prompt for the second course's name
                    Console.Write("Course #2:\t\t");
                    courseName2 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the mark of the second course
                        Console.Write("Mark:\t\t\t");
                        mark2 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark2 < 0 || mark2 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Prompt for the third course's name
                    Console.Write("Course #3:\t\t");
                    courseName3 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the mark of the third course
                        Console.Write("Mark:\t\t\t");
                        mark3 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark3 < 0 || mark3 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Will change the background color to cyan and text color black, which highlights the report card/outputted information
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("");

                    // Displays all the information collected from above (full name, student number, homeroom number, courses, marks)
                    Console.WriteLine("Report Card");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Name:\t\t" + firstName + " " + lastName);
                    Console.WriteLine("Student Number:\t" + studentNumber);
                    Console.WriteLine("Homeroom:\t" + homeroom);

                    Console.WriteLine("");
                    Console.WriteLine("Mark:\t\tCourse:");
                    Console.WriteLine(mark1 + "\t\t" + courseName1);
                    Console.WriteLine(mark2 + "\t\t" + courseName2);
                    Console.WriteLine(mark3 + "\t\t" + courseName3);
                    Console.WriteLine("");
                    Console.WriteLine("Student Average: " + ((mark1 + mark2 + mark3) / 3)); // Calculation to get the student's average based on the marks provided

                    // Reverts the background and text color to black and white
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                else if (courses == 4) // Will only enter this condition if the number of courses the student is taking is 4
                {
                    // Prompt for the first course's name
                    Console.Write("Course #1:\t\t");
                    courseName1 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the mark of the first course
                        Console.Write("Mark:\t\t\t");
                        mark1 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark1 < 0 || mark1 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Prompt for the second course's name
                    Console.Write("Course #2:\t\t");
                    courseName2 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the mark of the second course
                        Console.Write("Mark:\t\t\t");
                        mark2 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark2 < 0 || mark2 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Prompt for the third course's name
                    Console.Write("Course #3:\t\t");
                    courseName3 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the mark of the third course
                        Console.Write("Mark:\t\t\t");
                        mark3 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark3 < 0 || mark3 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Prompt for the fourth course's name
                    Console.Write("Course #4:\t\t");
                    courseName4 = Console.ReadLine();
                    // do while loop to get the mark
                    do
                    {
                        // Prompt for the makr of the fourth course
                        Console.Write("Mark:\t\t\t");
                        mark4 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (mark4 < 0 || mark4 > 100); // Will let the user proceed if the mark is between 0 and 100 inclusive

                    // Will change the background color to cyan and text color black, which highlights the report card/outputted information
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    // Displays all the information collected from above (full name, student number, homeroom number, courses, marks)
                    Console.WriteLine("");
                    Console.WriteLine("Report Card");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Name:\t\t" + firstName + " " + lastName);
                    Console.WriteLine("Student Number:\t" + studentNumber);
                    Console.WriteLine("Homeroom:\t" + homeroom);

                    Console.WriteLine("");
                    Console.WriteLine("Mark:\t\tCourse:");
                    Console.WriteLine(mark1 + "\t\t" + courseName1);
                    Console.WriteLine(mark2 + "\t\t" + courseName2);
                    Console.WriteLine(mark3 + "\t\t" + courseName3);
                    Console.WriteLine(mark4 + "\t\t" + courseName4);
                    Console.WriteLine("");
                    Console.WriteLine("Student Average:\t" + ((mark1 + mark2 + mark3 + mark4) / 4)); // Calculation to get the student's average based on the marks provided

                    // Reverts the background and text color to black and white
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}