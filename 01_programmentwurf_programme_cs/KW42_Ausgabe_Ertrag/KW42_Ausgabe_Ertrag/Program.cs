using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW42_Ausgabe_Ertrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lass den user das startkapital eingeben
            Console.Write("Bitte geben Sie das Startkapital ein: ");
            //speichere das startkapital in double startkapital
            double startkapital = Convert.ToDouble(Console.ReadLine());
            // lass den user die anzahl der jahre eingeben
            Console.Write("Bitte geben Sie die Anzahl der Jahre ein: ");
            //speichere die anzahl der jahre in int jahre
            int jahre = Convert.ToInt32(Console.ReadLine());

            // Startkapital+((Startkapital * Jahre) * 10%)
            double ertrag = startkapital + ((startkapital * jahre) * 0.1);

            // gebe den ertrag aus
            Console.WriteLine("Der Ertrag beträgt: " + ertrag);

            // frage ob der user nochmal ausrechnen will
            Console.Write("Möchten Sie nochmal ausrechnen? (j/n)");
            // speichere die eingabe in string antwort
            string antwort = Console.ReadLine();

            // wenn die antwort j ist
            if (antwort == "j")
            {
                // rufe die main methode auf
                Main(args);
            }
            else
            {
                Console.WriteLine("Auf Wiedersehen!");
                Console.ReadKey();
            }
        }
    }
}
