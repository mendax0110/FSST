using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW42_Berechnungen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ask the user for a string
            Console.WriteLine("Geben Sie einen String ein: ");
            Console.WriteLine("-------------------------------\n");
            // save the input in a string
            string inputString = Console.ReadLine();
            // print the string
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Hallo: " + inputString);
            // ask the user for a int
            Console.WriteLine("Geben Sie eine Zahl ein: ");
            Console.WriteLine("-------------------------------\n");
            // save the input in a int
            int inputInt = Convert.ToInt32(Console.ReadLine());
            // print the int
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Ihre Zahl: " + inputInt);
            // ask the user for a double
            Console.WriteLine("Geben Sie eine Kommazahl ein: ");
            Console.WriteLine("-------------------------------\n");
            // save the input in a double
            double inputDouble = Convert.ToDouble(Console.ReadLine());
            // print the double
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Ihre Kommazahl: " + inputDouble);

            // ask the user if he want to do the programm again
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Wollen Sie das Programm noch einmal ausführen? (j/n)");
            Console.WriteLine("--------------------------------------------------\n");
            //loop the programm if the user want to
            while (Console.ReadLine() == "j")
            {
                // go to the beginning of the programm
                Main(args);
            }

            // read the keyboard input
            Console.ReadKey();
        }
    }
}
