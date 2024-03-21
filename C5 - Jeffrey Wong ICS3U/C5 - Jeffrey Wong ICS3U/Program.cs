// Jeffrey Wong
// ICS3U
// October 23rd 2023
// C5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter;
            do
            {
                Console.Write("Letter: ");
                letter = Console.ReadLine();
                    if (letter.CompareTo("A") == 0 || letter.CompareTo("a") == 0)
                    {
                        Console.Write("You Selected A!\n");
                    }
                    else if (letter.CompareTo("B") == 0 || letter.CompareTo("b") == 0)
                    {
                        Console.Write("You Selected B!\n");
                    }
                    else if (letter.CompareTo("X") == 0 || letter.CompareTo("x") == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid Input\n");
                    }
            }
            while (letter.CompareTo("X") != 0 && letter.CompareTo("x") != 0);
            Console.Write("End");
            Console.ReadKey();
        }
    }
}