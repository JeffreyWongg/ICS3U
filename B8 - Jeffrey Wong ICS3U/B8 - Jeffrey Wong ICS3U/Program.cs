using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int num;
            do
            {
                Console.Write("Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                counter++;
            }
            while (num != 0);

            Console.Write("You found the number!\n");
            Console.Write("You entered " + counter + " numbers!");

            Console.ReadKey();
        }
    }
}
