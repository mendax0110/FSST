using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW42_Umwandlung_Uhrzeit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wandle eine Uhrzeit in Stunden von PM (24h Format) nach AM (12h Format) um.
            // Beispiel: 13:00 -> 1:00 PM

            // get the PM time 
            Console.WriteLine("Enter the PM time (24h format): ");
            string pmTime = Console.ReadLine();

            // 24 hours to 12 hours with calculation
            string[] pmTimeArray = pmTime.Split(':');
            int pmHours = int.Parse(pmTimeArray[0]);
            int pmMinutes = int.Parse(pmTimeArray[1]);
            int amHours = pmHours - 12;
            string amTime = amHours + ":" + pmMinutes + " AM";

            // print the AM time
            Console.WriteLine("The AM time is: " + amTime);

            // ask the user if he wants to convert another time
            Console.WriteLine("Do you want to convert another time? (y/n)");
            string answer = Console.ReadLine();

            // if yes, start the program again
            if (answer == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
                Console.ReadKey();
            }
        }
    }
}
