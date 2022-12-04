using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// calculations of a rectangle
namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double length, width, area, perimeter;

            // give user a menue to ask him what he wants to do
            Console.WriteLine("Calculate the area and perimeter of a rectangle");

            // get the length from the user
            Console.Write("Please enter the length of the rectangle:");
            length = Convert.ToDouble(Console.ReadLine());

            // get the width from the user
            Console.Write("Please enter the width of the rectangle:");
            width = Convert.ToDouble(Console.ReadLine());

            // calculate the area
            area = length * width;

            // calculate the perimeter
            perimeter = 2 * (length + width);

            // display the results
            Console.WriteLine("The area of the rectangle is {0}", area);
            Console.WriteLine("The perimeter of the rectangle is {0}", perimeter);

            // wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.ReadKey();
        }
    }
}



