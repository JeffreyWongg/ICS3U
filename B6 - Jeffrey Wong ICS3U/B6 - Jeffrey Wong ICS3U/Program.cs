// Jeffrey Wong
// ICS3U
// September 25th, 2023
// B6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Degrees C \t |\tDegrees F");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i <= 100; i+=5)
            {
                double farhenheit = (i * 1.8) + 32;
                Console.WriteLine(i + "\t\t |\t" + farhenheit);
            }
            Console.ReadKey();
        }
    }
}
