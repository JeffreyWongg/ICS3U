using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9___Jeffrey_Wong_ICS3U
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";

            Console.Write("First Name: \n");
            firstName = Console.ReadLine();

            Console.Write("Last Name: \n");
            lastName = Console.ReadLine();

            Console.Write("Hello " + firstName + " " + lastName + ", hope you are doing well!");

            Console.ReadKey();
        }
    }
}
