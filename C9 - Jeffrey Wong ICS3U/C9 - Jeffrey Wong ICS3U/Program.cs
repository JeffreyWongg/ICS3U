// Jeffrey Wong
// ICS3U
// November 8th 2023
// C9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            int numOfNumbers;
            string count;

            do
            {
                do
                {
                    Console.WriteLine("How many numbers?");
                    count = Console.ReadLine();
                }
                while (!isInteger(count));
            }
            while (Convert.ToInt32(count) <= 0);

            numOfNumbers = Convert.ToInt32(count);

            num = new int[numOfNumbers];

            for (int i = 0; i < numOfNumbers; i++)
            {
                do
                {
                    Console.Write("Number #" + (i + 1) + ": ");
                    count = Console.ReadLine();
                }
                while (!isInteger(count));

                num[i] = Convert.ToInt32(count);
            }
            Console.ReadKey();
        }

        static bool isInteger(string s)
        {
            try
            {
                Convert.ToInt32(s);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
    }
}