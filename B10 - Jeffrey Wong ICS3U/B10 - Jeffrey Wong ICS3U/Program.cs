// Jeffrey Wong
// ICS3U
// September 29th 2023
// B10  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            do
            {
                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age >= 30)
                {
                    Console.WriteLine("You are old!");
                }
            }
            while (age >= 0);

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
