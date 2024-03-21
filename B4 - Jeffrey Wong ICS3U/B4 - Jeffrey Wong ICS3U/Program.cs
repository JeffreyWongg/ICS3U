// Jeffrey Wong
// ICS3U
// September 22nd 2023
// B4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}