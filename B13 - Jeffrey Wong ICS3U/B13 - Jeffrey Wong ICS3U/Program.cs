// Jeffrey Wong
// ICS3U
// October 2nd 2023
// B13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
            }
            Console.Write("End");
            Console.ReadKey();
        }
    }
}
