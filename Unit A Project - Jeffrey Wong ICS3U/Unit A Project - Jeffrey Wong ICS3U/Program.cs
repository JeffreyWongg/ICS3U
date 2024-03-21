//Jeffrey Wong
//ICS3U
//September 12th 2023
//Unit A Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_A_Project___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for toonies and then allows the user to input
            Console.Write("Toonies:  ");
            int toonies = Convert.ToInt32(Console.ReadLine());

            // Prompt for loonies and then allows the user to input
            Console.Write("Loonies:  ");
            int loonies = Convert.ToInt32(Console.ReadLine());

            // Prompt for quarters and then allows the user to input
            Console.Write("Quarters: ");
            int quarters = Convert.ToInt32(Console.ReadLine());

            // Prompt for dimes and then allows the user to input
            Console.Write("Dimes:    ");
            int dimes = Convert.ToInt32(Console.ReadLine());

            // Prompt for nickels and then allows the user to input
            Console.Write("Nickels:  ");
            int nickels = Convert.ToInt32(Console.ReadLine());

            // Prompt for pennies and then allows the user to input
            Console.Write("Pennies:  ");
            int pennies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // Calculating the total number of coins
            int sumCoins = (toonies + loonies + quarters + dimes + nickels + pennies);

            // Calculating the value of each coin in cents or pennies
            int valueCoins = ((toonies * 200) + (loonies * 100) + (quarters * 25) + (dimes * 10) + (nickels * 5) + (pennies));

            // Displays a long list of the amount of each coin they have
            Console.WriteLine("You entered: ");
            Console.WriteLine(toonies + "\t Toonie(s)");
            Console.WriteLine(loonies + "\t Loonie(s)");
            Console.WriteLine(quarters + "\t Quarter(s)");
            Console.WriteLine(dimes + "\t Dime(s)");
            Console.WriteLine(nickels + "\t Nickel(s)");

            Console.WriteLine(pennies + "\t Pennie(s)");
            Console.WriteLine("");

            // Displays the final message after all calculations
            Console.WriteLine("The value of your " + sumCoins + " coin(s) is equivalent to " + valueCoins + " pennies");

            Console.ReadKey();

        }
    }
}
