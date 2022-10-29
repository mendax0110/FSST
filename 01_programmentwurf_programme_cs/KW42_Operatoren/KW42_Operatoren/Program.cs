using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// calculator with basic +, -, *, /, %
class Taschenrechner
{
    static void Main(string[] args)
    {
        // user give two numbers
        Console.WriteLine("Geben Sie die erste Zahl ein:");
        int zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Geben Sie die zweite Zahl ein:");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        // let the user decide which operation he wants to do: +, -, *, /, %
        Console.WriteLine("Welche Operation möchten Sie durchführen? (+, -, *, /, %)");
        string operation = Console.ReadLine();

        // do the operation which the user has chosen
        switch (operation)
        {
            case "+":
                Console.WriteLine("Das Ergebnis ist: " + (zahl1 + zahl2));
                break;
            case "-":
                Console.WriteLine("Das Ergebnis ist: " + (zahl1 - zahl2));
                break;
            case "*":
                Console.WriteLine("Das Ergebnis ist: " + (zahl1 * zahl2));
                break;
            case "/":
                Console.WriteLine("Das Ergebnis ist: " + (zahl1 / zahl2));
                break;
            case "%":
                Console.WriteLine("Das Ergebnis ist: " + (zahl1 % zahl2));
                break;
            default:
                Console.WriteLine("Falsche Eingabe!");
                break;
        }

        // ask the user if he wants to do another operation
        Console.WriteLine("Möchten Sie eine weitere Operation durchführen? (j/n)");
        string answer = Console.ReadLine();

        // if he wants to do another operation, start the program again
        if (answer == "j")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Auf Wiedersehen!");
            Console.ReadKey();
        }
    }
}