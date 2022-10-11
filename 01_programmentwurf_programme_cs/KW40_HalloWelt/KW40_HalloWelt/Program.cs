using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// simple hello world with user input
namespace KW40_HalloWelt
{
    class HelloWorld
    {
        // entrypoint for the program
        static void Main(string[] args)
        {
            string name;
            // print hello world
            Console.WriteLine("Hello World!");
            // ask for name
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            // print hello *name*
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}