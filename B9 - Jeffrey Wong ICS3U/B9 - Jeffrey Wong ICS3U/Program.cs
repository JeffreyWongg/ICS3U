// Jeffrey Wong
// ICS3U
// September 27th 2023
// B9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; //initializing the counter variable to use in the do-while loop

            int num; // initializing the num variable to use in the do-while loop
            do // this do while loop will prompt for a number and then add 1 to the counter every time it enters the loop
            {
                // adds one to the counter to track how many times the user has attempted
                counter++;

                // prompt for the user to enter a number which is assigned to variable "num"
                Console.Write(counter + ". Number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num != 0 && num != 9 && counter != 25); // 3 conditions in the while loop, checks if the number inputted is 0, 9 or if they have attempted 25 times

            Console.Write("End");
            Console.ReadKey();
        }
    }
}