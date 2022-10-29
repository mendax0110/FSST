using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW42_Ausgabe_Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calculate the area of a rectangle
            //ask user for the length
            Console.WriteLine("Please enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            // ask user for the width
            Console.WriteLine("Please enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            // calculate the area
            double area = length * width;

            // print the result
            Console.WriteLine("The area of the rectangle is {0}", area);

            // ask the user if he wants to calculate another rectangle
            Console.WriteLine("Do you want to calculate another rectangle? (y/n)");
            string answer = Console.ReadLine();

            // if the user wants to calculate another rectangle, start the program again
            if (answer == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thank you for using this program");
                Console.ReadKey();
            }
        }
    }
}
