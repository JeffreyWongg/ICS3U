// Jeffrey Wong
// ICS3U
// September 25th 2023
// B5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++) // The outer for loop, used to create 10 total lines 
            {
                for (int j = 9; j > i; j--) // The inner for loop that uses a negative step to remove one space every time it loops, it essentially makes the asterisk one space closer than the previous
                {
                    Console.Write(" "); // Prints an empty space
                }
                Console.Write("*\n"); // Print an asterisks after the spaces are done being printed
            }
            Console.ReadKey();
        }
    }
}
