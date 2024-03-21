// Jeffrey Wong
// ICS3U
// September 26th 2023
// B7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num != 0);

            Console.WriteLine("You found the right number!");
            Console.ReadKey();
        }
    }
}