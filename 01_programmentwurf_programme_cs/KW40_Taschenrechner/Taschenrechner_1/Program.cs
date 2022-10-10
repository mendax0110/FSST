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
        int zahl1, zahl2, ergebnis;
        char rechenzeichen;
        // get the number from the user
        Console.WriteLine("Geben sie eine Zahl ein");
        zahl1 = Convert.ToInt32(Console.ReadLine());
        // let the user device, which mathematical operator to use
        Console.WriteLine("Geben sie ein Rechenzeichen ein, verfügbar sind: +, -, /, *, %");
        rechenzeichen = Convert.ToChar(Console.ReadLine());
        // get the second number from the user
        Console.WriteLine("Geben sie eine Zahl ein");
        zahl2 = Convert.ToInt32(Console.ReadLine());
        if (rechenzeichen == '+')
        {
            ergebnis = zahl1 + zahl2;
            Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        }
        else if (rechenzeichen == '-')
        {
            ergebnis = zahl1 - zahl2;
            Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        }
        else if (rechenzeichen == '*')
        {
            ergebnis = zahl1 * zahl2;
            Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        }
        else if (rechenzeichen == '/')
        {
            ergebnis = zahl1 / zahl2;
            Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        }
        else if (rechenzeichen == '%')
        {
            ergebnis = zahl1 % zahl2;
            Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        }
        else
        {
            Console.WriteLine("Das Rechenzeichen ist nicht bekannt");
        }
        Console.ReadKey();
    }
}